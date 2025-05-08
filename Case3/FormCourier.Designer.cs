namespace Case3
{
    partial class FormCourier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonTakeOrder = new Button();
            button2 = new Button();
            buttonCompleteOrder = new Button();
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            listBoxDistances = new ListBox();
            SuspendLayout();
            // 
            // buttonTakeOrder
            // 
            buttonTakeOrder.Location = new Point(300, 353);
            buttonTakeOrder.Name = "buttonTakeOrder";
            buttonTakeOrder.Size = new Size(85, 42);
            buttonTakeOrder.TabIndex = 1;
            buttonTakeOrder.Text = "Принять заказ";
            buttonTakeOrder.UseVisualStyleBackColor = true;
            buttonTakeOrder.Click += buttonTakeOrder_Click;
            // 
            // button2
            // 
            button2.Location = new Point(413, 424);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Выйти";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonCompleteOrder
            // 
            buttonCompleteOrder.Location = new Point(511, 353);
            buttonCompleteOrder.Name = "buttonCompleteOrder";
            buttonCompleteOrder.Size = new Size(85, 42);
            buttonCompleteOrder.TabIndex = 3;
            buttonCompleteOrder.Text = "Завершить заказ";
            buttonCompleteOrder.UseVisualStyleBackColor = true;
            buttonCompleteOrder.Click += buttonCompleteOrder_Click;
            // 
            // gMapControl1
            // 
            gMapControl1.Bearing = 0F;
            gMapControl1.CanDragMap = true;
            gMapControl1.EmptyTileColor = Color.Navy;
            gMapControl1.GrayScaleMode = false;
            gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl1.LevelsKeepInMemory = 5;
            gMapControl1.Location = new Point(12, 18);
            gMapControl1.MarkersEnabled = true;
            gMapControl1.MaxZoom = 2;
            gMapControl1.MinZoom = 2;
            gMapControl1.MouseWheelZoomEnabled = true;
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gMapControl1.Name = "gMapControl1";
            gMapControl1.NegativeMode = false;
            gMapControl1.PolygonsEnabled = true;
            gMapControl1.RetryLoadTile = 0;
            gMapControl1.RoutesEnabled = true;
            gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gMapControl1.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            gMapControl1.ShowTileGridLines = false;
            gMapControl1.Size = new Size(584, 329);
            gMapControl1.TabIndex = 5;
            gMapControl1.Zoom = 0D;
            gMapControl1.Load += gMapControl1_Load;
            // 
            // listBoxDistances
            // 
            listBoxDistances.FormattingEnabled = true;
            listBoxDistances.ItemHeight = 15;
            listBoxDistances.Location = new Point(12, 353);
            listBoxDistances.Name = "listBoxDistances";
            listBoxDistances.Size = new Size(278, 94);
            listBoxDistances.TabIndex = 7;
            // 
            // FormCourier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 450);
            Controls.Add(listBoxDistances);
            Controls.Add(gMapControl1);
            Controls.Add(buttonCompleteOrder);
            Controls.Add(button2);
            Controls.Add(buttonTakeOrder);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormCourier";
            Text = "FormCourier";
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonTakeOrder;
        private Button button2;
        private Button buttonCompleteOrder;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private ListBox listBoxDistances;
    }
}