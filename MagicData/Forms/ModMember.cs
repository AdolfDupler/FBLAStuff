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
        public Main parent;

        private void ModBttn_Click(object sender, EventArgs e)
        {
            try
            {
                InitValues();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Registration of member has failed. Please check your inputs and try again.\n\nError Code: " + exc.Message);
                return;
            }
            SqlCommand command = new Member(this).UpdateIntoSQL();
            command.Connection = con;
            Console.WriteLine(con.ConnectionString);
            con.Open();
            try
            {
                Console.WriteLine(command.ExecuteNonQuery());
            }
            catch(Exception exc)
            {
                MessageBox.Show("It broke.\n\nMessage:" + exc.Message);
                return;
            }
            con.Close();
            MessageBox.Show("Update Successful.");
            parent.PullData();
            Close();
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
        private void InitValues()
        {
            MemberID = Convert.ToInt32(MemberIDText.Text);
            FirstName = FNameText.Text;
            LastName = LNameText.Text;
            SchoolName = SNameText.Text;
            State = StateCombobox.Text;
            Email = EmailText.Text;
            YearJoined = Convert.ToInt32(YearText.Text);
            Grade = Convert.ToInt32(GradeComboBox.SelectedIndex + 9);
            AmountOwed = Convert.ToDouble(AmountOwedText.Text.Remove(0, 1));
            active = ActiceChckBox.Checked;

        }

    }
}
