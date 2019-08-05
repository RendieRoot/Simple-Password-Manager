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
    public partial class FormSet : Form
    {
        Key _key = null;

        string mac = Mac.GetMac();
        string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

        public FormSet()
        {
            InitializeComponent();

            _key = Key.GetKey();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FormSet_Load(object sender, EventArgs e)
        {

        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            if (TextBoxSet1.Text != "")
            {
                if (TextBoxSet1.Text == TextBoxSet2.Text)
                {
                    _key.data = Crypt.Encrypt(this.TextBoxSet1.Text, userName, mac, "SHA1", 2,
                                                     "32CRYPTODATA0117", 256);
                    _key.Save();

                    MessageBox.Show("Your password is set. Write it down so you will not lose it. It will not be possible to restore it!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormLogin login = new FormLogin();
                    login.Show();
                    this.Hide();
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

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do not use only numbers, this can lead to errors in the program!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
