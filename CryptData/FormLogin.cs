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
    public partial class FormLogin : Form
    {
        Key _key = null;
        Key _protect = null;

        string mac = Mac.GetMac();
        string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

        public FormLogin()
        {
            InitializeComponent();

            _key = Key.GetKey();
            _protect = Key.GetProtect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string key = Crypt.Decrypt(_key.data, userName, mac, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            if (TextBoxPass.Text != "")
            {
                if (TextBoxPass.Text == key)
                {
                    _protect.protect = Crypt.Encrypt(this.TextBoxPass.Text, userName + mac, mac + userName, "SHA1", 2,
                                             "32CRYPTODATA0117", 256);
                    _protect.Save();
                    FormHome home = new FormHome();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect password!", "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You did not enter anything!", "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
