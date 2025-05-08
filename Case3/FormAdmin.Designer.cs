namespace Case3
{
    partial class FormAdmin
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
            buttonAddAdress = new Button();
            buttonSaveOrder = new Button();
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            numericUpDownPriority = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPriority).BeginInit();
            SuspendLayout();
            // 
            // buttonAddAdress
            // 
            buttonAddAdress.Location = new Point(12, 399);
            buttonAddAdress.Name = "buttonAddAdress";
            buttonAddAdress.Size = new Size(126, 39);
            buttonAddAdress.TabIndex = 2;
            buttonAddAdress.Text = "Добавить точку доставки";
            buttonAddAdress.UseVisualStyleBackColor = true;
            buttonAddAdress.Click += buttonAddAdress_Click;
            // 
            // buttonSaveOrder
            // 
            buttonSaveOrder.Location = new Point(484, 412);
            buttonSaveOrder.Name = "buttonSaveOrder";
            buttonSaveOrder.Size = new Size(112, 26);
            buttonSaveOrder.TabIndex = 3;
            buttonSaveOrder.Text = "Сохранить заказ";
            buttonSaveOrder.UseVisualStyleBackColor = true;
            buttonSaveOrder.Click += buttonSaveOrder_Click;
            // 
            // gMapControl1
            // 
            gMapControl1.Bearing = 0F;
            gMapControl1.CanDragMap = true;
            gMapControl1.EmptyTileColor = Color.Navy;
            gMapControl1.GrayScaleMode = false;
            gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl1.LevelsKeepInMemory = 5;
            gMapControl1.Location = new Point(12, 12);
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
            gMapControl1.Size = new Size(584, 381);
            gMapControl1.TabIndex = 4;
            gMapControl1.Zoom = 0D;
            gMapControl1.Load += gMapControl1_Load;
            gMapControl1.MouseClick += gMapControl1_MouseClick;
            // 
            // numericUpDownPriority
            // 
            numericUpDownPriority.DecimalPlaces = 1;
            numericUpDownPriority.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownPriority.Location = new Point(174, 409);
            numericUpDownPriority.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownPriority.Name = "numericUpDownPriority";
            numericUpDownPriority.Size = new Size(120, 23);
            numericUpDownPriority.TabIndex = 5;
            numericUpDownPriority.ThousandsSeparator = true;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 450);
            Controls.Add(numericUpDownPriority);
            Controls.Add(gMapControl1);
            Controls.Add(buttonSaveOrder);
            Controls.Add(buttonAddAdress);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormAdmin";
            Text = "FormAdmin";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPriority).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonAddAdress;
        private Button buttonSaveOrder;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private NumericUpDown numericUpDownPriority;
    }
}