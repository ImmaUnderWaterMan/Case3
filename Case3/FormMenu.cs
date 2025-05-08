namespace Case3
{
    public partial class FormMenu : Form
    {
        private List<BestDelivery.Point> points = new List<BestDelivery.Point>();


        public FormMenu()
        {
            InitializeComponent();
        }
        private void buttonLogInAsAdmin_Clicked(object sender, EventArgs e)
        {
            FormAdmin admin = new FormAdmin(points);
            admin.Show();
        }

        private void buttonLogInAsCourier_Clicked(object sender, EventArgs e)
        {
            FormCourier courier = new FormCourier();
            courier.Show();
        }

    }
}
