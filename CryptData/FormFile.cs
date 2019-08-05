using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace CryptData
{
    public partial class FormFile : Form
    {
        DESCryptoServiceProvider SecretKey;
        Key _key = null;
        Key _protect = null;

        string mac = Mac.GetMac();
        string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

        public FormFile()
        {
            SecretKey = CryptFile.GenerateKey();
            _key = Key.GetKey();
            _protect = Key.GetProtect();
            InitializeComponent();
        }

        public string GetFileFormat(string fileName)
        {
            return fileName.Substring(fileName.LastIndexOf(".") + 1);
        }

        private void FormFile_Load(object sender, EventArgs e)
        {

        }

        private void buttonViewDir1_Click(object sender, EventArgs e)
        {
            string protect = Crypt.Decrypt(_protect.protect, userName + mac, mac + userName, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            string key = Crypt.Decrypt(_key.data, userName, mac, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            try
            {
                if (protect == key)
                {
                    string fileName = "";
                    OpenFileDialog filedir = new OpenFileDialog();
                    if (filedir.ShowDialog() == DialogResult.OK)
                        fileName = filedir.FileName;

                    textBoxDir1.Text = fileName;
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

        private void buttonEncFile_Click(object sender, EventArgs e)
        {
            string protect = Crypt.Decrypt(_protect.protect, userName + mac, mac + userName, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            string key = Crypt.Decrypt(_key.data, userName, mac, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            try
            {
                if (protect == key)
                {
                    var file = GetFileFormat(textBoxDir1.Text);
                    var format = Crypt.Encrypt(file, key, mac, "SHA1", 2,
                                                         "32CRYPTODATA0117", 256);
                    GCHandle gch = GCHandle.Alloc(SecretKey.Key, GCHandleType.Pinned);
                    CryptFile.EncryptFile(textBoxDir1.Text, format + ".jakecd", SecretKey);
                    gch.Free();
                    MessageBox.Show("The file was encrypted!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (checkBoxDelete.Checked == true)
                        System.IO.File.Delete(textBoxDir1.Text);
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

        private void buttonViewDir2_Click(object sender, EventArgs e)
        {
            string protect = Crypt.Decrypt(_protect.protect, userName + mac, mac + userName, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            string key = Crypt.Decrypt(_key.data, userName, mac, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            try
            {
                if (protect == key)
                {
                    string fileName = "";
                    OpenFileDialog openFileDialog1 = new OpenFileDialog() { Filter = "Зашифрованый файл(*.jakecd)|*.jakecd" };
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        fileName = openFileDialog1.FileName;

                    textBoxDir2.Text = fileName;
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

        private void buttonDecFile_Click(object sender, EventArgs e)
        {
            string protect = Crypt.Decrypt(_protect.protect, userName + mac, mac + userName, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            string key = Crypt.Decrypt(_key.data, userName, mac, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            try
            {
                if (protect == key)
                {
                    string name = System.IO.Path.GetFileNameWithoutExtension(textBoxDir2.Text);
                    var format = Crypt.Decrypt(name, key, mac, "SHA1", 2,
                                                         "32CRYPTODATA0117", 256);
                    GCHandle gch = GCHandle.Alloc(SecretKey.Key, GCHandleType.Pinned);
                    CryptFile.DecryptFile(textBoxDir2.Text, "decrypted" + "." + format, SecretKey);
                    gch.Free();
                    MessageBox.Show("The file was decrypted!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("If after encrypting the file you change the password in the settings, the file will not be decrypted. To decrypt a previously encrypted file, you will have to put the old password!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void buttonEnc2_Click(object sender, EventArgs e)
        {
            string protect = Crypt.Decrypt(_protect.protect, userName + mac, mac + userName, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            string key = Crypt.Decrypt(_key.data, userName, mac, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            try
            {
                if (protect == key)
                {
                    if (this.maskedPassword1.Text != "")
                    {
                        var file = GetFileFormat(textBoxDir12.Text);
                        var format = Crypt.Encrypt(file, this.maskedPassword1.Text, "EncryptFile/zArCIyCzbJxWwDfkHVD3Acty62lT7in9L", "SHA1", 2,
                                                             "32CRYPTODATA0117", 256);
                        GCHandle gch = GCHandle.Alloc(SecretKey.Key, GCHandleType.Pinned);
                        CryptFile.EncryptFile(textBoxDir12.Text, format + ".jakecd", SecretKey);
                        gch.Free();
                        MessageBox.Show("The file was encrypted!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (checkBoxDel1.Checked == true)
                            System.IO.File.Delete(textBoxDir12.Text);
                    }
                    else
                    {
                        MessageBox.Show("You did not enter anything!", "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void buttonEncView2_Click(object sender, EventArgs e)
        {
            string protect = Crypt.Decrypt(_protect.protect, userName + mac, mac + userName, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            string key = Crypt.Decrypt(_key.data, userName, mac, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            try
            {
                if (protect == key)
                {
                    string fileName = "";
                    OpenFileDialog filedir = new OpenFileDialog();
                    if (filedir.ShowDialog() == DialogResult.OK)
                        fileName = filedir.FileName;

                    textBoxDir12.Text = fileName;
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

        private void buttonDec2_Click(object sender, EventArgs e)
        {
            string protect = Crypt.Decrypt(_protect.protect, userName + mac, mac + userName, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            string key = Crypt.Decrypt(_key.data, userName, mac, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            try
            {
                if (protect == key)
                {
                    if (this.maskedPassword2.Text != "")
                    {
                        try
                        {
                            string name = System.IO.Path.GetFileNameWithoutExtension(textBoxDir22.Text);
                            var format = Crypt.Decrypt(name, this.maskedPassword2.Text, "EncryptFile/zArCIyCzbJxWwDfkHVD3Acty62lT7in9L", "SHA1", 2,
                                                                 "32CRYPTODATA0117", 256);
                            GCHandle gch = GCHandle.Alloc(SecretKey.Key, GCHandleType.Pinned);
                            CryptFile.DecryptFile(textBoxDir22.Text, "decrypted" + "." + format, SecretKey);
                            gch.Free();
                            MessageBox.Show("The file was decrypted!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Incorrect password!", "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("You did not enter anything!", "Ooops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void buttonDecDir2_Click(object sender, EventArgs e)
        {
            string protect = Crypt.Decrypt(_protect.protect, userName + mac, mac + userName, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            string key = Crypt.Decrypt(_key.data, userName, mac, "SHA1", 2,
                                     "32CRYPTODATA0117", 256);
            try
            {
                if (protect == key)
                {
                    string fileName = "";
                    OpenFileDialog openFileDialog1 = new OpenFileDialog() { Filter = "Зашифрованый файл(*.jakecd)|*.jakecd" };
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        fileName = openFileDialog1.FileName;

                    textBoxDir22.Text = fileName;
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
