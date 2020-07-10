using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_1.Properties;

namespace Test_1.Form_Layer
{
    public partial class Form_main : Form
    {

        Form_Deposit FD = new Form_Deposit();
        Form_new_Client_Alternate FNC = new Form_new_Client_Alternate();
        Form_Add_Catch_Exchange Fc = new Form_Add_Catch_Exchange();
        Form_Settings s = new Form_Settings();
        Business_Layer.Accounts acc = new Business_Layer.Accounts();
        Business_Layer.Settings S = new Business_Layer.Settings();
        License_Layer.Form_License FLicense = new License_Layer.Form_License();

        //Single Instance
        private static Form_main frm;

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static Form_main getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Form_main();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

        public Form_main()
        {
            InitializeComponent();
            try
            {
                if (frm == null)
                    frm = this;

                this.اعدادتToolStripMenuItem.Enabled = false;
                this.حساباتToolStripMenuItem.Enabled = false;
                this.عملاءToolStripMenuItem.Enabled = false;
                this.مستخدمينToolStripMenuItem.Enabled = false;
                this.اعدادتToolStripMenuItem.Enabled = false;
                this.حولToolStripMenuItem.Enabled = true;
                this.تسجيلالدخولToolStripMenuItem.Enabled = true;
                this.تسجيلخروجToolStripMenuItem.Enabled = false;

                

                //License_Layer.Form_License FL = new License_Layer.Form_License();
                //FL.ShowDialog();

                //DG_NAME_REC_EXH.DataSource = acc.GET_NAME_REC_EXH();

                //DataGrid_System.DataSource = S.SHOW_system_Table();
                DataGrid_bunch.DataSource       = S.SHOW_bunch_Table();
                DataGrid_category.DataSource    = S.SHOW_category_Table();
                DataGrid_slice.DataSource       = S.SHOW_slice_Table();
                DataGrid_telephone.DataSource   = S.SHOW_telephone_Table();
                DataGrid_WendE.DataSource       = S.SHOW_water_And_Electricity_Table();

                DataGrid_bunch.Columns[1].Width         = 100;
                DataGrid_bunch.Columns[0].Visible       = false;
                DataGrid_category.Columns[0].Visible    = false;
                DataGrid_slice.Columns[0].Visible       = false;
                DataGrid_telephone.Columns[0].Visible   = false;
                DataGrid_WendE.Columns[0].Visible       = false;

            }
            catch 
            {
                Form_contact FC = new Form_contact();
                FC.Error_txt.Visible = true;
                FC.Error_pic.Visible = true;
                FC.ShowDialog();
                FC.Error_txt.Visible = false;
                FC.Error_pic.Visible = false;
            }
        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_log_in Flog = new Form_log_in();
            Flog.statut = "main";
            Flog.ShowDialog();
        }

        private void يوميةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Accounts FA = new Form_Accounts();
            FA.Show();
        }

