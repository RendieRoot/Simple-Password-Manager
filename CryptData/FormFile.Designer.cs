namespace CryptData
{
    partial class FormFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFile));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.checkBoxDelete = new System.Windows.Forms.CheckBox();
            this.buttonEncFile = new System.Windows.Forms.Button();
            this.buttonViewDir1 = new System.Windows.Forms.Button();
            this.textBoxDir1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDecFile = new System.Windows.Forms.Button();
            this.buttonViewDir2 = new System.Windows.Forms.Button();
            this.textBoxDir2 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.maskedPassword1 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxDel1 = new System.Windows.Forms.CheckBox();
            this.buttonEnc2 = new System.Windows.Forms.Button();
            this.buttonEncView2 = new System.Windows.Forms.Button();
            this.textBoxDir12 = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.maskedPassword2 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDec2 = new System.Windows.Forms.Button();
            this.buttonDecDir2 = new System.Windows.Forms.Button();
            this.textBoxDir22 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(10, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(280, 173);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.buttonHelp);
            this.tabPage1.Controls.Add(this.checkBoxDelete);
            this.tabPage1.Controls.Add(this.buttonEncFile);
            this.tabPage1.Controls.Add(this.buttonViewDir1);
            this.tabPage1.Controls.Add(this.textBoxDir1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(272, 147);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encrypt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "The path to the file:";
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(234, 114);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(27, 23);
            this.buttonHelp.TabIndex = 7;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // checkBoxDelete
            // 
            this.checkBoxDelete.AutoSize = true;
            this.checkBoxDelete.Checked = true;
            this.checkBoxDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDelete.Location = new System.Drawing.Point(8, 91);
            this.checkBoxDelete.Name = "checkBoxDelete";
            this.checkBoxDelete.Size = new System.Drawing.Size(130, 17);
            this.checkBoxDelete.TabIndex = 6;
            this.checkBoxDelete.Text = "Delete the original file.";
            this.checkBoxDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEncFile
            // 
            this.buttonEncFile.Location = new System.Drawing.Point(8, 114);
            this.buttonEncFile.Name = "buttonEncFile";
            this.buttonEncFile.Size = new System.Drawing.Size(222, 23);
            this.buttonEncFile.TabIndex = 5;
            this.buttonEncFile.Text = "Encrypt File";
            this.buttonEncFile.UseVisualStyleBackColor = true;
            this.buttonEncFile.Click += new System.EventHandler(this.buttonEncFile_Click);
            // 
            // buttonViewDir1
            // 
            this.buttonViewDir1.Location = new System.Drawing.Point(188, 21);
            this.buttonViewDir1.Name = "buttonViewDir1";
            this.buttonViewDir1.Size = new System.Drawing.Size(75, 23);
            this.buttonViewDir1.TabIndex = 1;
            this.buttonViewDir1.Text = "View";
            this.buttonViewDir1.UseVisualStyleBackColor = true;
            this.buttonViewDir1.Click += new System.EventHandler(this.buttonViewDir1_Click);
            // 
            // textBoxDir1
            // 
            this.textBoxDir1.Location = new System.Drawing.Point(8, 24);
            this.textBoxDir1.Name = "textBoxDir1";
            this.textBoxDir1.Size = new System.Drawing.Size(176, 20);
            this.textBoxDir1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.buttonDecFile);
            this.tabPage2.Controls.Add(this.buttonViewDir2);
            this.tabPage2.Controls.Add(this.textBoxDir2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(272, 147);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decrypt";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "The path to the file:";
            // 
            // buttonDecFile
            // 
            this.buttonDecFile.Location = new System.Drawing.Point(8, 107);
            this.buttonDecFile.Name = "buttonDecFile";
            this.buttonDecFile.Size = new System.Drawing.Size(257, 23);
            this.buttonDecFile.TabIndex = 4;
            this.buttonDecFile.Text = "Decrypt File";
            this.buttonDecFile.UseVisualStyleBackColor = true;
            this.buttonDecFile.Click += new System.EventHandler(this.buttonDecFile_Click);
            // 
            // buttonViewDir2
            // 
            this.buttonViewDir2.Location = new System.Drawing.Point(188, 21);
            this.buttonViewDir2.Name = "buttonViewDir2";
            this.buttonViewDir2.Size = new System.Drawing.Size(75, 23);
            this.buttonViewDir2.TabIndex = 3;
            this.buttonViewDir2.Text = "View";
            this.buttonViewDir2.UseVisualStyleBackColor = true;
            this.buttonViewDir2.Click += new System.EventHandler(this.buttonViewDir2_Click);
            // 
            // textBoxDir2
            // 
            this.textBoxDir2.Location = new System.Drawing.Point(8, 24);
            this.textBoxDir2.Name = "textBoxDir2";
            this.textBoxDir2.Size = new System.Drawing.Size(176, 20);
            this.textBoxDir2.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(3, 9);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(306, 235);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.tabControl1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(298, 209);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Method 1";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "This way file can be decrypted only on your computer.";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.tabControl3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(298, 209);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Method 2";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "This way the file can be transferred to friends.";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage5);
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Location = new System.Drawing.Point(10, 30);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(280, 172);
            this.tabControl3.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.maskedPassword1);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.checkBoxDel1);
            this.tabPage5.Controls.Add(this.buttonEnc2);
            this.tabPage5.Controls.Add(this.buttonEncView2);
            this.tabPage5.Controls.Add(this.textBoxDir12);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(272, 146);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Encrypt";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // maskedPassword1
            // 
            this.maskedPassword1.Location = new System.Drawing.Point(8, 65);
            this.maskedPassword1.Name = "maskedPassword1";
            this.maskedPassword1.PasswordChar = '#';
            this.maskedPassword1.Size = new System.Drawing.Size(252, 20);
            this.maskedPassword1.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Password for decrypting the file:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "The path to the file:";
            // 
            // checkBoxDel1
            // 
            this.checkBoxDel1.AutoSize = true;
            this.checkBoxDel1.Checked = true;
            this.checkBoxDel1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDel1.Location = new System.Drawing.Point(8, 91);
            this.checkBoxDel1.Name = "checkBoxDel1";
            this.checkBoxDel1.Size = new System.Drawing.Size(130, 17);
            this.checkBoxDel1.TabIndex = 6;
            this.checkBoxDel1.Text = "Delete the original file.";
            this.checkBoxDel1.UseVisualStyleBackColor = true;
            // 
            // buttonEnc2
            // 
            this.buttonEnc2.Location = new System.Drawing.Point(8, 114);
            this.buttonEnc2.Name = "buttonEnc2";
            this.buttonEnc2.Size = new System.Drawing.Size(257, 23);
            this.buttonEnc2.TabIndex = 5;
            this.buttonEnc2.Text = "Encrypt File";
            this.buttonEnc2.UseVisualStyleBackColor = true;
            this.buttonEnc2.Click += new System.EventHandler(this.buttonEnc2_Click);
            // 
            // buttonEncView2
            // 
            this.buttonEncView2.Location = new System.Drawing.Point(188, 21);
            this.buttonEncView2.Name = "buttonEncView2";
            this.buttonEncView2.Size = new System.Drawing.Size(75, 23);
            this.buttonEncView2.TabIndex = 1;
            this.buttonEncView2.Text = "View";
            this.buttonEncView2.UseVisualStyleBackColor = true;
            this.buttonEncView2.Click += new System.EventHandler(this.buttonEncView2_Click);
            // 
            // textBoxDir12
            // 
            this.textBoxDir12.Location = new System.Drawing.Point(8, 24);
            this.textBoxDir12.Name = "textBoxDir12";
            this.textBoxDir12.Size = new System.Drawing.Size(176, 20);
            this.textBoxDir12.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.maskedPassword2);
            this.tabPage6.Controls.Add(this.label7);
            this.tabPage6.Controls.Add(this.label6);
            this.tabPage6.Controls.Add(this.buttonDec2);
            this.tabPage6.Controls.Add(this.buttonDecDir2);
            this.tabPage6.Controls.Add(this.textBoxDir22);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(272, 146);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Decrypt";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // maskedPassword2
            // 
            this.maskedPassword2.Location = new System.Drawing.Point(8, 65);
            this.maskedPassword2.Name = "maskedPassword2";
            this.maskedPassword2.PasswordChar = '#';
            this.maskedPassword2.Size = new System.Drawing.Size(252, 20);
            this.maskedPassword2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Password for decrypting the file:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "The path to the file:";
            // 
            // buttonDec2
            // 
            this.buttonDec2.Location = new System.Drawing.Point(8, 114);
            this.buttonDec2.Name = "buttonDec2";
            this.buttonDec2.Size = new System.Drawing.Size(257, 23);
            this.buttonDec2.TabIndex = 4;
            this.buttonDec2.Text = "Decrypt File";
            this.buttonDec2.UseVisualStyleBackColor = true;
            this.buttonDec2.Click += new System.EventHandler(this.buttonDec2_Click);
            // 
            // buttonDecDir2
            // 
            this.buttonDecDir2.Location = new System.Drawing.Point(188, 21);
            this.buttonDecDir2.Name = "buttonDecDir2";
            this.buttonDecDir2.Size = new System.Drawing.Size(75, 23);
            this.buttonDecDir2.TabIndex = 3;
            this.buttonDecDir2.Text = "View";
            this.buttonDecDir2.UseVisualStyleBackColor = true;
            this.buttonDecDir2.Click += new System.EventHandler(this.buttonDecDir2_Click);
            // 
            // textBoxDir22
            // 
            this.textBoxDir22.Location = new System.Drawing.Point(8, 24);
            this.textBoxDir22.Name = "textBoxDir22";
            this.textBoxDir22.Size = new System.Drawing.Size(176, 20);
            this.textBoxDir22.TabIndex = 2;
            // 
            // FormFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(311, 246);
            this.Controls.Add(this.tabControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CryptData";
            this.Load += new System.EventHandler(this.FormFile_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabControl3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonViewDir1;
        private System.Windows.Forms.TextBox textBoxDir1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonViewDir2;
        private System.Windows.Forms.TextBox textBoxDir2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonEncFile;
        private System.Windows.Forms.Button buttonDecFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox checkBoxDelete;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.MaskedTextBox maskedPassword1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxDel1;
        private System.Windows.Forms.Button buttonEnc2;
        private System.Windows.Forms.Button buttonEncView2;
        private System.Windows.Forms.TextBox textBoxDir12;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.MaskedTextBox maskedPassword2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonDec2;
        private System.Windows.Forms.Button buttonDecDir2;
        private System.Windows.Forms.TextBox textBoxDir22;
    }
}