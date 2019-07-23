namespace Test_1.Form_Layer
{
    partial class Form_Delete_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Delete_Settings));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.but_close = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.but_ok = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Droid Arabic Kufi", 17F);
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.name.Location = new System.Drawing.Point(287, 22);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(68, 43);
            this.name.TabIndex = 56;
            this.name.Text = "حذف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 14F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(84, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 36);
            this.label1.TabIndex = 57;
            this.label1.Text = "هل تريد فعلا حذف المحدد ؟";
            // 
            // but_close
            // 
            this.but_close.BackColor = System.Drawing.Color.Transparent;
            this.but_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_close.BackgroundImage")));
            this.but_close.ButtonText = "تراجع";
            this.but_close.ButtonTextMarginLeft = 0;
            this.but_close.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.but_close.DisabledFillColor = System.Drawing.Color.Gray;
            this.but_close.DisabledForecolor = System.Drawing.Color.White;
            this.but_close.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_close.ForeColor = System.Drawing.Color.White;
            this.but_close.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.but_close.IconPadding = 10;
            this.but_close.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.but_close.IdleBorderColor = System.Drawing.Color.DarkGray;
            this.but_close.IdleBorderRadius = 1;
            this.but_close.IdleBorderThickness = 0;
            this.but_close.IdleFillColor = System.Drawing.Color.DarkGray;
            this.but_close.IdleIconLeftImage = null;
            this.but_close.IdleIconRightImage = null;
            this.but_close.Location = new System.Drawing.Point(86, 162);
            this.but_close.Name = "but_close";
            stateProperties1.BorderColor = System.Drawing.Color.Gray;
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.Gray;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.but_close.onHoverState = stateProperties1;
            this.but_close.Size = new System.Drawing.Size(87, 36);
            this.but_close.TabIndex = 59;
            this.but_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.but_close.Click += new System.EventHandler(this.but_close_Click);
            // 
            // but_ok
            // 
            this.but_ok.BackColor = System.Drawing.Color.Transparent;
            this.but_ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_ok.BackgroundImage")));
            this.but_ok.ButtonText = "حذف";
            this.but_ok.ButtonTextMarginLeft = 0;
            this.but_ok.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.but_ok.DisabledFillColor = System.Drawing.Color.Gray;
            this.but_ok.DisabledForecolor = System.Drawing.Color.White;
            this.but_ok.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_ok.ForeColor = System.Drawing.Color.White;
            this.but_ok.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.but_ok.IconPadding = 10;
            this.but_ok.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.but_ok.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.but_ok.IdleBorderRadius = 1;
            this.but_ok.IdleBorderThickness = 0;
            this.but_ok.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.but_ok.IdleIconLeftImage = null;
            this.but_ok.IdleIconRightImage = null;
            this.but_ok.Location = new System.Drawing.Point(231, 162);
            this.but_ok.Name = "but_ok";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.but_ok.onHoverState = stateProperties2;
            this.but_ok.Size = new System.Drawing.Size(87, 36);
            this.but_ok.TabIndex = 58;
            this.but_ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.but_ok.Click += new System.EventHandler(this.but_ok_Click);
            // 
            // Form_Delete_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 247);
            this.Controls.Add(this.but_close);
            this.Controls.Add(this.but_ok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Delete_Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Delete_Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label name;
        public System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton but_close;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton but_ok;
    }
}