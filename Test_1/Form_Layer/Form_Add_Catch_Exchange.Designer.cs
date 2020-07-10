namespace Test_1.Form_Layer
{
    partial class Form_Add_Catch_Exchange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Add_Catch_Exchange));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TheAmount_tx = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.text_tx = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.but_close = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.but_ok = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.client_tx = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.move_cob = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "ملاحظات";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "المبلغ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "الحساب";
            // 
            // TheAmount_tx
            // 
            this.TheAmount_tx.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.TheAmount_tx.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TheAmount_tx.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.TheAmount_tx.BorderThickness = 3;
            this.TheAmount_tx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TheAmount_tx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TheAmount_tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheAmount_tx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TheAmount_tx.isPassword = false;
            this.TheAmount_tx.Location = new System.Drawing.Point(183, 158);
            this.TheAmount_tx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TheAmount_tx.MaxLength = 32767;
            this.TheAmount_tx.Name = "TheAmount_tx";
            this.TheAmount_tx.Size = new System.Drawing.Size(182, 44);
            this.TheAmount_tx.TabIndex = 2;
            this.TheAmount_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // text_tx
            // 
            this.text_tx.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.text_tx.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_tx.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.text_tx.BorderThickness = 3;
            this.text_tx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.text_tx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_tx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_tx.isPassword = false;
            this.text_tx.Location = new System.Drawing.Point(183, 232);
            this.text_tx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.text_tx.MaxLength = 32767;
            this.text_tx.Name = "text_tx";
            this.text_tx.Size = new System.Drawing.Size(182, 44);
            this.text_tx.TabIndex = 3;
            this.text_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // but_close
            // 
            this.but_close.BackColor = System.Drawing.Color.Transparent;
            this.but_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_close.BackgroundImage")));
            this.but_close.ButtonText = "اغلاق";
            this.but_close.ButtonTextMarginLeft = 0;
            this.but_close.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.but_close.DisabledFillColor = System.Drawing.Color.Gray;
            this.but_close.DisabledForecolor = System.Drawing.Color.White;
            this.but_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.but_close.Location = new System.Drawing.Point(243, 388);
            this.but_close.Name = "but_close";
            stateProperties1.BorderColor = System.Drawing.Color.Gray;
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.Gray;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.but_close.onHoverState = stateProperties1;
            this.but_close.Size = new System.Drawing.Size(118, 45);
            this.but_close.TabIndex = 5;
            this.but_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.but_close.Click += new System.EventHandler(this.but_close_Click);
            // 
            // but_ok
            // 
            this.but_ok.BackColor = System.Drawing.Color.Transparent;
            this.but_ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_ok.BackgroundImage")));
            this.but_ok.ButtonText = "موافق";
            this.but_ok.ButtonTextMarginLeft = 0;
            this.but_ok.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.but_ok.DisabledFillColor = System.Drawing.Color.Gray;
            this.but_ok.DisabledForecolor = System.Drawing.Color.White;
            this.but_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.but_ok.Location = new System.Drawing.Point(58, 388);
            this.but_ok.Name = "but_ok";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.but_ok.onHoverState = stateProperties2;
            this.but_ok.Size = new System.Drawing.Size(126, 45);
            this.but_ok.TabIndex = 4;
            this.but_ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.but_ok.Click += new System.EventHandler(this.but_ok_Click);
            // 
            // client_tx
            // 
            this.client_tx.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.client_tx.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.client_tx.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.client_tx.BorderThickness = 3;
            this.client_tx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.client_tx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.client_tx.Enabled = false;
            this.client_tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_tx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.client_tx.isPassword = false;
            this.client_tx.Location = new System.Drawing.Point(183, 90);
            this.client_tx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.client_tx.MaxLength = 32767;
            this.client_tx.Name = "client_tx";
            this.client_tx.Size = new System.Drawing.Size(129, 44);
            this.client_tx.TabIndex = 22;
            this.client_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.name.Location = new System.Drawing.Point(50, 20);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(50, 29);
            this.name.TabIndex = 24;
            this.name.Text = "قبض";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 109;
            this.label4.Text = "حركة";
            // 
            // move_cob
            // 
            this.move_cob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.move_cob.FormattingEnabled = true;
            this.move_cob.Items.AddRange(new object[] {
            "قبض",
            "صرف"});
            this.move_cob.Location = new System.Drawing.Point(183, 313);
            this.move_cob.Name = "move_cob";
            this.move_cob.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.move_cob.Size = new System.Drawing.Size(178, 21);
            this.move_cob.TabIndex = 110;
            // 
            // Form_Add_Catch_Exchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 486);
            this.Controls.Add(this.move_cob);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.client_tx);
            this.Controls.Add(this.but_close);
            this.Controls.Add(this.but_ok);
            this.Controls.Add(this.TheAmount_tx);
            this.Controls.Add(this.text_tx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Add_Catch_Exchange";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Catch_Exchange";
            this.Load += new System.EventHandler(this.Form_Catch_Exchange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuMetroTextbox text_tx;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton but_close;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton but_ok;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label name;
        //public Bunifu.UI.WinForms.BunifuDropdown move_cob;
        public System.Windows.Forms.Label label4;
        public Bunifu.Framework.UI.BunifuMetroTextbox TheAmount_tx;
        public Bunifu.Framework.UI.BunifuMetroTextbox client_tx;
        public System.Windows.Forms.ComboBox move_cob;
    }
}