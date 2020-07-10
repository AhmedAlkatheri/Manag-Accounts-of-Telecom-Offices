using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Test_1.Properties;
using System.IO;
using System.Management;

namespace Test_1.License_Layer
{
    public partial class Form_License : Form
    {
        public double Result, TResult;
        DateTime CalTime, TrialTime;
        //string CalTime, TrialTime;
        public RegistryKey RK = Registry.CurrentUser.OpenSubKey("Software\\NextTech", true);
        public TextBox td = new TextBox();
        public Form_License()
        {
            InitializeComponent();
            //Settings.Default.Reset();

            TrialTime = DateTime.Now;
            CalTime = DateTime.Now.AddDays(32);

            if (!Settings.Default.isChecked)
            {
                getUnlqueID("c");
                td.Text = getUnlqueID("c");

                Settings.Default.GI = td.Text;
                Settings.Default.Save();

                RegistryKey RK = Registry.CurrentUser.CreateSubKey("Software\\NextTech");
                RK = Registry.CurrentUser.OpenSubKey("Software\\NextTech", true);

                Settings.Default.CalDate = CalTime;
                RK.SetValue("count", Business_Layer.Encryptioncs.Encrypt(Settings.Default.CalDate.ToString()));

                Settings.Default.Trial = TrialTime;
                Settings.Default.isChecked = true;
                timer1.Enabled = true;
                Settings.Default.Save();
            }
            else
            {
                getUnlqueID("c");
                td.Text = getUnlqueID("c");

                if (Settings.Default.Trial.Add(new TimeSpan(32, 0, 0, 0)) > DateTime.Now &&
                    DateTime.Now <= DateTime.Parse(Business_Layer.Encryptioncs.Decrypt(RK.GetValue("count").ToString())))
                {
                    if (td.Text != Settings.Default.GI)
                    {
                        Application.Exit();
                    }
                    Settings.Default.isTrial = true;
                    timer1.Enabled = true;
                    Settings.Default.Save();
                }
                else if (DateTime.Now >= DateTime.Parse(Business_Layer.Encryptioncs.Decrypt(RK.GetValue("count").ToString())))
                {
                    if (Settings.Default.isLicensed == Convert.ToBoolean(Business_Layer.Encryptioncs.Decrypt(("101 * 117 % 114 % 116 *").ToString())))
                    {
                        SettingsCala();
                        if (TResult == Convert.ToDouble(Business_Layer.Encryptioncs.Decrypt(Settings.Default.KT.ToString())))
                        {
                            if (td.Text != Settings.Default.GI)
                            {
                                Application.Exit();
                            }
                        }
                        else
                        {
                            Application.Exit();
                        }
                    }
                    else
                    {
                        //MessageBox.Show("انتهى فترة تجريبية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        timer1.Enabled = false;
                        label3.Visible = false;
                        labelDays.Visible = false;
                        BtnTrial.Enabled = false;
                        labelText.ForeColor = Color.Red;
                        labelText.Text = "انتهى فترة تجريبية";
                    }
                }
                else
                {
                    //MessageBox.Show("تهى الفترة تجريبية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    timer1.Enabled = false;
                    label3.Visible = false;
                    labelDays.Visible = false;
                    BtnTrial.Enabled = false;
                    labelText.ForeColor = Color.Red;
                    labelText.Text = "انتهى فترة تجريبية";
                }
            }
        }

        private string getVolumeSerial(string drive)
        {
            ManagementObject disk = new ManagementObject(@"win32_logicaldisk.deviceid=""" + drive + @":""");
            disk.Get();

            string volumeSerial = disk["VolumeSerialNumber"].ToString();
            disk.Dispose();

            return volumeSerial;
        }