        private void شهريةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Accounts_All FAM = new Form_Accounts_All();
            FAM.Show();
        }

        private void باقاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s.user_category1.BringToFront();
            s.Show();
        }

        private void انشاءمناوبجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FNC.stats1          = "Alternate";
            FNC.AddEdit         = "Add";
            FNC.name.Text       = "مناوب جديد";
            FNC.label1.Text     = "اسم المناوب";
            FNC.label2.Text     = "اسم المستخدم";
            FNC.label3.Text     = "كلمة المرور";
            FNC.label4.Text     = "تأكيد كلمة المرور";
            FNC.label5.Text     = "جوال";

            FNC.label9.Visible          = true;
            FNC.tyap_com.Visible        = true;
            FNC.ADRESS_tx.isPassword    = true;
            FNC.TELEPHONE_tx.isPassword = true;
            FNC.panel1.Visible          = false;
            FNC.ShowDialog();

            FNC.acc_tx.Text         = "";
            FNC.MOBILE_tx.Text      = "";
            FNC.TELEPHONE_tx.Text   = "";
            FNC.ADRESS_tx.Text      = "";
            FNC.EMAIL_tx.Text       = "";
            FNC.for_tx.Text         = "";
            FNC.on_tx.Text          = "";
            FNC.tyap_com.Text       = "";
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
           
        }

        private void صرفToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void اضافةعميلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FNC.stats1          = "Client";
            FNC.name.Text       = "حساب جديد";
            FNC.AddEdit         = "Add";
            FNC.label1.Text     = "اسم الحساب";
            FNC.label2.Text     = "الايميل";
            FNC.label3.Text     = "عنوان";
            FNC.label4.Text     = "هاتف";
            FNC.label5.Text     = "جوال";

            FNC.label9.Visible          = false;
            FNC.tyap_com.Visible        = false;
            FNC.ADRESS_tx.isPassword    = false;
            FNC.TELEPHONE_tx.isPassword = false;
            FNC.panel1.Visible          = true;
            FNC.ShowDialog();

            FNC.acc_tx.Text         = "";
            FNC.MOBILE_tx.Text      = "";
            FNC.TELEPHONE_tx.Text   = "";
            FNC.ADRESS_tx.Text      = "";
            FNC.EMAIL_tx.Text       = "";
            FNC.for_tx.Text         = "";
            FNC.on_tx.Text          = "";
        }

        private void مستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ادارةالمناوبينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Alternate FAe = new Form_Alternate();
            FAe.Show();
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

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void تسجيلخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.اعدادتToolStripMenuItem.Enabled            = false;
            this.حساباتToolStripMenuItem.Enabled            = false;
            this.عملاءToolStripMenuItem.Enabled               = false;
            this.مستخدمينToolStripMenuItem.Enabled          = false;
            this.اعدادتToolStripMenuItem.Enabled            = false;
            this.حولToolStripMenuItem.Enabled               = true;
            this.تسجيلالدخولToolStripMenuItem.Enabled       = true;
            this.تسجيلخروجToolStripMenuItem.Enabled         = false;
            this.مقبوضاتومصروفاتToolStripMenuItem.Enabled  = false;
            this.ملخصToolStripMenuItem.Enabled              = false;

            ClientBut.Enabled           = false;
            AlternateBut.Enabled        = false;
            SettingsBut.Enabled         = false;
            AccountsBut.Enabled         = false;
            AccountsAllBut.Enabled      = false;
            Catch_ExchangeBut.Enabled   = false;
            DepositABut.Enabled         = false;
            DepositBBut.Enabled         = false;
            CatchBut.Enabled            = false;
            ExchangeBut.Enabled         = false;
            dailyBut.Enabled            = false;
            monthlyBut.Enabled          = false;
            yearlyBut.Enabled           = false;
            BackUPBut.Enabled           = false;
            RecoveryBut.Enabled         = false;

            Program.id_user = 0;
            Program.userName = "";
            Text = "نظام سداد";
        }

        private void اعداداتاتصالبالسيرفرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_contact FC = new Form_contact();
            FC.ShowDialog();
        }

        private void انشاءنسخةاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_BackUP FB = new Form_BackUP();
            FB.ShowDialog();
        }

        private void استعادةنسخةاحتطياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Recovery FR = new Form_Recovery();
            FR.ShowDialog();
        }

        private void مقبوضاتومصروفاتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Catch_Exchange FCE = new Form_Catch_Exchange();
            FCE.Show();
        }

        private void قبضToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Fc.status = "Add";
            Fc.move = "قبض";
            Fc.name.Text = "قبض";
            Fc.label4.Visible = false;
            Fc.move_cob.Visible = false;
            Fc.ShowDialog();
        }

        private void صرفToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Fc.status = "Add";
            Fc.move = "صرف";
            Fc.name.Text = "صرف";

            Fc.label4.Visible = false;
            Fc.move_cob.Visible = false;
            Fc.ShowDialog();
        }

        private void Form_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            Form_log_in log = new Form_log_in();
            log.ShowDialog();
        }

        private void bunifuTileButton8_Click(object sender, EventArgs e)
        {
            Form_Accounts FA = new Form_Accounts();
            FA.Show();
        }

        private void bunifuTileButton7_Click(object sender, EventArgs e)
        {
            Form_Accounts_All FAM = new Form_Accounts_All();
            FAM.Show();
        }

        private void bunifuTileButton12_Click(object sender, EventArgs e)
        {
            FD.stats1 = "for";
            FD.name.Text = "ايداع";
            FD.ShowDialog();
        }

        private void bunifuTileButton13_Click(object sender, EventArgs e)
        {
            FD.stats1 = "on";
            FD.name.Text = "سحب من الايداع";
            FD.ShowDialog();
        }

        private void bunifuTileButton16_Click(object sender, EventArgs e)
        {
            Form_BackUP FB = new Form_BackUP();
            FB.ShowDialog();
        }

        private void bunifuTileButton15_Click(object sender, EventArgs e)
        {
            Form_Recovery FR = new Form_Recovery();
            FR.ShowDialog();
        }

        private void bunifuTileButton11_Click(object sender, EventArgs e)
        {
            Form_Catch_Exchange FCE = new Form_Catch_Exchange();
            FCE.Show();
        }

        private void bunifuTileButton14_Click(object sender, EventArgs e)
        {
            Fc.status = "Add";
            Fc.move = "قبض";
            Fc.name.Text = "قبض";
            Fc.label4.Visible = false;
            Fc.move_cob.Visible = false;
            Fc.ShowDialog();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            Fc.status = "Add";
            Fc.move = "صرف";
            Fc.name.Text = "صرف";

            Fc.label4.Visible = false;
            Fc.move_cob.Visible = false;
            Fc.ShowDialog();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Form_Client FC = new Form_Client();
            FC.Show();
        }

        private void bunifuTileButton9_Click(object sender, EventArgs e)
        {
            Form_Alternate FAe = new Form_Alternate();
            FAe.Show();
        }

        private void bunifuTileButton10_Click(object sender, EventArgs e)
        {
            s.user_system1.BringToFront();
            s.Show();
        }

        public void License()
        {

            //if (Settings.Default.Trial.Add(new TimeSpan(32, 0, 0, 0)) > DateTime.Now &&
            //    DateTime.Now <= DateTime.Parse(Business_Layer.Encryptioncs.Decrypt(FLicense.RK.GetValue("count").ToString())))
            //{

                //Settings.Default.isTrial = true;
                //FLicense.timer1.Enabled = true;
                //Settings.Default.Save();
            //}
            //else if (DateTime.Now >= DateTime.Parse(Business_Layer.Encryptioncs.Decrypt(FLicense.RK.GetValue("count").ToString())))
            //{
                //if (Settings.Default.isLicensed == Convert.ToBoolean(Business_Layer.Encryptioncs.Decrypt(("101 * 117 % 114 % 116 *").ToString())))
                //{
                    //FLicense.SettingsCala();
                    //if (FLicense.TResult == Convert.ToDouble(Business_Layer.Encryptioncs.Decrypt(Settings.Default.KT.ToString())))
                    //{
                        
                    //}
                    //else
                    //{
                    //    Application.Exit();
                    //}
                //}
                //else
                //{
                //    MessageBox.Show("انتهى فترة تجريبية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    Application.Exit();
                //}
            //}
            //else
            //{
            //    MessageBox.Show("انتهى فترة تجريبية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    Application.Exit();
            //}
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void حولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_About Fabout = new Form_About();
            Fabout.ShowDialog();
        }

        private void ملخصToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void ملخصيوميToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Abstract f = new Form_Abstract();
            f.Date_statut   = "daily";
            f.Date1.Visible = true;
            f.Date2.Visible = true;
            f.Text          = "ملخص يومي";
            f.Show();
        }

        private void ملخصشهريToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Abstract f         = new Form_Abstract();
            f.Date_statut           = "monthly";
            f.Drop1_Month.Visible   = true;
            f.Drop2_Month.Visible   = true;
            f.Drop_Year.Visible     = true;
            f.label1.Visible        = true;
            f.Text                  = "ملخص شهري";
            f.Show();
        }

        private void ملخصسنويToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Abstract f         = new Form_Abstract();
            f.Date_statut           = "yearly";
            f.Drop1_Year.Visible    = true;
            f.Drop2_Year.Visible    = true;
            f.Text                  = "ملخص سنوي";
            f.Show();
        }

        private void dailyBut_Click(object sender, EventArgs e)
        {
            Form_Abstract f = new Form_Abstract();
            f.Date_statut = "daily";
            f.Date1.Visible = true;
            f.Date2.Visible = true;
            f.Text = "ملخص يومي";
            f.Show();
        }

        private void monthlyBut_Click(object sender, EventArgs e)
        {
            Form_Abstract f = new Form_Abstract();
            f.Date_statut = "monthly";
            f.Drop1_Month.Visible = true;
            f.Drop2_Month.Visible = true;
            f.Drop_Year.Visible = true;
            f.label1.Visible = true;
            f.Text = "ملخص شهري";
            f.Show();
        }

        private void yearlyBut_Click(object sender, EventArgs e)
        {
            Form_Abstract f = new Form_Abstract();
            f.Date_statut = "yearly";
            f.Drop1_Year.Visible = true;
            f.Drop2_Year.Visible = true;
            f.Text = "ملخص سنوي";
            f.Show();
        }

        private void DataGrid_category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
