using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using System.Xml.Linq;
using GMap.NET;
using Newtonsoft.Json.Linq;
using BestDelivery;

namespace Case3
{
    public partial class FormAdmin : Form
    {

        private bool canAddPoints = false;

        private readonly string _apiKey = "MxbFpHXOHBAlhTLTqdCsNLcnrpUFFsBmOXJFoMtDP7bE9NfzhvecirAYsx22NTnP";
        private readonly string _distanceMatrixApiUrl = "https://api.distancematrix.ai/maps/api/distancematrix/json";
        private List<Order> orders = new List<Order>();
        private Queue<List<Order>> orderQueue = new Queue<List<Order>>();

        public List<BestDelivery.Point> Points { get; set; }

        public FormAdmin(List<BestDelivery.Point> points = null)
        {
            InitializeComponent();

            Points = points ?? new List<BestDelivery.Point>();
            this.FormClosing += FormAdmin_FormClosing;
        }

        private void buttonAddAdress_Click(object sender, EventArgs e)
        {
            canAddPoints = true;
        }


        private void gMapControl1_Load(object sender, EventArgs e)
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gMapControl1.MinZoom = 2;
            gMapControl1.MaxZoom = 16;
            gMapControl1.Zoom = 16;
            gMapControl1.Position = new GMap.NET.PointLatLng(48.773713, 44.802360);
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gMapControl1.CanDragMap = true;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.ShowCenter = false;
            gMapControl1.ShowTileGridLines = false;


            PointLatLng permanentPoint = new PointLatLng(48.773713, 44.802360);
            GMarkerGoogle permanentMarker = new GMarkerGoogle(permanentPoint, GMarkerGoogleType.pink);
            permanentMarker.ToolTip = new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(permanentMarker);
            permanentMarker.ToolTipText = "Склад";
            permanentMarker.ToolTipMode = MarkerTooltipMode.Always;

            GMapOverlay markersOverlay = gMapControl1.Overlays.FirstOrDefault(o => o.Id.Equals("markers")) ?? new GMapOverlay("markers");
            markersOverlay.Markers.Add(permanentMarker);

            if (!gMapControl1.Overlays.Contains(markersOverlay))
            {
                gMapControl1.Overlays.Add(markersOverlay);
            }


            AddMarkersFromPoints();
        }


        private void AddMarkersFromPoints()
        {
            GMapOverlay markersOverlay = new GMapOverlay("markers");

            foreach (var point in Points)
            {
                PointLatLng latLng = new PointLatLng(point.X, point.Y);
                GMarkerGoogle marker = new GMarkerGoogle(latLng, GMarkerGoogleType.red);
                markersOverlay.Markers.Add(marker);
            }

            gMapControl1.Overlays.Add(markersOverlay);
        }

        private async void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!canAddPoints)
            {
                return;
            }


            PointLatLng point = gMapControl1.FromLocalToLatLng(e.X, e.Y);


            GMarkerGoogle marker = new GMarkerGoogle(point, GMarkerGoogleType.red);


            string address = await GetAddressFromLatLng(point.Lat, point.Lng);
            marker.ToolTip = new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker);
            marker.ToolTipText = address;
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;


            GMapOverlay markersOverlay = gMapControl1.Overlays.FirstOrDefault(o => o.Id.Equals("markers")) ?? new GMapOverlay("markers");


            markersOverlay.Markers.Add(marker);


            if (!gMapControl1.Overlays.Contains(markersOverlay))
            {
                gMapControl1.Overlays.Add(markersOverlay);
            }

            double latRounded = Math.Round(point.Lat, 6);
            double lngRounded = Math.Round(point.Lng, 6);


            AddOrder(point, (double)numericUpDownPriority.Value);
        }

        private void AddOrder(PointLatLng point, double priority)
        {
            int orderId = orders.Count + 1;
            Order newOrder = new Order
            {
                ID = orderId,
                Destination = new BestDelivery.Point { X = point.Lat, Y = point.Lng },
                Priority = priority
            };

            orders.Add(newOrder);
        }





        private async Task<string> GetAddressFromLatLng(double lat, double lng)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"{_distanceMatrixApiUrl}?origins={lat},{lng}&destinations={lat},{lng}&key={_apiKey}";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();


                JObject json = JObject.Parse(responseBody);
                string address = json["destination_addresses"]?[0]?.ToString();

                return address ?? "Address not found";
            }
        }
        private void buttonSaveOrder_Click(object sender, EventArgs e)
        {
            if (orders.Count > 0)
            {

                OrderQueue.Queue.Enqueue(new List<Order>(orders));
                orders.Clear(); 
                MessageBox.Show("Заказ сохранен.");
            }
            else
            {
                MessageBox.Show("Нет заказов для сохранения.");
            }
        }
        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {

            Points.Clear();


            foreach (var overlay in gMapControl1.Overlays)
            {
                overlay.Markers.Clear();
            }


            gMapControl1.Refresh();
        }


    }
}
