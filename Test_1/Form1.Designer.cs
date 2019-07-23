namespace Test_1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.m1 = new System.Windows.Forms.ToolStripMenuItem();
            this.m2 = new System.Windows.Forms.ToolStripMenuItem();
            this.m3 = new System.Windows.Forms.ToolStripMenuItem();
            this.m4 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.تسجيلدخولToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m1,
            this.m2,
            this.m3,
            this.m4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(940, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // m1
            // 
            this.m1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تسجيلدخولToolStripMenuItem});
            this.m1.Name = "m1";
            this.m1.Size = new System.Drawing.Size(72, 20);
            this.m1.Text = "مستخدمين";
            this.m1.Click += new System.EventHandler(this.m1_Click);
            // 
            // m2
            // 
            this.m2.Name = "m2";
            this.m2.Size = new System.Drawing.Size(57, 20);
            this.m2.Text = "حسابات";
            // 
            // m3
            // 
            this.m3.Name = "m3";
            this.m3.Size = new System.Drawing.Size(45, 20);
            this.m3.Text = "عملاء";
            this.m3.Click += new System.EventHandler(this.m3_Click);
            // 
            // m4
            // 
            this.m4.Name = "m4";
            this.m4.Size = new System.Drawing.Size(55, 20);
            this.m4.Text = "اعدادت";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // تسجيلدخولToolStripMenuItem
            // 
            this.تسجيلدخولToolStripMenuItem.Name = "تسجيلدخولToolStripMenuItem";
            this.تسجيلدخولToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.تسجيلدخولToolStripMenuItem.Text = "تسجيل دخول";
            this.تسجيلدخولToolStripMenuItem.Click += new System.EventHandler(this.تسجيلدخولToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 491);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem m1;
        private System.Windows.Forms.ToolStripMenuItem m2;
        private System.Windows.Forms.ToolStripMenuItem m3;
        private System.Windows.Forms.ToolStripMenuItem m4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem تسجيلدخولToolStripMenuItem;
    }
}

