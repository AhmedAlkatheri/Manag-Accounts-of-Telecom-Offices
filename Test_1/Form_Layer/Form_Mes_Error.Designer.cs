namespace Test_1.Form_Layer
{
    partial class Form_Mes_Error
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Mes_Error));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pay_bt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "اسم الفئة أو الباقة أو الشريحة خاطئة";
            // 
            // pay_bt
            // 
            this.pay_bt.BackColor = System.Drawing.Color.Transparent;
            this.pay_bt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pay_bt.BackgroundImage")));
            this.pay_bt.ButtonText = "موافق";
            this.pay_bt.ButtonTextMarginLeft = 0;
            this.pay_bt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.pay_bt.DisabledFillColor = System.Drawing.Color.Gray;
            this.pay_bt.DisabledForecolor = System.Drawing.Color.White;
            this.pay_bt.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_bt.ForeColor = System.Drawing.Color.White;
            this.pay_bt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.pay_bt.IconPadding = 10;
            this.pay_bt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.pay_bt.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pay_bt.IdleBorderRadius = 1;
            this.pay_bt.IdleBorderThickness = 0;
            this.pay_bt.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pay_bt.IdleIconLeftImage = null;
            this.pay_bt.IdleIconRightImage = null;
            this.pay_bt.Location = new System.Drawing.Point(159, 179);
            this.pay_bt.Name = "pay_bt";
            stateProperties1.BorderColor = System.Drawing.Color.Maroon;
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.Maroon;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.pay_bt.onHoverState = stateProperties1;
            this.pay_bt.Size = new System.Drawing.Size(101, 45);
            this.pay_bt.TabIndex = 17;
            this.pay_bt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pay_bt.Click += new System.EventHandler(this.pay_bt_Click);
            // 
            // Form_Mes_Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 261);
            this.Controls.Add(this.pay_bt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Mes_Error";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Mes_Error";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton pay_bt;
    }
}