        private void BtnTrial_Click(object sender, EventArgs e)
        {
            getUnlqueID("c");
            td.Text = getUnlqueID("c");

            if (Settings.Default.Trial.Add(new TimeSpan(32, 0, 0, 0)) > DateTime.Now)
            {
                if (td.Text != Settings.Default.GI)
                {
                    Application.Exit();
                }
                Settings.Default.isTrial = true;
                Settings.Default.Save();

                Form_Layer.Form_main main = new Form_Layer.Form_main();
                this.Hide();
                main.ShowDialog();
            }
            else
            {
                timer1.Enabled = false;
                Application.Exit();
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtSerial1.Text == string.Empty || txtSerial2.Text == string.Empty ||
                txtSerial3.Text == string.Empty || txtSerial4.Text == string.Empty)
            {
                MessageBox.Show("عذرا اكتب السيريل اولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Cala();
                if (Result == Convert.ToDouble(Business_Layer.Encryptioncs.Decrypt(Settings.Default.KT.ToString())))
                {
                    getUnlqueID("c");
                    td.Text = getUnlqueID("c");

                    Settings.Default.GI = td.Text;
                    Settings.Default.Save();

                    if (td.Text != Settings.Default.GI)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        Settings.Default.m1 = txtSerial1.Text;
                        Settings.Default.m2 = txtSerial2.Text;
                        Settings.Default.m3 = txtSerial3.Text;
                        Settings.Default.m4 = txtSerial4.Text;

                        MessageBox.Show("تم تفعيل البرنامج بنجاح", "البرنامج", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Settings.Default.isLicensed = true;
                        Settings.Default.Save();

                        timer1.Enabled = false;

                        Form_Layer.Form_main main = new Form_Layer.Form_main();
                        this.Hide();
                        main.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("رقم السيريل المدخل غير صحيح", "البرنامج", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("رقم السيريل المدخل غير صحيح", "البرنامج", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cala()
        {
            if (txtSerial1.Text != string.Empty && txtSerial2.Text != string.Empty &&
                txtSerial3.Text != string.Empty && txtSerial4.Text != string.Empty)
            {
                double S1 = Convert.ToDouble(txtSerial1.Text);
                double S2 = Convert.ToDouble(txtSerial2.Text);
                double S3 = Convert.ToDouble(txtSerial3.Text);
                double S4 = Convert.ToDouble(txtSerial4.Text);
                Result = (S1 + S2) - (S3 + S4);
            }
        }

        private void Calas()
        {
            if (txtSerial1.Text != string.Empty && txtSerial2.Text != string.Empty &&
                txtSerial3.Text != string.Empty && txtSerial4.Text != string.Empty)
            {
                double S1 = Convert.ToDouble(txtSerial1.Text);
                double S2 = Convert.ToDouble(txtSerial2.Text);
                double S3 = Convert.ToDouble(txtSerial3.Text);
                double S4 = Convert.ToDouble(txtSerial4.Text);
                Result = (S1 * S2) - (S3 * S4);
            }
        }
        public void SettingsCala()
        {
            if (Settings.Default.m1 != string.Empty && Settings.Default.m2 != string.Empty &&
                Settings.Default.m3 != string.Empty && Settings.Default.m4 != string.Empty)
            {
                double S1 = Convert.ToDouble(Settings.Default.m1);
                double S2 = Convert.ToDouble(Settings.Default.m2);
                double S3 = Convert.ToDouble(Settings.Default.m3);
                double S4 = Convert.ToDouble(Settings.Default.m4);
                TResult = (S1 + S2) - (S3 + S4);
            }
        }

        private void txtSerial1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSerial2.Focus();
            }
        }

        private void txtSerial2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSerial3.Focus();
            }
        }

        private void txtSerial3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSerial4.Focus();
            }
        }

        private void txtSerial4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin.Focus();
            }
        }

