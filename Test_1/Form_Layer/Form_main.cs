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
    public partial class Form_main : Form
    {
        Form_Deposit FD = new Form_Deposit();
        Form_new_Client_Alternate FNC = new Form_new_Client_Alternate();
        Form_Catch_Exchange Fc = new Form_Catch_Exchange();
        Form_Settings s = new Form_Settings();
        Business_Layer.Accounts acc = new Business_Layer.Accounts();
        public Form_main()
        {
            InitializeComponent();

            //DG_NAME_REC_EXH.DataSource = acc.GET_NAME_REC_EXH();
        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_log_in Flog = new Form_log_in();
            Flog.ShowDialog();
        }

        private void يوميةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Accounts FA = new Form_Accounts();
            FA.Show();
        }

        private void شهريةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Accounts_Manth FAM = new Form_Accounts_Manth();
            FAM.Show();
        }

        private void باقاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s.user_category1.BringToFront();
            s.Show();
        }

        private void انشاءمناوبجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FNC.stats1 = "Alternate";
            FNC.name.Text = "مستخدم جديد";
            FNC.label1.Text = "اسم المناوب";
            FNC.label2.Text = "اسم المستخدم";
            FNC.label3.Text = "كلمة المرور";
            FNC.label4.Text = "تأكيد كلمة المرور";
            FNC.label5.Text = "جوال";
            FNC.ADRESS_tx.isPassword = true;
            FNC.TELEPHONE_tx.isPassword = true;
            FNC.panel1.Visible = false;
            FNC.ShowDialog();

            FNC.acc_tx.Text = "";
            FNC.MOBILE_tx.Text = "";
            FNC.TELEPHONE_tx.Text = "";
            FNC.ADRESS_tx.Text = "";
            FNC.EMAIL_tx.Text = "";
            FNC.for_tx.Text = "";
            FNC.on_tx.Text = "";



        }

        private void ادارةالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Client FC = new Form_Client();
            FC.Show();
        }

        private void صرفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FD.stats1 = "on";
            FD.name.Text = "سحب من الايداع";
            FD.ShowDialog();

        }

        private void ايداعToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FD.stats1 = "for";
            FD.name.Text = "ايداع";
            FD.ShowDialog();
        }

        private void قبضToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fc.move = "قبض";
            Fc.name.Text = "قبض";
            Fc.ShowDialog();
        }

        private void صرفToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Fc.move = "صرف";
            Fc.name.Text = "صرف";
            Fc.ShowDialog();
        }

        private void اضافةعميلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FNC.stats1 = "Client";
            FNC.name.Text = "حساب جديد";
            FNC.label1.Text = "اسم الحساب";
            FNC.label2.Text = "الايميل";
            FNC.label3.Text = "عنوان";
            FNC.label4.Text = "هاتف";
            FNC.label5.Text = "جوال";
            FNC.ADRESS_tx.isPassword = false;
            FNC.TELEPHONE_tx.isPassword = false;
            FNC.panel1.Visible = true;
            FNC.ShowDialog();

            FNC.acc_tx.Text = "";
            FNC.MOBILE_tx.Text = "";
            FNC.TELEPHONE_tx.Text = "";
            FNC.ADRESS_tx.Text = "";
            FNC.EMAIL_tx.Text = "";
            FNC.for_tx.Text = "";
            FNC.on_tx.Text = "";
            

        }

        private void مستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ادارةالمناوبينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Alternate FA = new Form_Alternate();
            FA.Show();
        }

        private void النظامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s.user_system1.BringToFront();
            s.Show();
        }

        private void اتصالاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s.user_Telecom1.BringToFront();
            s.Show();
        }

        private void باقاتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            s.user_bunch1.BringToFront();
            s.Show();
        }

        private void شرايحToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s.user_slice1.BringToFront();
            s.Show();
        }

        private void اعداداتالايداعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s.user_deposit_settings1.BringToFront();
            s.Show();
        }

        private void هاتفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s.user_telephone1.BringToFront();
            s.Show();
        }

        private void ماءوكهرباءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s.user_WendE1.BringToFront();
            s.Show();
        }
    }
}
