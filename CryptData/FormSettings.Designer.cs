namespace CryptData
{
    partial class FormSettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxNewPass1 = new System.Windows.Forms.MaskedTextBox();
            this.buttonSet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxNewPass2 = new System.Windows.Forms.MaskedTextBox();
            this.TextBoxPass = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonHelp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TextBoxNewPass1);
            this.groupBox1.Controls.Add(this.buttonSet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TextBoxNewPass2);
            this.groupBox1.Controls.Add(this.TextBoxPass);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 203);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set new password";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(267, 170);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(27, 23);
            this.buttonHelp.TabIndex = 7;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "New password:";
            // 
            // TextBoxNewPass1
            // 
            this.TextBoxNewPass1.Location = new System.Drawing.Point(6, 144);
            this.TextBoxNewPass1.Name = "TextBoxNewPass1";
            this.TextBoxNewPass1.PasswordChar = '#';
            this.TextBoxNewPass1.Size = new System.Drawing.Size(288, 20);
            this.TextBoxNewPass1.TabIndex = 5;
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(6, 170);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(255, 23);
            this.buttonSet.TabIndex = 4;
            this.buttonSet.Text = "Set password";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Confirm the new password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your password:";
            // 
            // TextBoxNewPass2
            // 
            this.TextBoxNewPass2.Location = new System.Drawing.Point(6, 93);
            this.TextBoxNewPass2.Name = "TextBoxNewPass2";
            this.TextBoxNewPass2.PasswordChar = '#';
            this.TextBoxNewPass2.Size = new System.Drawing.Size(288, 20);
            this.TextBoxNewPass2.TabIndex = 1;
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Location = new System.Drawing.Point(6, 42);
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.PasswordChar = '#';
            this.TextBoxPass.Size = new System.Drawing.Size(288, 20);
            this.TextBoxPass.TabIndex = 0;
            this.TextBoxPass.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TextBoxPass_MaskInputRejected);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(324, 227);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox TextBoxNewPass1;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TextBoxNewPass2;
        private System.Windows.Forms.MaskedTextBox TextBoxPass;
        private System.Windows.Forms.Button buttonHelp;
    }
}