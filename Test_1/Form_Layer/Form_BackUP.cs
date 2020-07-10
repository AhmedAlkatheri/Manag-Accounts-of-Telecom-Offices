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
    public partial class Form_BackUP : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        
        public Form_BackUP()
        {
            InitializeComponent();
            string mode = Properties.Settings.Default.Mode;

            if (mode == "SQL")
            {
                con = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + "; Database=" +
                                                    Properties.Settings.Default.Database + "; Integrated Security=false; User ID=" +
                                                    Properties.Settings.Default.ID + "; Password=" + Properties.Settings.Default.Password + "");
            }
            else
            {
                con = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + "; Database=" + Properties.Settings.Default.Database + "; Integrated Security=true");
            }
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            try
            {
                string fileName = txtFileName.Text + "\\نظام سداد " + DateTime.Now.ToShortDateString().Replace('/', '-')
                            + " - " + DateTime.Now.ToLongTimeString().Replace(':', '-');

                string strQuery = "Backup Database [MOA] to Disk= '" + fileName + " .bak'";
                cmd = new SqlCommand(strQuery, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم إنشاء النسخة الاحتياطية بنجاح", "إنشاء النسخة الاحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show(" فشل عمليه إنشاء النسخة الاحتياطية احفظ النسخة الاحتياطية في قرص آخر ", "إنشاء النسخة الاحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            if (FBD.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = FBD.SelectedPath;
            }
            btnCreate.Enabled = true;


        }

        private void btbCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
