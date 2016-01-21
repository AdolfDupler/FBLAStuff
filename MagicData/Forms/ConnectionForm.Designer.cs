namespace MagicData.Forms
{
    partial class ConnectionForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.UsernmTxtbx = new System.Windows.Forms.TextBox();
            this.PasswordTxtbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DatabasecmBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.DbLabel = new System.Windows.Forms.Label();
            this.UseConbttn = new System.Windows.Forms.Button();
            this.Createbttn = new System.Windows.Forms.Button();
            this.Createchckbox = new System.Windows.Forms.CheckBox();
            this.Createtxtbx = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.Action_Deactivate);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 51);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Use SQL Server Login";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // UsernmTxtbx
            // 
            this.UsernmTxtbx.Enabled = false;
            this.UsernmTxtbx.Location = new System.Drawing.Point(115, 74);
            this.UsernmTxtbx.Name = "UsernmTxtbx";
            this.UsernmTxtbx.Size = new System.Drawing.Size(100, 20);
            this.UsernmTxtbx.TabIndex = 2;
            this.UsernmTxtbx.TextChanged += new System.EventHandler(this.Action_Deactivate);
            // 
            // PasswordTxtbox
            // 
            this.PasswordTxtbox.Enabled = false;
            this.PasswordTxtbox.Location = new System.Drawing.Point(115, 100);
            this.PasswordTxtbox.Name = "PasswordTxtbox";
            this.PasswordTxtbox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTxtbox.TabIndex = 3;
            this.PasswordTxtbox.TextChanged += new System.EventHandler(this.Action_Deactivate);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DatabasecmBox
            // 
            this.DatabasecmBox.FormattingEnabled = true;
            this.DatabasecmBox.Location = new System.Drawing.Point(18, 227);
            this.DatabasecmBox.Name = "DatabasecmBox";
            this.DatabasecmBox.Size = new System.Drawing.Size(110, 21);
            this.DatabasecmBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data Source/Server Name:";
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Enabled = false;
            this.UsernameLbl.Location = new System.Drawing.Point(54, 77);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(58, 13);
            this.UsernameLbl.TabIndex = 7;
            this.UsernameLbl.Text = "Username:";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Enabled = false;
            this.PasswordLbl.Location = new System.Drawing.Point(56, 100);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(56, 13);
            this.PasswordLbl.TabIndex = 8;
            this.PasswordLbl.Text = "Password:";
            // 
            // DbLabel
            // 
            this.DbLabel.AutoSize = true;
            this.DbLabel.Location = new System.Drawing.Point(15, 211);
            this.DbLabel.Name = "DbLabel";
            this.DbLabel.Size = new System.Drawing.Size(56, 13);
            this.DbLabel.TabIndex = 9;
            this.DbLabel.Text = "Database:";
            // 
            // UseConbttn
            // 
            this.UseConbttn.Location = new System.Drawing.Point(158, 227);
            this.UseConbttn.Name = "UseConbttn";
            this.UseConbttn.Size = new System.Drawing.Size(115, 23);
            this.UseConbttn.TabIndex = 10;
            this.UseConbttn.Text = "Use Connection";
            this.UseConbttn.UseVisualStyleBackColor = true;
            this.UseConbttn.Click += new System.EventHandler(this.UseConbttn_Click);
            // 
            // Createbttn
            // 
            this.Createbttn.Enabled = false;
            this.Createbttn.Location = new System.Drawing.Point(158, 181);
            this.Createbttn.Name = "Createbttn";
            this.Createbttn.Size = new System.Drawing.Size(115, 23);
            this.Createbttn.TabIndex = 12;
            this.Createbttn.Text = "Create New";
            this.Createbttn.UseVisualStyleBackColor = true;
            this.Createbttn.Click += new System.EventHandler(this.Createbttn_Click);
            // 
            // Createchckbox
            // 
            this.Createchckbox.AutoSize = true;
            this.Createchckbox.Location = new System.Drawing.Point(18, 158);
            this.Createchckbox.Name = "Createchckbox";
            this.Createchckbox.Size = new System.Drawing.Size(131, 17);
            this.Createchckbox.TabIndex = 13;
            this.Createchckbox.Text = "Create New Database";
            this.Createchckbox.UseVisualStyleBackColor = true;
            this.Createchckbox.CheckedChanged += new System.EventHandler(this.Createchckbox_CheckedChanged);
            // 
            // Createtxtbx
            // 
            this.Createtxtbx.Enabled = false;
            this.Createtxtbx.Location = new System.Drawing.Point(18, 181);
            this.Createtxtbx.Mask = "?????????????????";
            this.Createtxtbx.Name = "Createtxtbx";
            this.Createtxtbx.Size = new System.Drawing.Size(110, 20);
            this.Createtxtbx.TabIndex = 14;
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Createtxtbx);
            this.Controls.Add(this.Createchckbox);
            this.Controls.Add(this.Createbttn);
            this.Controls.Add(this.UseConbttn);
            this.Controls.Add(this.DbLabel);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatabasecmBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PasswordTxtbox);
            this.Controls.Add(this.UsernmTxtbx);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "ConnectionForm";
            this.Text = "ConnectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox UsernmTxtbx;
        private System.Windows.Forms.TextBox PasswordTxtbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox DatabasecmBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Label DbLabel;
        private System.Windows.Forms.Button UseConbttn;
        private System.Windows.Forms.Button Createbttn;
        private System.Windows.Forms.CheckBox Createchckbox;
        private System.Windows.Forms.MaskedTextBox Createtxtbx;
    }
}