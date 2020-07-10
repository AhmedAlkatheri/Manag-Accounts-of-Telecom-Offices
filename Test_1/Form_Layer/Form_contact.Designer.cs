namespace Test_1.Form_Layer
{
    partial class Form_contact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_contact));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.rbSQL = new System.Windows.Forms.RadioButton();
            this.rbWindows = new System.Windows.Forms.RadioButton();
            this.name = new System.Windows.Forms.Label();
            this.txtServer = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnExit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDatabase = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtPWD = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Error_txt = new System.Windows.Forms.Label();
            this.Error_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Error_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // rbSQL
            // 
            this.rbSQL.AutoSize = true;
            this.rbSQL.Location = new System.Drawing.Point(176, 350);
            this.rbSQL.Name = "rbSQL";
            this.rbSQL.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbSQL.Size = new System.Drawing.Size(151, 17);
            this.rbSQL.TabIndex = 45;
            this.rbSQL.Text = "SQL Server Authentication";
            this.rbSQL.UseVisualStyleBackColor = true;
            this.rbSQL.CheckedChanged += new System.EventHandler(this.rbSQL_CheckedChanged);
            // 
            // rbWindows
            // 
            this.rbWindows.AutoSize = true;
            this.rbWindows.Checked = true;
            this.rbWindows.Location = new System.Drawing.Point(176, 307);
            this.rbWindows.Name = "rbWindows";
            this.rbWindows.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbWindows.Size = new System.Drawing.Size(140, 17);
            this.rbWindows.TabIndex = 44;
            this.rbWindows.TabStop = true;
            this.rbWindows.Text = "Windows Authentication";
            this.rbWindows.UseVisualStyleBackColor = true;
            this.rbWindows.CheckedChanged += new System.EventHandler(this.rbWindows_CheckedChanged);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.name.Location = new System.Drawing.Point(50, 21);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(188, 29);
            this.name.TabIndex = 56;
            this.name.Text = "اعدادت اتصال بالسيرفر";
            // 
            // txtServer
            // 
            this.txtServer.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.txtServer.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtServer.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.txtServer.BorderThickness = 3;
            this.txtServer.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtServer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtServer.isPassword = false;
            this.txtServer.Location = new System.Drawing.Point(176, 131);
            this.txtServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtServer.MaxLength = 32767;
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(196, 44);
            this.txtServer.TabIndex = 55;
            this.txtServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.ButtonText = "اغلاق";
            this.btnExit.ButtonTextMarginLeft = 0;
            this.btnExit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnExit.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnExit.DisabledForecolor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.IconPadding = 10;
            this.btnExit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.IdleBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.IdleBorderRadius = 1;
            this.btnExit.IdleBorderThickness = 0;
            this.btnExit.IdleFillColor = System.Drawing.Color.DarkGray;
            this.btnExit.IdleIconLeftImage = null;
            this.btnExit.IdleIconRightImage = null;
            this.btnExit.Location = new System.Drawing.Point(254, 611);
            this.btnExit.Name = "btnExit";
            stateProperties1.BorderColor = System.Drawing.Color.Gray;
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.Gray;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnExit.onHoverState = stateProperties1;
            this.btnExit.Size = new System.Drawing.Size(118, 45);
            this.btnExit.TabIndex = 54;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.ButtonText = "حفظ";
            this.btnSave.ButtonTextMarginLeft = 0;
            this.btnSave.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSave.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnSave.DisabledForecolor = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.IconPadding = 10;
            this.btnSave.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnSave.IdleBorderRadius = 1;
            this.btnSave.IdleBorderThickness = 0;
            this.btnSave.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnSave.IdleIconLeftImage = null;
            this.btnSave.IdleIconRightImage = null;
            this.btnSave.Location = new System.Drawing.Point(53, 611);
            this.btnSave.Name = "btnSave";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnSave.onHoverState = stateProperties2;
            this.btnSave.Size = new System.Drawing.Size(126, 45);
            this.btnSave.TabIndex = 53;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "اسم السيرفر:";
            // 
            // txtDatabase
            // 
            this.txtDatabase.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.txtDatabase.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDatabase.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.txtDatabase.BorderThickness = 3;
            this.txtDatabase.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDatabase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDatabase.isPassword = false;
            this.txtDatabase.Location = new System.Drawing.Point(176, 221);
            this.txtDatabase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDatabase.MaxLength = 32767;
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(196, 44);
            this.txtDatabase.TabIndex = 57;
            this.txtDatabase.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtID
            // 
            this.txtID.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.txtID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtID.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.txtID.BorderThickness = 3;
            this.txtID.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtID.isPassword = false;
            this.txtID.Location = new System.Drawing.Point(176, 408);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(196, 44);
            this.txtID.TabIndex = 58;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPWD
            // 
            this.txtPWD.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.txtPWD.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPWD.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.txtPWD.BorderThickness = 3;
            this.txtPWD.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPWD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPWD.Enabled = false;
            this.txtPWD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPWD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPWD.isPassword = true;
            this.txtPWD.Location = new System.Drawing.Point(176, 498);
            this.txtPWD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPWD.MaxLength = 32767;
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.Size = new System.Drawing.Size(196, 44);
            this.txtPWD.TabIndex = 59;
            this.txtPWD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "قاعدة البيانات:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 61;
            this.label8.Text = "طريقة الولوج:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 422);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 62;
            this.label9.Text = "اسم المستخدم:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(49, 510);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 63;
            this.label10.Text = "كلمة المرور:";
            // 
            // Error_txt
            // 
            this.Error_txt.AutoSize = true;
            this.Error_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_txt.ForeColor = System.Drawing.Color.Red;
            this.Error_txt.Location = new System.Drawing.Point(145, 78);
            this.Error_txt.Name = "Error_txt";
            this.Error_txt.Size = new System.Drawing.Size(188, 20);
            this.Error_txt.TabIndex = 64;
            this.Error_txt.Text = "اعد ضبط اعدادات اتصال بالسيرفر";
            this.Error_txt.Visible = false;
            // 
            // Error_pic
            // 
            this.Error_pic.Image = ((System.Drawing.Image)(resources.GetObject("Error_pic.Image")));
            this.Error_pic.Location = new System.Drawing.Point(98, 68);
            this.Error_pic.Name = "Error_pic";
            this.Error_pic.Size = new System.Drawing.Size(41, 40);
            this.Error_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Error_pic.TabIndex = 65;
            this.Error_pic.TabStop = false;
            this.Error_pic.Visible = false;
            // 
            // Form_contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 700);
            this.Controls.Add(this.Error_pic);
            this.Controls.Add(this.Error_txt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPWD);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.name);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbSQL);
            this.Controls.Add(this.rbWindows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_contact";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_contact";
            ((System.ComponentModel.ISupportInitialize)(this.Error_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbSQL;
        private System.Windows.Forms.RadioButton rbWindows;
        public System.Windows.Forms.Label name;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtServer;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExit;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSave;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDatabase;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtID;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPWD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label Error_txt;
        public System.Windows.Forms.PictureBox Error_pic;
    }
}