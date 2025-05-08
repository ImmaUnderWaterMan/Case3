using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using BestDelivery;

namespace Case3
{

    public partial class FormCourier : Form
    {
        public FormCourier()
        {
            InitializeComponent();
        }

        private void buttonTakeOrder_Click(object sender, EventArgs e)
        {
            if (OrderQueue.Queue.Count > 0)
            {
                List<Order> orders = OrderQueue.Queue.Dequeue();
                AddMarkersFromPoints(orders);
            }
            else
            {
                MessageBox.Show("No orders in the queue.");
            }
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
        }


        private void AddMarkersFromPoints(List<Order> orders)
        {
            GMapOverlay markersOverlay = new GMapOverlay("markers");


            BestDelivery.Point depot = new BestDelivery.Point { X = 48.773713, Y = 44.802360 };


            listBoxDistances.Items.Clear();

            foreach (var order in orders)
            {
                PointLatLng latLng = new PointLatLng(order.Destination.X, order.Destination.Y);
                GMarkerGoogle marker = new GMarkerGoogle(latLng, GMarkerGoogleType.red);
                marker.ToolTip = new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker);
                marker.ToolTipText = $"Заказ ID: {order.ID}, Координаты: ({order.Destination.X}, {order.Destination.Y})";
                markersOverlay.Markers.Add(marker);

                double distance = RoutingTestLogic.CalculateDistance(depot, order.Destination);
                double Metr_distance = GeodesicDistance.CalculateDistance(distance);

                listBoxDistances.Items.Add($"Заказ ID: {order.ID}, Расстояние от пункта выдачи: {Metr_distance}");
            }

            gMapControl1.Overlays.Add(markersOverlay);
        }
        private void buttonCompleteOrder_Click(object sender, EventArgs e)
        {
            listBoxDistances.Items.Clear();

            GMapOverlay markersOverlay = gMapControl1.Overlays.FirstOrDefault(o => o.Id.Equals("markers"));
            if (markersOverlay != null)
            {

                var markersToRemove = markersOverlay.Markers
                    .Where(marker => marker is GMarkerGoogle gMarker && gMarker.Type != GMarkerGoogleType.pink)
                    .ToList();

                foreach (var marker in markersToRemove)
                {
                    markersOverlay.Markers.Remove(marker);
                }
            }

            MessageBox.Show("Заказ завершен.");
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}




