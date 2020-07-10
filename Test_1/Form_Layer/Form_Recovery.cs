using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Test_1.Form_Layer
{
    public partial class Form_Recovery : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public Form_Recovery()
        {
            InitializeComponent();
            string mode = Properties.Settings.Default.Mode;
            if (mode == "SQL")
            {
                con = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + "; Database = master; Integrated Security = false; User ID=" +
                                                    Properties.Settings.Default.ID + "; Password=" + Properties.Settings.Default.Password + "");
            }
            else
            {
                con = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + "; Database= master; Integrated Security=true");
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = OFD.FileName;
            }
            btnReco.Enabled = true;
        }

        private void btnReco_Click(object sender, EventArgs e)
        {
            try
            {
                string strQuery = "ALTER Database [MOA] SET OFFLINE WITH ROLLBACK IMMEDIATE; Restore Database [MOA] From Disk='" + txtFileName.Text + "'";
                cmd = new SqlCommand(strQuery, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم استعادة النسخة الاحتياطية بنجاح", "استعادة النسخة الاحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("فشل استعادة النسخة الاحتياطية ", "استعادة النسخة الاحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btbCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
