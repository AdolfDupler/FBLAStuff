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
    public partial class AddMember : Form
    {
        //Not Done Yet
        public int MemberIDNum;
        public string FirstName, LastName, SchoolName, StateName, Email;
        public int YearJoined, Grade;
        public double AmountOwed;
        public bool Active;
        private Main parent;
        public SqlConnection connection; 

        
        
        public AddMember(Main sender)

        {
            InitializeComponent();
            parent = sender;
            
        }

        private void CreateBttn_Click(object sender, EventArgs e)
        {
            try {
                InitValues();

                
            }
            catch(Exception exc)
            {
                MessageBox.Show("Registration of member has failed. Please check your inputs and try again.\n\nError Code: " + exc.Message);
                return;
            }
            Member lad = new Member(this);
            SqlCommand com = lad.AddToSQL();
            com.Connection = connection;
            try
            {


                connection.Open();
                com.ExecuteNonQuery();
                connection.Close();
            }
            catch(SqlException exc)
            {
                MessageBox.Show("Writing to database has failed. Please check your connection, then try again.\n\nError Code: " + exc.Message);
                return;
            }
            MessageBox.Show("Registration Successful.");
            parent.PullData();
            this.Close();
        }
        private void InitValues()
        {
            MemberIDNum = Convert.ToInt32(MemberIDText.Text);
            FirstName = FNameText.Text;
            LastName = LNameText.Text;
            SchoolName = SNameText.Text;
            StateName = StateCombobox.Text;
            Email = EmailText.Text;
            YearJoined = Convert.ToInt32(YearText.Text);
            Grade = Convert.ToInt32(GradeComboBox.SelectedIndex + 9);
            AmountOwed = Convert.ToDouble(AmountOwedText.Text.Remove(0,1));
            Active = ActiceChckBox.Checked;

        }
       
    }
}
