using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CryptData
{
    public partial class FormHome : Form
    {
        Data _data = null;
        Key _key = null;
        Key _protect = null;

        string mac = Mac.GetMac();
        string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

        public FormHome()
        {
            InitializeComponent();

            _data = Data.GetData();
            _key = Key.GetKey();
            _protect = Key.GetProtect();
            _initControlls();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string protect = Crypt.Decrypt(_protect.protect, userName + mac, mac + userName, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            string key = Crypt.Decrypt(_key.data, userName, mac, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            try
            {
                if (protect == key)
                {
                    FormEdit edit = new FormEdit();
                    edit.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("There was a problem with the protection system. Data can not be decrypted!", "Protect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
            }
            catch
            {
                MessageBox.Show("There was a problem with the protection system. Data can not be decrypted!", "Protect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }

        private void _initControlls()
        {
            string protect = Crypt.Decrypt(_protect.protect, userName + mac, mac + userName, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            string key = Crypt.Decrypt(_key.data, userName, mac, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            try
            {
                if (protect == key)
                {
                    TextBoxData.Text = Crypt.Decrypt(_data.data, key, mac, "SHA1", 2,
                                                         "32CRYPTODATA0117", 256);
                }
                else
                {
                    TextBoxData.Text = "Protect";
                    MessageBox.Show("There was a problem with the protection system. Data can not be decrypted!", "Protect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
            }
            catch
            {
                TextBoxData.Text = "Protect";
                MessageBox.Show("There was a problem with the protection system. Data can not be decrypted!", "Protect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }

        private void buttonAboutUs_Click(object sender, EventArgs e)
        {
            string protect = Crypt.Decrypt(_protect.protect, userName + mac, mac + userName, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            string key = Crypt.Decrypt(_key.data, userName, mac, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            try
            {
                if (protect == key)
                {
                    FormAbout about = new FormAbout();
                    about.ShowDialog();
                }
                else
                {
                    MessageBox.Show("There was a problem with the protection system. Data can not be decrypted!", "Protect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
            }
            catch
            {
                MessageBox.Show("There was a problem with the protection system. Data can not be decrypted!", "Protect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            string protect = Crypt.Decrypt(_protect.protect, userName + mac, mac + userName, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            string key = Crypt.Decrypt(_key.data, userName, mac, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            try
            {
                if (protect == key)
                {
                    FormSettings settings = new FormSettings();
                    settings.ShowDialog();
                }
                else
                {
                    MessageBox.Show("There was a problem with the protection system. Data can not be decrypted!", "Protect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
            }
            catch
            {
                MessageBox.Show("There was a problem with the protection system. Data can not be decrypted!", "Protect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string protect = Crypt.Decrypt(_protect.protect, userName + mac, mac + userName, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            string key = Crypt.Decrypt(_key.data, userName, mac, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            try
            {
                if (protect == key)
                {
                    FormFile file = new FormFile();
                    file.ShowDialog();
                }
                else
                {
                    MessageBox.Show("There was a problem with the protection system. Data can not be decrypted!", "Protect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
            }
            catch
            {
                MessageBox.Show("There was a problem with the protection system. Data can not be decrypted!", "Protect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }
    }
}
