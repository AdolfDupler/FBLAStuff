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
    public partial class ConnectionForm : Form
    {
        private SqlConnection validConnection;
        private Main parent;

        public ConnectionForm(Main parent)
        {
            this.parent = parent;
            InitializeComponent();
            deactivate();
        }
        public void CreateConnection()
        {
            SqlConnectionStringBuilder bob = new SqlConnectionStringBuilder();
            bob.ConnectTimeout = 5;
            bob.DataSource = textBox1.Text;
            bob.TrustServerCertificate = true;
            bob.Encrypt = true;
            bob.IntegratedSecurity = true;
            bob.IntegratedSecurity = !checkBox1.Checked;
            if(!bob.IntegratedSecurity)
            {
                bob.UserID = UsernmTxtbx.Text;
                bob.Password = PasswordTxtbox.Text;
            }
            Console.WriteLine(bob.ToString());
            //return;
            SqlCommand test = new SqlCommand("SELECT Name FROM sys.databases where (has_dbaccess(Name) > 0) AND Name NOT IN ('master', 'tempdb', 'model', 'msdb') ORDER BY 1;");
            
            test.Connection = new SqlConnection(bob.ToString());
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                test.Connection.Open();
                
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
                test.Connection.Close();
                return;
            }
            validConnection = test.Connection;
            
            SqlDataReader data = test.ExecuteReader();
            DatabasecmBox.Items.Clear();
            while (data.Read())
            {
                DatabasecmBox.Items.Add(data.GetValue(0));
            }

            Cursor.Current = Cursors.Default;
            validConnection.Close();
            activate();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateConnection();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UsernameLbl.Enabled = checkBox1.Checked;
            PasswordLbl.Enabled = checkBox1.Checked;
            UsernmTxtbx.Enabled = checkBox1.Checked;
            PasswordTxtbox.Enabled = checkBox1.Checked;
            deactivate();
        }

        private void Createchckbox_CheckedChanged(object sender, EventArgs e)
        {
            Createbttn.Enabled = Createchckbox.Checked;
            Createtxtbx.Enabled = Createchckbox.Checked;
            DatabasecmBox.Enabled = !Createchckbox.Checked;
            UseConbttn.Enabled = !Createchckbox.Checked;
            DbLabel.Enabled = !Createchckbox.Checked;
        }
        private void activate()
        {
            Createchckbox.Enabled = true;
            Createchckbox.Checked = true;
        }
        private void deactivate()
        {
            Createchckbox.Checked = false;
            Createchckbox.Enabled = false;
            DatabasecmBox.Enabled = false;
            UseConbttn.Enabled = false;
            DbLabel.Enabled = false;
        }
        private void Action_Deactivate(object sender, EventArgs e)
        {
            deactivate();
        }

        private void Createbttn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = String.Format("CREATE DATABASE {0};", Createtxtbx.Text);
            command.Connection = validConnection;
            validConnection.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message + " " + command.CommandText);
                validConnection.Close();
                return;
            }
            validConnection.Close();
            Console.WriteLine(command.CommandText);

        }

        private void UseConbttn_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder bob = new SqlConnectionStringBuilder();
            bob.AttachDBFilename = DatabasecmBox.Text;
            Console.WriteLine(validConnection.ConnectionString + ";" + bob.ToString());
            
            SqlCommand command = new SqlCommand();
            try {
                validConnection.Open();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
                return;
            }
            command.Connection = validConnection;
            command.CommandText = "IF( NOT EXISTS (SELECT * FROM sys.tables WHERE [name] = 'Members'))BEGIN CREATE TABLE Members (MemberID int NOT NULL, FirstName nvarchar(13), LastName nvarchar(13), SchoolName nvarchar(50), State nvarchar(2), Email nvarchar(50), YearJoined int, Grade int, Active bit, AmountOwed money, PRIMARY KEY (MemberID)) END;";
            command.ExecuteNonQuery();
            validConnection.Close();
            parent.current = validConnection;
            parent.PullData();
            this.Close();




        }
    }
}
