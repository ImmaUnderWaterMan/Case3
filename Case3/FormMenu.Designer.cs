namespace Case3
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            buttonLogInAsСourier = new Button();
            buttonLogInAsAdmin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(272, 9);
            label1.Name = "label1";
            label1.Size = new Size(226, 52);
            label1.TabIndex = 0;
            label1.Text = "Ya-dostavka\r\n";
            // 
            // buttonLogInAsСourier
            // 
            buttonLogInAsСourier.BackColor = Color.LightYellow;
            buttonLogInAsСourier.Font = new Font("Viner Hand ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogInAsСourier.Location = new Point(159, 204);
            buttonLogInAsСourier.Name = "buttonLogInAsСourier";
            buttonLogInAsСourier.Size = new Size(100, 40);
            buttonLogInAsСourier.TabIndex = 1;
            buttonLogInAsСourier.Text = "Курьер";
            buttonLogInAsСourier.UseVisualStyleBackColor = false;
            buttonLogInAsСourier.Click += buttonLogInAsCourier_Clicked;
            // 
            // buttonLogInAsAdmin
            // 
            buttonLogInAsAdmin.BackColor = Color.LightYellow;
            buttonLogInAsAdmin.Font = new Font("Viner Hand ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogInAsAdmin.Location = new Point(535, 204);
            buttonLogInAsAdmin.Name = "buttonLogInAsAdmin";
            buttonLogInAsAdmin.Size = new Size(100, 40);
            buttonLogInAsAdmin.TabIndex = 2;
            buttonLogInAsAdmin.Text = "Admin";
            buttonLogInAsAdmin.UseVisualStyleBackColor = false;
            buttonLogInAsAdmin.Click += buttonLogInAsAdmin_Clicked;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLogInAsAdmin);
            Controls.Add(buttonLogInAsСourier);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ya-dostavka";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonLogInAsСourier;
        private Button buttonLogInAsAdmin;
    }
}
