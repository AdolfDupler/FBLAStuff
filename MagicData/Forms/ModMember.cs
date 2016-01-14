using MagicData.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MagicData.Forms
{
    public partial class ModMember : Form
    {
        public int MemberID;
        public string FirstName, LastName;
        public string SchoolName;
        public string State;
        public string Email;
        public int YearJoined, Grade;
        public bool active;

        public SqlConnection con;

        private void ModBttn_Click(object sender, EventArgs e)
        {

        }

        public double AmountOwed;
        public ModMember(Member loadedMember)
        {
            InitializeComponent();
            loadData(loadedMember);
            
        }
        private void loadData(Member mem)
        {
            mem.LoadIntoForm(this);
            MemberIDText.Text = MemberID.ToString();
            FNameText.Text = FirstName;
            LNameText.Text = LastName;
            SNameText.Text = SchoolName;
            StateCombobox.SelectedIndex = StateCombobox.Items.IndexOf(State);
            EmailText.Text = Email;
            YearText.Text = YearJoined.ToString();
            GradeComboBox.SelectedIndex = Grade - 9;
            ActiceChckBox.Checked = active;
            AmountOwedText.Text = AmountOwed.ToString("C");



        }

        
    }
}
