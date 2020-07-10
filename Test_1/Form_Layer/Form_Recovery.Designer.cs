namespace Test_1.Form_Layer
{
    partial class Form_Recovery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Recovery));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.btbCansel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnReco = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtFileName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btbCansel
            // 
            this.btbCansel.BackColor = System.Drawing.Color.Transparent;
            this.btbCansel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btbCansel.BackgroundImage")));
            this.btbCansel.ButtonText = "اغلاق";
            this.btbCansel.ButtonTextMarginLeft = 0;
            this.btbCansel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btbCansel.DisabledFillColor = System.Drawing.Color.Gray;
            this.btbCansel.DisabledForecolor = System.Drawing.Color.White;
            this.btbCansel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbCansel.ForeColor = System.Drawing.Color.White;
            this.btbCansel.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btbCansel.IconPadding = 10;
            this.btbCansel.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btbCansel.IdleBorderColor = System.Drawing.Color.DarkGray;
            this.btbCansel.IdleBorderRadius = 1;
            this.btbCansel.IdleBorderThickness = 0;
            this.btbCansel.IdleFillColor = System.Drawing.Color.DarkGray;
            this.btbCansel.IdleIconLeftImage = null;
            this.btbCansel.IdleIconRightImage = null;
            this.btbCansel.Location = new System.Drawing.Point(252, 227);
            this.btbCansel.Name = "btbCansel";
            stateProperties5.BorderColor = System.Drawing.Color.Gray;
            stateProperties5.BorderRadius = 1;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.Gray;
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.btbCansel.onHoverState = stateProperties5;
            this.btbCansel.Size = new System.Drawing.Size(85, 45);
            this.btbCansel.TabIndex = 67;
            this.btbCansel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btbCansel.Click += new System.EventHandler(this.btbCansel_Click);
            // 
            // btnReco
            // 
            this.btnReco.BackColor = System.Drawing.Color.Transparent;
            this.btnReco.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReco.BackgroundImage")));
            this.btnReco.ButtonText = "استراجاع";
            this.btnReco.ButtonTextMarginLeft = 0;
            this.btnReco.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnReco.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnReco.DisabledForecolor = System.Drawing.Color.White;
            this.btnReco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReco.ForeColor = System.Drawing.Color.White;
            this.btnReco.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnReco.IconPadding = 10;
            this.btnReco.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnReco.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnReco.IdleBorderRadius = 1;
            this.btnReco.IdleBorderThickness = 0;
            this.btnReco.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnReco.IdleIconLeftImage = null;
            this.btnReco.IdleIconRightImage = null;
            this.btnReco.Location = new System.Drawing.Point(88, 227);
            this.btnReco.Name = "btnReco";
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.BorderRadius = 1;
            stateProperties6.BorderThickness = 1;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.btnReco.onHoverState = stateProperties6;
            this.btnReco.Size = new System.Drawing.Size(88, 45);
            this.btnReco.TabIndex = 66;
            this.btnReco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReco.Click += new System.EventHandler(this.btnReco_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.txtFileName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFileName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.txtFileName.BorderThickness = 3;
            this.txtFileName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFileName.isPassword = false;
            this.txtFileName.Location = new System.Drawing.Point(51, 140);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFileName.MaxLength = 32767;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(249, 44);
            this.txtFileName.TabIndex = 65;
            this.txtFileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 20);
            this.label6.TabIndex = 64;
            this.label6.Text = " حدد مسار حفط النسخة الاحتياطية";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.name.Location = new System.Drawing.Point(50, 21);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(190, 29);
            this.name.TabIndex = 63;
            this.name.Text = "استرجاع نسخة احتياطية";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(322, 140);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(48, 44);
            this.btnBrowse.TabIndex = 62;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            // 
            // Form_Recovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 320);
            this.Controls.Add(this.btbCansel);
            this.Controls.Add(this.btnReco);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.name);
            this.Controls.Add(this.btnBrowse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Recovery";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Recovery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btbCansel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnReco;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFileName;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label name;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog OFD;
    }
}