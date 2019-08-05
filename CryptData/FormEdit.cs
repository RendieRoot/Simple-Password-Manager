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
    public partial class FormEdit : Form
    {
        Data _data = null;
        Key _key = null;
        Key _protect = null;

        string mac = Mac.GetMac();
        string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

        public FormEdit()
        {
            InitializeComponent();

            _data = Data.GetData();
            _key = Key.GetKey();
            _protect = Key.GetProtect();
            _initControlls();
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
                    TextBoxEdit.Text = Crypt.Decrypt(_data.data, key, mac, "SHA1", 2,
                                                         "32CRYPTODATA0117", 256);
                }
                else
                {
                    TextBoxEdit.Text = "Protect";
                    MessageBox.Show("There was a problem with the protection system. Data can not be decrypted!", "Protect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
            }
            catch
            {
                TextBoxEdit.Text = "Protect";
                MessageBox.Show("There was a problem with the protection system. Data can not be decrypted!", "Protect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string protect = Crypt.Decrypt(_protect.protect, userName + mac, mac + userName, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            string key = Crypt.Decrypt(_key.data, userName, mac, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);

            try
            {
                if (protect == key)
                {
                    _data.data = Crypt.Encrypt(this.TextBoxEdit.Text, key, mac, "SHA1", 2,
                                                         "32CRYPTODATA0117", 256);
                    _data.Save();

                    FormHome home = new FormHome();
                    home.Show();
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

        private void FormEdit_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            string protect = Crypt.Decrypt(_protect.protect, userName + mac, mac + userName, "SHA1", 2,
                                         "32CRYPTODATA0117", 256);
                string key = Crypt.Decrypt(_key.data, userName, mac, "SHA1", 2,
                                         "32CRYPTODATA0117", 256);

                try
                {
                    if (protect == key)
                    {
                        FormHome home = new FormHome();
                        home.Show();
                        this.Hide();
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
