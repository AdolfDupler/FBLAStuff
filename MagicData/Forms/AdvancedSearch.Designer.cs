﻿namespace MagicData.Forms
{
    partial class AdvancedSearch
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
            this.label1 = new System.Windows.Forms.Label();
            this.MembershipChckBox = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.MemIDCombox = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox7 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox9 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search for:";
            // 
            // MembershipChckBox
            // 
            this.MembershipChckBox.AutoSize = true;
            this.MembershipChckBox.Location = new System.Drawing.Point(3, 3);
            this.MembershipChckBox.Name = "MembershipChckBox";
            this.MembershipChckBox.Size = new System.Drawing.Size(97, 17);
            this.MembershipChckBox.TabIndex = 1;
            this.MembershipChckBox.Tag = "MembershipID";
            this.MembershipChckBox.Text = "Membership ID";
            this.MembershipChckBox.UseVisualStyleBackColor = true;
            this.MembershipChckBox.CheckedChanged += new System.EventHandler(this.ChckBox_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(3, 45);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(76, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Tag = "First Name";
            this.checkBox2.Text = "First Name";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.ChckBox_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(3, 87);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(77, 17);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Tag = "Last Name";
            this.checkBox3.Text = "Last Name";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.ChckBox_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(3, 129);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(59, 17);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Tag = "School";
            this.checkBox4.Text = "School";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.ChckBox_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(3, 171);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(51, 17);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Tag = "State";
            this.checkBox5.Text = "State";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.ChckBox_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(3, 213);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(51, 17);
            this.checkBox6.TabIndex = 6;
            this.checkBox6.Tag = "Email";
            this.checkBox6.Text = "Email";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.ChckBox_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(3, 255);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(48, 17);
            this.checkBox7.TabIndex = 7;
            this.checkBox7.Tag = "Year";
            this.checkBox7.Text = "Year";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.ChckBox_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(3, 297);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(55, 17);
            this.checkBox8.TabIndex = 8;
            this.checkBox8.Tag = "Grade";
            this.checkBox8.Text = "Grade";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.ChckBox_CheckedChanged);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(3, 381);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(93, 17);
            this.checkBox9.TabIndex = 10;
            this.checkBox9.Tag = "Amount Owed";
            this.checkBox9.Text = "Amount Owed";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.ChckBox_CheckedChanged);
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(3, 339);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(56, 17);
            this.checkBox10.TabIndex = 9;
            this.checkBox10.Tag = "Active";
            this.checkBox10.Text = "Active";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.ChckBox_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBox4, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBox3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBox2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox7, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.comboBox6, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.MembershipChckBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBox3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBox8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.checkBox4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.checkBox7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.checkBox5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.checkBox6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.MemIDCombox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBox4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBox5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBox1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBox6, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBox7, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.comboBox9, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBox10, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.checkBox9, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.checkBox10, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBox9, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.comboBox8, 1, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(427, 424);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Enabled = false;
            this.maskedTextBox4.Location = new System.Drawing.Point(287, 129);
            this.maskedTextBox4.Mask = "CCCCCCCCCCCCCCCCCCCCCC";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(137, 20);
            this.maskedTextBox4.TabIndex = 21;
            this.maskedTextBox4.Tag = "School";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Enabled = false;
            this.maskedTextBox3.Location = new System.Drawing.Point(287, 87);
            this.maskedTextBox3.Mask = "CCCCCCCCCCCCCCCCCCCCCC";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(137, 20);
            this.maskedTextBox3.TabIndex = 20;
            this.maskedTextBox3.Tag = "Last Name";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Enabled = false;
            this.maskedTextBox2.Location = new System.Drawing.Point(287, 45);
            this.maskedTextBox2.Mask = "CCCCCCCCCCCCCCCCCCCCCC";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(137, 20);
            this.maskedTextBox2.TabIndex = 19;
            this.maskedTextBox2.Tag = "First Name";
            // 
            // comboBox7
            // 
            this.comboBox7.Enabled = false;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "IS GREATER THAN",
            "IS LESS THAN",
            "IS EQUAL TO"});
            this.comboBox7.Location = new System.Drawing.Point(145, 297);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(136, 21);
            this.comboBox7.TabIndex = 17;
            this.comboBox7.Tag = "Grade";
            // 
            // comboBox6
            // 
            this.comboBox6.Enabled = false;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "IS GREATER THAN",
            "IS LESS THAN",
            "IS EQUAL TO"});
            this.comboBox6.Location = new System.Drawing.Point(145, 255);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(136, 21);
            this.comboBox6.TabIndex = 16;
            this.comboBox6.Tag = "Year";
            // 
            // MemIDCombox
            // 
            this.MemIDCombox.Enabled = false;
            this.MemIDCombox.FormattingEnabled = true;
            this.MemIDCombox.Items.AddRange(new object[] {
            "IS GREATER THAN",
            "IS LESS THAN",
            "IS EQUAL TO"});
            this.MemIDCombox.Location = new System.Drawing.Point(145, 3);
            this.MemIDCombox.Name = "MemIDCombox";
            this.MemIDCombox.Size = new System.Drawing.Size(136, 21);
            this.MemIDCombox.TabIndex = 11;
            this.MemIDCombox.Tag = "MembershipID";
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "CONTAINS",
            "MATCHES"});
            this.comboBox2.Location = new System.Drawing.Point(145, 45);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(136, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.Tag = "First Name";
            // 
            // comboBox3
            // 
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "CONTAINS",
            "MATCHES"});
            this.comboBox3.Location = new System.Drawing.Point(145, 87);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(136, 21);
            this.comboBox3.TabIndex = 13;
            this.comboBox3.Tag = "Last Name";
            // 
            // comboBox4
            // 
            this.comboBox4.Enabled = false;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "CONTAINS",
            "MATCHES"});
            this.comboBox4.Location = new System.Drawing.Point(145, 129);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(136, 21);
            this.comboBox4.TabIndex = 14;
            this.comboBox4.Tag = "School";
            // 
            // comboBox5
            // 
            this.comboBox5.Enabled = false;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "CONTAINS",
            "MATCHES"});
            this.comboBox5.Location = new System.Drawing.Point(145, 213);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(136, 21);
            this.comboBox5.TabIndex = 15;
            this.comboBox5.Tag = "Email";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Location = new System.Drawing.Point(287, 3);
            this.maskedTextBox1.Mask = "9999999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(137, 20);
            this.maskedTextBox1.TabIndex = 18;
            this.maskedTextBox1.Tag = "MembershipID";
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.Enabled = false;
            this.maskedTextBox6.Location = new System.Drawing.Point(287, 213);
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.Size = new System.Drawing.Size(137, 20);
            this.maskedTextBox6.TabIndex = 23;
            this.maskedTextBox6.Tag = "Email";
            // 
            // maskedTextBox7
            // 
            this.maskedTextBox7.Enabled = false;
            this.maskedTextBox7.Location = new System.Drawing.Point(287, 255);
            this.maskedTextBox7.Mask = "0000";
            this.maskedTextBox7.Name = "maskedTextBox7";
            this.maskedTextBox7.Size = new System.Drawing.Size(137, 20);
            this.maskedTextBox7.TabIndex = 24;
            this.maskedTextBox7.Tag = "Year";
            // 
            // comboBox9
            // 
            this.comboBox9.Enabled = false;
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AS",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "DC",
            "FL",
            "GA",
            "GU",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MH",
            "MA",
            "MI",
            "FM",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "MP",
            "OH",
            "OK",
            "OR",
            "PW",
            "PA",
            "PR",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "VI",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.comboBox9.Location = new System.Drawing.Point(287, 171);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(137, 21);
            this.comboBox9.TabIndex = 28;
            this.comboBox9.Tag = "State";
            // 
            // comboBox10
            // 
            this.comboBox10.Enabled = false;
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[] {
            "Freshman",
            "Sophmore",
            "Junior",
            "Senior"});
            this.comboBox10.Location = new System.Drawing.Point(287, 297);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(137, 21);
            this.comboBox10.TabIndex = 29;
            this.comboBox10.Tag = "Grade";
            // 
            // maskedTextBox9
            // 
            this.maskedTextBox9.Enabled = false;
            this.maskedTextBox9.Location = new System.Drawing.Point(287, 381);
            this.maskedTextBox9.Mask = "$000.00";
            this.maskedTextBox9.Name = "maskedTextBox9";
            this.maskedTextBox9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBox9.Size = new System.Drawing.Size(137, 20);
            this.maskedTextBox9.TabIndex = 26;
            this.maskedTextBox9.Tag = "Amount Owed";
            this.maskedTextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "TRUE",
            "FALSE"});
            this.comboBox1.Location = new System.Drawing.Point(287, 339);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 21);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.Tag = "Active";
            // 
            // comboBox8
            // 
            this.comboBox8.Enabled = false;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "IS GREATER THAN",
            "IS LESS THAN",
            "IS EQUAL TO"});
            this.comboBox8.Location = new System.Drawing.Point(145, 381);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(136, 21);
            this.comboBox8.TabIndex = 17;
            this.comboBox8.Tag = "Amount Owed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Where:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Values:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdvancedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 495);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "AdvancedSearch";
            this.Text = "AdvancedSearch";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox MembershipChckBox;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox MemIDCombox;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.ComboBox comboBox10;
    }
}