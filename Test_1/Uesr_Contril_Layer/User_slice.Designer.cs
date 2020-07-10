namespace Test_1.Uesr_Contril_Layer
{
    partial class User_slice
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_slice));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Search_tx = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.updata_bt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.alter_bt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.delete_bt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.insert_bt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.DataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_tx
            // 
            this.Search_tx.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.Search_tx.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Search_tx.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.Search_tx.BorderThickness = 3;
            this.Search_tx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Search_tx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Search_tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_tx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Search_tx.isPassword = false;
            this.Search_tx.Location = new System.Drawing.Point(38, 137);
            this.Search_tx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Search_tx.MaxLength = 32767;
            this.Search_tx.Name = "Search_tx";
            this.Search_tx.Size = new System.Drawing.Size(125, 44);
            this.Search_tx.TabIndex = 129;
            this.Search_tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Search_tx.OnValueChanged += new System.EventHandler(this.Search_tx_OnValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 128;
            this.label3.Text = "بحث ";
            // 
            // updata_bt
            // 
            this.updata_bt.BackColor = System.Drawing.Color.Transparent;
            this.updata_bt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updata_bt.BackgroundImage")));
            this.updata_bt.ButtonText = "تحديث";
            this.updata_bt.ButtonTextMarginLeft = 0;
            this.updata_bt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.updata_bt.DisabledFillColor = System.Drawing.Color.Gray;
            this.updata_bt.DisabledForecolor = System.Drawing.Color.White;
            this.updata_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updata_bt.ForeColor = System.Drawing.Color.White;
            this.updata_bt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.updata_bt.IconPadding = 10;
            this.updata_bt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.updata_bt.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.updata_bt.IdleBorderRadius = 1;
            this.updata_bt.IdleBorderThickness = 0;
            this.updata_bt.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.updata_bt.IdleIconLeftImage = null;
            this.updata_bt.IdleIconRightImage = null;
            this.updata_bt.Location = new System.Drawing.Point(49, 544);
            this.updata_bt.Name = "updata_bt";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.updata_bt.onHoverState = stateProperties1;
            this.updata_bt.Size = new System.Drawing.Size(87, 36);
            this.updata_bt.TabIndex = 127;
            this.updata_bt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updata_bt.Click += new System.EventHandler(this.updata_bt_Click);
            // 
            // alter_bt
            // 
            this.alter_bt.BackColor = System.Drawing.Color.Transparent;
            this.alter_bt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("alter_bt.BackgroundImage")));
            this.alter_bt.ButtonText = "تعديل";
            this.alter_bt.ButtonTextMarginLeft = 0;
            this.alter_bt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.alter_bt.DisabledFillColor = System.Drawing.Color.Gray;
            this.alter_bt.DisabledForecolor = System.Drawing.Color.White;
            this.alter_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alter_bt.ForeColor = System.Drawing.Color.White;
            this.alter_bt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.alter_bt.IconPadding = 10;
            this.alter_bt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.alter_bt.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.alter_bt.IdleBorderRadius = 1;
            this.alter_bt.IdleBorderThickness = 0;
            this.alter_bt.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.alter_bt.IdleIconLeftImage = null;
            this.alter_bt.IdleIconRightImage = null;
            this.alter_bt.Location = new System.Drawing.Point(49, 502);
            this.alter_bt.Name = "alter_bt";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.alter_bt.onHoverState = stateProperties2;
            this.alter_bt.Size = new System.Drawing.Size(87, 36);
            this.alter_bt.TabIndex = 126;
            this.alter_bt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.alter_bt.Click += new System.EventHandler(this.alter_bt_Click);
            // 
            // delete_bt
            // 
            this.delete_bt.BackColor = System.Drawing.Color.Transparent;
            this.delete_bt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete_bt.BackgroundImage")));
            this.delete_bt.ButtonText = "حذف";
            this.delete_bt.ButtonTextMarginLeft = 0;
            this.delete_bt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.delete_bt.DisabledFillColor = System.Drawing.Color.Gray;
            this.delete_bt.DisabledForecolor = System.Drawing.Color.White;
            this.delete_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_bt.ForeColor = System.Drawing.Color.White;
            this.delete_bt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.delete_bt.IconPadding = 10;
            this.delete_bt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.delete_bt.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.delete_bt.IdleBorderRadius = 1;
            this.delete_bt.IdleBorderThickness = 0;
            this.delete_bt.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.delete_bt.IdleIconLeftImage = null;
            this.delete_bt.IdleIconRightImage = null;
            this.delete_bt.Location = new System.Drawing.Point(49, 460);
            this.delete_bt.Name = "delete_bt";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.BorderRadius = 1;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.delete_bt.onHoverState = stateProperties3;
            this.delete_bt.Size = new System.Drawing.Size(87, 36);
            this.delete_bt.TabIndex = 125;
            this.delete_bt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delete_bt.Click += new System.EventHandler(this.delete_bt_Click);
            // 
            // insert_bt
            // 
            this.insert_bt.BackColor = System.Drawing.Color.Transparent;
            this.insert_bt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("insert_bt.BackgroundImage")));
            this.insert_bt.ButtonText = "اضافة";
            this.insert_bt.ButtonTextMarginLeft = 0;
            this.insert_bt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.insert_bt.DisabledFillColor = System.Drawing.Color.Gray;
            this.insert_bt.DisabledForecolor = System.Drawing.Color.White;
            this.insert_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_bt.ForeColor = System.Drawing.Color.White;
            this.insert_bt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.insert_bt.IconPadding = 10;
            this.insert_bt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.insert_bt.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.insert_bt.IdleBorderRadius = 1;
            this.insert_bt.IdleBorderThickness = 0;
            this.insert_bt.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.insert_bt.IdleIconLeftImage = null;
            this.insert_bt.IdleIconRightImage = null;
            this.insert_bt.Location = new System.Drawing.Point(49, 418);
            this.insert_bt.Name = "insert_bt";
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 1;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.insert_bt.onHoverState = stateProperties4;
            this.insert_bt.Size = new System.Drawing.Size(87, 36);
            this.insert_bt.TabIndex = 124;
            this.insert_bt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.insert_bt.Click += new System.EventHandler(this.insert_bt_Click);
            // 
            // DataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid1.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid1.DoubleBuffered = true;
            this.DataGrid1.EnableHeadersVisualStyles = false;
            this.DataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.DataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.DataGrid1.Location = new System.Drawing.Point(200, 112);
            this.DataGrid1.Name = "DataGrid1";
            this.DataGrid1.ReadOnly = true;
            this.DataGrid1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGrid1.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGrid1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGrid1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.DataGrid1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGrid1.RowTemplate.Height = 40;
            this.DataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid1.Size = new System.Drawing.Size(534, 468);
            this.DataGrid1.TabIndex = 123;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.name.Location = new System.Drawing.Point(657, 26);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(59, 29);
            this.name.TabIndex = 122;
            this.name.Text = "شرائح";
            // 
            // User_slice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Search_tx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updata_bt);
            this.Controls.Add(this.alter_bt);
            this.Controls.Add(this.delete_bt);
            this.Controls.Add(this.insert_bt);
            this.Controls.Add(this.DataGrid1);
            this.Controls.Add(this.name);
            this.Name = "User_slice";
            this.Size = new System.Drawing.Size(778, 603);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox Search_tx;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton updata_bt;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton alter_bt;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton delete_bt;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton insert_bt;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid1;
        public System.Windows.Forms.Label name;
    }
}
