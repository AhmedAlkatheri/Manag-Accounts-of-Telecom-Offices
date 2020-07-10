namespace Test_1.Form_Layer
{
    partial class Form_you_pay_part
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_you_pay_part));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.label1 = new System.Windows.Forms.Label();
            this.pay_tx = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pay_bt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.totel_tx = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "هل دفع جزء من المبلغ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pay_tx
            // 
            this.pay_tx.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.pay_tx.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pay_tx.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.pay_tx.BorderThickness = 3;
            this.pay_tx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.pay_tx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pay_tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_tx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pay_tx.isPassword = false;
            this.pay_tx.Location = new System.Drawing.Point(199, 216);
            this.pay_tx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pay_tx.MaxLength = 32767;
            this.pay_tx.Name = "pay_tx";
            this.pay_tx.Size = new System.Drawing.Size(115, 45);
            this.pay_tx.TabIndex = 18;
            this.pay_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pay_tx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pay_tx_KeyPress);
            // 
            // bunifuButton2
            // 
            this.bunifuButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton2.BackgroundImage")));
            this.bunifuButton2.ButtonText = "تراجع";
            this.bunifuButton2.ButtonTextMarginLeft = 0;
            this.bunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuButton2.DisabledFillColor = System.Drawing.Color.Gray;
            this.bunifuButton2.DisabledForecolor = System.Drawing.Color.White;
            this.bunifuButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconPadding = 10;
            this.bunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IdleBorderColor = System.Drawing.Color.DarkGray;
            this.bunifuButton2.IdleBorderRadius = 1;
            this.bunifuButton2.IdleBorderThickness = 0;
            this.bunifuButton2.IdleFillColor = System.Drawing.Color.DarkGray;
            this.bunifuButton2.IdleIconLeftImage = null;
            this.bunifuButton2.IdleIconRightImage = null;
            this.bunifuButton2.Location = new System.Drawing.Point(216, 331);
            this.bunifuButton2.Name = "bunifuButton2";
            stateProperties7.BorderColor = System.Drawing.Color.Gray;
            stateProperties7.BorderRadius = 1;
            stateProperties7.BorderThickness = 1;
            stateProperties7.FillColor = System.Drawing.Color.Gray;
            stateProperties7.IconLeftImage = null;
            stateProperties7.IconRightImage = null;
            this.bunifuButton2.onHoverState = stateProperties7;
            this.bunifuButton2.Size = new System.Drawing.Size(98, 45);
            this.bunifuButton2.TabIndex = 17;
            this.bunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton2.Click += new System.EventHandler(this.bunifuButton2_Click);
            // 
            // pay_bt
            // 
            this.pay_bt.BackColor = System.Drawing.Color.Transparent;
            this.pay_bt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pay_bt.BackgroundImage")));
            this.pay_bt.ButtonText = "حفظ";
            this.pay_bt.ButtonTextMarginLeft = 0;
            this.pay_bt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.pay_bt.DisabledFillColor = System.Drawing.Color.Gray;
            this.pay_bt.DisabledForecolor = System.Drawing.Color.White;
            this.pay_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_bt.ForeColor = System.Drawing.Color.White;
            this.pay_bt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.pay_bt.IconPadding = 10;
            this.pay_bt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.pay_bt.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.pay_bt.IdleBorderRadius = 1;
            this.pay_bt.IdleBorderThickness = 0;
            this.pay_bt.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.pay_bt.IdleIconLeftImage = null;
            this.pay_bt.IdleIconRightImage = null;
            this.pay_bt.Location = new System.Drawing.Point(61, 331);
            this.pay_bt.Name = "pay_bt";
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties8.BorderRadius = 1;
            stateProperties8.BorderThickness = 1;
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties8.IconLeftImage = null;
            stateProperties8.IconRightImage = null;
            this.pay_bt.onHoverState = stateProperties8;
            this.pay_bt.Size = new System.Drawing.Size(105, 45);
            this.pay_bt.TabIndex = 16;
            this.pay_bt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pay_bt.Click += new System.EventHandler(this.pay_bt_Click);
            // 
            // totel_tx
            // 
            this.totel_tx.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.totel_tx.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totel_tx.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.totel_tx.BorderThickness = 3;
            this.totel_tx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.totel_tx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totel_tx.Enabled = false;
            this.totel_tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totel_tx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totel_tx.isPassword = false;
            this.totel_tx.Location = new System.Drawing.Point(199, 152);
            this.totel_tx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.totel_tx.MaxLength = 32767;
            this.totel_tx.Name = "totel_tx";
            this.totel_tx.Size = new System.Drawing.Size(115, 45);
            this.totel_tx.TabIndex = 19;
            this.totel_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = " مبلغ المطلوب";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "جزء المدفوع";
            // 
            // Form_you_pay_part
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 434);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totel_tx);
            this.Controls.Add(this.pay_tx);
            this.Controls.Add(this.bunifuButton2);
            this.Controls.Add(this.pay_bt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_you_pay_part";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_you_pay_part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton pay_bt;
        public Bunifu.Framework.UI.BunifuMetroTextbox pay_tx;
        public Bunifu.Framework.UI.BunifuMetroTextbox totel_tx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}