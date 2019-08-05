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
    public partial class FormSettings : Form
    {
        Key _key = null;
        Data _data = null;
        Key _protect = null;

        string mac = Mac.GetMac();
        string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

        public FormSettings()
        {
            _data = Data.GetData();
            _key = Key.GetKey();
            _protect = Key.GetProtect();
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            string protect = Crypt.Decrypt(_protect.protect, userName + mac, mac + userName, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            string key = Crypt.Decrypt(_key.data, userName, mac, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            try
            {
                if (protect == key)
                {
                    string key1 = Crypt.Decrypt(_key.data, userName, mac, "SHA1", 2,
                                    "32CRYPTODATA0117", 256);
                    if (TextBoxPass.Text == key1)
                    {
                        if (TextBoxNewPass1.Text != "")
                        {
                            if (TextBoxNewPass1.Text == TextBoxNewPass2.Text)
                            {
                                string data = Crypt.Decrypt(_data.data, key1, mac, "SHA1", 2,
                                                 "32CRYPTODATA0117", 256);
                                _key.data = Crypt.Encrypt(this.TextBoxNewPass1.Text, userName, mac, "SHA1", 2,
                                                             "32CRYPTODATA0117", 256);
                                _key.Save();
                                _data.data = Crypt.Encrypt(data, this.TextBoxNewPass1.Text, mac, "SHA1", 2,
                                                             "32CRYPTODATA0117", 256);
                                _data.Save();
                                MessageBox.Show("Your password is set. Write it down so you will not lose it. It will not be possible to restore it! Changes will be effective after the program is restarted", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Passwords do not match!", "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("You did not enter anything!", "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password!", "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void TextBoxPass_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            string protect = Crypt.Decrypt(_protect.protect, userName + mac, mac + userName, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            string key = Crypt.Decrypt(_key.data, userName, mac, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            try
            {
                if (protect == key)
                {
                    MessageBox.Show("Do not use only numbers, this can lead to errors in the program!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