        private void txtSerial4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (RK != null)
            {
                DateTime TotalTime = DateTime.Parse(Business_Layer.Encryptioncs.Decrypt(RK.GetValue("count").ToString()));
                TimeSpan CountDown = TotalTime - DateTime.Now;

                if (CountDown.TotalSeconds <= 0)
                {
                    timer1.Enabled = false;
                    label3.Visible = false;
                    labelDays.Visible = false;
                    BtnTrial.Enabled = false;
                    labelText.ForeColor = Color.Red;
                    labelText.Text = "انتهى الفترة التجريبية";
                }
                else
                {
                    labelDays.Text = CountDown.Days.ToString();
                }
            }
        }

        private void Form_License_Load(object sender, EventArgs e)
        {
            getUnlqueID("c");
            td.Text = getUnlqueID("c");
            if (Settings.Default.isLicensed == Convert.ToBoolean(Business_Layer.Encryptioncs.Decrypt(("101 * 117 % 114 % 116 *").ToString())))
            {
                SettingsCala();
                if (TResult == Convert.ToDouble(Business_Layer.Encryptioncs.Decrypt(Settings.Default.KT.ToString())))
                {
                    if (td.Text != Settings.Default.GI)
                    {
                        Application.Exit();
                    }

                    timer1.Enabled = false;

                    Form_Layer.Form_main main = new Form_Layer.Form_main();
                    this.Hide();
                    main.ShowDialog();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void Form_License_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSerial1.Text == string.Empty || txtSerial2.Text == string.Empty ||
                txtSerial3.Text == string.Empty || txtSerial4.Text == string.Empty)
            {
                MessageBox.Show("عذرا اكتب السيريل اولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Calas();
                if (Result == Convert.ToDouble(Business_Layer.Encryptioncs.Decrypt(Settings.Default.ST.ToString())))
                {
                    getUnlqueID("c");
                    td.Text = getUnlqueID("c");

                    if (td.Text != Settings.Default.GI)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        Settings.Default.s1 = txtSerial1.Text;
                        Settings.Default.s2 = txtSerial2.Text;
                        Settings.Default.s3 = txtSerial3.Text;
                        Settings.Default.s4 = txtSerial4.Text;

                        //////////////////////
                        TrialTime = DateTime.Now;
                        CalTime = DateTime.Now.AddDays(32);

                        getUnlqueID("c");
                        td.Text = getUnlqueID("c");

                        Settings.Default.GI = td.Text;
                        Settings.Default.Save();

                        RegistryKey RK = Registry.CurrentUser.CreateSubKey("Software\\NextTech");
                        RK = Registry.CurrentUser.OpenSubKey("Software\\NextTech", true);

                        Settings.Default.CalDate = CalTime;
                        RK.SetValue("count", Business_Layer.Encryptioncs.Encrypt(Settings.Default.CalDate.ToString()));

                        Settings.Default.Trial = TrialTime;
                        Settings.Default.isChecked = true;
                        timer1.Enabled = true;
                        Settings.Default.Save();
                        MessageBox.Show("تم تجديد فترة التجريبية", "تجديد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DateTime TotalTime = DateTime.Parse(Business_Layer.Encryptioncs.Decrypt(RK.GetValue("count").ToString()));
                        TimeSpan CountDown = TotalTime - DateTime.Now;
                        labelDays.Text = CountDown.Days.ToString();
                        ///////////////////////
                    }
                }
                else
                {
                    MessageBox.Show("رقم السيريل المدخل غير صحيح", "البرنامج", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("رقم السيريل المدخل غير صحيح", "البرنامج", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string getCPUID()
        {
            string cpuInfo = "";
            ManagementClass managClass = new ManagementClass("win32_processor");
            ManagementObjectCollection managCollec = managClass.GetInstances();

            foreach (ManagementObject managObj in managCollec)
            {
                if (cpuInfo == "")
                {
                    cpuInfo = managObj.Properties["processorID"].Value.ToString();
                    break;
                }
            }
            return cpuInfo;
        }

        private string getUnlqueID(string drive)
        {
            if (drive == string.Empty)
            {
                foreach (DriveInfo compDrive in DriveInfo.GetDrives())
                {
                    if (compDrive.IsReady)
                    {
                        drive = compDrive.RootDirectory.ToString();
                        break;
                    }
                }
            }
            if (drive.EndsWith(":\\"))
            {
                drive = drive.Substring(0, drive.Length - 2);
            }
            string volumeSerial = getVolumeSerial(drive);
            string CpuID = getCPUID();

            return CpuID.Substring(13) + CpuID.Substring(1, 4) + volumeSerial + CpuID.Substring(4, 4);
        }
    }
}
