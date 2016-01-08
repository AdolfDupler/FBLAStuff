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

        public SqlConnection connection; 

        
        
        public AddMember()

        {
            InitializeComponent();
            
        }

        private void CreateBttn_Click(object sender, EventArgs e)
        {
            InitValues();

            Member lad = new Member(this);
            SqlCommand com = lad.AddToSQL();
            com.Connection = connection;
            connection.Open();
            com.ExecuteNonQuery();
            connection.Close();
            this.Close();
        }
        private void InitValues()
        {
            MemberIDNum = Convert.ToInt32(MemberIDText.Text);
            FirstName = FNameText.Text;
            LastName = LNameText.Text;
            SchoolName = SNameText.Text;
            StateName = StateText.Text;
            Email = EmailText.Text;
            YearJoined = Convert.ToInt32(YearText.Text);
            Grade = Convert.ToInt32(GradeTextBox.Text);
            AmountOwed = Convert.ToDouble(AmountOwedText.Text);
            Active = ActiceChckBox.Checked;

        }
       
    }
}
