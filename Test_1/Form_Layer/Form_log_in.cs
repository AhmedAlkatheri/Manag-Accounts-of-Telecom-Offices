using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_1.Form_Layer
{
    public partial class Form_log_in : Form
    {
        Business_Layer.Login log = new Business_Layer.Login();
        public string statut;

        public Form_log_in()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            DataTable Dt = log.login(username_txt.Text, password_txt.Text);

            if (Dt.Rows.Count > 0)
            {

                if (Dt.Rows[0][5].ToString() == "مدير")
                {
                    Form_main.getMainForm.اعدادتToolStripMenuItem.Enabled = true;
                    Form_main.getMainForm.حساباتToolStripMenuItem.Enabled = true;
                    Form_main.getMainForm.عملاءToolStripMenuItem.Enabled = true;
                    Form_main.getMainForm.مستخدمينToolStripMenuItem.Enabled = true;
                    Form_main.getMainForm.اعدادتToolStripMenuItem.Enabled = true;
                    Form_main.getMainForm.حولToolStripMenuItem.Enabled = true;
                    Form_main.getMainForm.تسجيلالدخولToolStripMenuItem.Enabled = false;
                    Form_main.getMainForm.تسجيلخروجToolStripMenuItem.Enabled = true;
                    Form_main.getMainForm.مقبوضاتومصروفاتToolStripMenuItem.Enabled = true;
                    Form_main.getMainForm.ملخصToolStripMenuItem.Enabled = true;

                    Form_main.getMainForm.ClientBut.Enabled = true;
                    Form_main.getMainForm.AlternateBut.Enabled = true;
                    Form_main.getMainForm.SettingsBut.Enabled = true;
                    Form_main.getMainForm.AccountsBut.Enabled = true;
                    Form_main.getMainForm.AccountsAllBut.Enabled = true;
                    Form_main.getMainForm.Catch_ExchangeBut.Enabled = true;
                    Form_main.getMainForm.DepositABut.Enabled = true;
                    Form_main.getMainForm.DepositBBut.Enabled = true;
                    Form_main.getMainForm.CatchBut.Enabled = true;
                    Form_main.getMainForm.ExchangeBut.Enabled = true;
                    Form_main.getMainForm.dailyBut.Enabled = true;
                    Form_main.getMainForm.monthlyBut.Enabled = true;
                    Form_main.getMainForm.yearlyBut.Enabled = true;
                    Form_main.getMainForm.BackUPBut.Enabled = true;
                    Form_main.getMainForm.RecoveryBut.Enabled = true;


                    Program.id_user     = Convert.ToInt32( Dt.Rows[0]["ID_user"]); 
                    Program.userName    = Dt.Rows[0]["FullName"].ToString();

                    Form_main.getMainForm.Text = "نظام سداد" + " | " + Program.userName ;

                    this.Close();
                }

                else if (Dt.Rows[0][5].ToString() == "عادي")
                {
                    Form_main.getMainForm.اعدادتToolStripMenuItem.Enabled = true;
                    Form_main.getMainForm.حساباتToolStripMenuItem.Enabled = true;
                    Form_main.getMainForm.عملاءToolStripMenuItem.Enabled = true;
                    Form_main.getMainForm.مستخدمينToolStripMenuItem.Enabled = false;
                    Form_main.getMainForm.اعدادتToolStripMenuItem.Enabled = false;
                    Form_main.getMainForm.حولToolStripMenuItem.Enabled = true;
                    Form_main.getMainForm.تسجيلالدخولToolStripMenuItem.Enabled = false;
                    Form_main.getMainForm.تسجيلخروجToolStripMenuItem.Enabled = true;
                    Form_main.getMainForm.مقبوضاتومصروفاتToolStripMenuItem.Enabled = true;
                    Form_main.getMainForm.ملخصToolStripMenuItem.Enabled = false;

                    
                    Form_main.getMainForm.ClientBut.Enabled = true;
                    Form_main.getMainForm.AlternateBut.Enabled = false;
                    Form_main.getMainForm.SettingsBut.Enabled = false;
                    Form_main.getMainForm.AccountsBut.Enabled = true;
                    Form_main.getMainForm.AccountsAllBut.Enabled = true;
                    Form_main.getMainForm.Catch_ExchangeBut.Enabled = true;
                    Form_main.getMainForm.DepositABut.Enabled = true;
                    Form_main.getMainForm.DepositBBut.Enabled = true;
                    Form_main.getMainForm.CatchBut.Enabled = true;
                    Form_main.getMainForm.ExchangeBut.Enabled = true;
                    Form_main.getMainForm.dailyBut.Enabled = false;
                    Form_main.getMainForm.monthlyBut.Enabled = false;
                    Form_main.getMainForm.yearlyBut.Enabled = false;
                    Form_main.getMainForm.BackUPBut.Enabled = true;
                    Form_main.getMainForm.RecoveryBut.Enabled = true;

                    Program.id_user = Convert.ToInt32(Dt.Rows[0]["ID_user"]);
                    Program.userName = Dt.Rows[0]["FullName"].ToString();

                    Form_main.getMainForm.Text = "نظام سداد" + " | " + Program.userName;

                    this.Close();
                }

                Form_logged FL = new Form_logged();
                FL.ShowDialog();
            }
            else
            {
                Form_not_logged FNL = new Form_not_logged();
                FNL.ShowDialog();
            }
                
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (statut == "main")
                this.Close();
            else
                Application.Exit();

            statut = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_contact FC = new Form_contact();
            FC.ShowDialog();
        }
    }
}
