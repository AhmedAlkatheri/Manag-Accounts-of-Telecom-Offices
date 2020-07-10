namespace Test_1.License_Layer
{
    partial class Form_License
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_License));
            this.txtSerial1 = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            this.labelDays = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnTrial = new System.Windows.Forms.Button();
            this.txtSerial3 = new System.Windows.Forms.TextBox();
            this.txtSerial4 = new System.Windows.Forms.TextBox();
            this.txtSerial2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSerial1
            // 
            this.txtSerial1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial1.Location = new System.Drawing.Point(60, 96);
            this.txtSerial1.MaxLength = 4;
            this.txtSerial1.Multiline = true;
            this.txtSerial1.Name = "txtSerial1";
            this.txtSerial1.Size = new System.Drawing.Size(68, 31);
            this.txtSerial1.TabIndex = 10;
            this.txtSerial1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSerial1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerial1_KeyDown);
            this.txtSerial1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerial4_KeyPress);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(246, 145);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 35);
            this.BtnLogin.TabIndex = 15;
            this.BtnLogin.Text = "تسجيل";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.Location = new System.Drawing.Point(182, 59);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(174, 16);
            this.labelText.TabIndex = 17;
            this.labelText.Text = "الفترة التجريبية المسموحة لك ";
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDays.Location = new System.Drawing.Point(161, 57);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(24, 18);
            this.labelDays.TabIndex = 18;
            this.labelDays.Text = "32";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "يوم";
            // 
            // BtnTrial
            // 
            this.BtnTrial.Location = new System.Drawing.Point(164, 145);
            this.BtnTrial.Name = "BtnTrial";
            this.BtnTrial.Size = new System.Drawing.Size(75, 35);
            this.BtnTrial.TabIndex = 16;
            this.BtnTrial.Text = "تجريبي";
            this.BtnTrial.UseVisualStyleBackColor = true;
            this.BtnTrial.Click += new System.EventHandler(this.BtnTrial_Click);
            // 
            // txtSerial3
            // 
            this.txtSerial3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial3.Location = new System.Drawing.Point(208, 96);
            this.txtSerial3.MaxLength = 4;
            this.txtSerial3.Multiline = true;
            this.txtSerial3.Name = "txtSerial3";
            this.txtSerial3.Size = new System.Drawing.Size(68, 31);
            this.txtSerial3.TabIndex = 12;
            this.txtSerial3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSerial3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerial3_KeyDown);
            this.txtSerial3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerial4_KeyPress);
            // 
            // txtSerial4
            // 
            this.txtSerial4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial4.Location = new System.Drawing.Point(282, 96);
            this.txtSerial4.MaxLength = 4;
            this.txtSerial4.Multiline = true;
            this.txtSerial4.Name = "txtSerial4";
            this.txtSerial4.Size = new System.Drawing.Size(68, 31);
            this.txtSerial4.TabIndex = 11;
            this.txtSerial4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSerial4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerial4_KeyDown);
            this.txtSerial4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerial4_KeyPress);
            // 
            // txtSerial2
            // 
            this.txtSerial2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial2.Location = new System.Drawing.Point(134, 96);
            this.txtSerial2.MaxLength = 4;
            this.txtSerial2.Multiline = true;
            this.txtSerial2.Name = "txtSerial2";
            this.txtSerial2.Size = new System.Drawing.Size(68, 31);
            this.txtSerial2.TabIndex = 13;
            this.txtSerial2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSerial2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSerial2_KeyDown);
            this.txtSerial2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerial4_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "السيريل";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "تجديد";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 237);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSerial1);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelDays);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnTrial);
            this.Controls.Add(this.txtSerial3);
            this.Controls.Add(this.txtSerial4);
            this.Controls.Add(this.txtSerial2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_License";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تفعيل ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_License_FormClosed);
            this.Load += new System.EventHandler(this.Form_License_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSerial1;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox txtSerial3;
        private System.Windows.Forms.TextBox txtSerial4;
        private System.Windows.Forms.TextBox txtSerial2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label labelText;
        public System.Windows.Forms.Label labelDays;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button BtnTrial;
    }
}