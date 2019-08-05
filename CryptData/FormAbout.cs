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
    public partial class FormAbout : Form
    {
        Key _key = null;
        Data _data = null;
        Key _protect = null;

        string mac = Mac.GetMac();
        string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

        public FormAbout()
        {
            _data = Data.GetData();
            _key = Key.GetKey();
            _protect = Key.GetProtect();
            InitializeComponent();
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

        private void FormAbout_Load(object sender, EventArgs e)
        {

        }
    }
}
