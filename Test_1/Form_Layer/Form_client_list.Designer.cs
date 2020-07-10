namespace Test_1.Form_Layer
{
    partial class Form_client_list
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_client_list));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.DG_list = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.but_close = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.but_ok = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.DG_list)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_list
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_list.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DG_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_list.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DG_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_list.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_list.DefaultCellStyle = dataGridViewCellStyle3;
            this.DG_list.DoubleBuffered = true;
            this.DG_list.EnableHeadersVisualStyles = false;
            this.DG_list.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.DG_list.HeaderForeColor = System.Drawing.Color.White;
            this.DG_list.Location = new System.Drawing.Point(58, 81);
            this.DG_list.Name = "DG_list";
            this.DG_list.ReadOnly = true;
            this.DG_list.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DG_list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_list.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_list.RowHeadersVisible = false;
            this.DG_list.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DG_list.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.DG_list.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DG_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_list.Size = new System.Drawing.Size(303, 282);
            this.DG_list.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.label1.Location = new System.Drawing.Point(49, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 90;
            this.label1.Text = "اختيار حساب";
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
            this.but_close.Location = new System.Drawing.Point(243, 391);
            this.but_close.Name = "but_close";
            stateProperties1.BorderColor = System.Drawing.Color.Gray;
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.Gray;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.but_close.onHoverState = stateProperties1;
            this.but_close.Size = new System.Drawing.Size(118, 45);
            this.but_close.TabIndex = 89;
            this.but_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.but_close.Click += new System.EventHandler(this.but_close_Click);
            // 
            // but_ok
            // 
            this.but_ok.BackColor = System.Drawing.Color.Transparent;
            this.but_ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_ok.BackgroundImage")));
            this.but_ok.ButtonText = "اختيار";
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
            this.but_ok.Location = new System.Drawing.Point(58, 391);
            this.but_ok.Name = "but_ok";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.but_ok.onHoverState = stateProperties2;
            this.but_ok.Size = new System.Drawing.Size(126, 45);
            this.but_ok.TabIndex = 88;
            this.but_ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.but_ok.Click += new System.EventHandler(this.but_ok_Click);
            // 
            // Form_client_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 486);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_close);
            this.Controls.Add(this.but_ok);
            this.Controls.Add(this.DG_list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_client_list";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_client_list";
            this.Load += new System.EventHandler(this.Form_client_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton but_close;
        public Bunifu.Framework.UI.BunifuCustomDataGrid DG_list;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton but_ok;
    }
}