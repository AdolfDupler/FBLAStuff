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
        public ConnectionForm()
        {
            InitializeComponent();
        }
        public void CreateConnection()
        {
            SqlConnectionStringBuilder bob = new SqlConnectionStringBuilder();
            bob.DataSource = textBox1.Text;
            bob.TrustServerCertificate = true;
            bob.Encrypt = true;
            bob.IntegratedSecurity = true;
            bob.IntegratedSecurity = !checkBox1.Checked;
            if(!bob.IntegratedSecurity)
            {
                bob.UserID = textBox2.Text;
                bob.Password = textBox3.Text;
            }
            Console.WriteLine(bob.ToString());
            //return;
            SqlCommand test = new SqlCommand("SELECT Name FROM sys.databases where (has_dbaccess(Name) > 0) AND Name NOT IN ('master', 'tempdb', 'model', 'msdb') ORDER BY 1;");
            
            test.Connection = new SqlConnection(bob.ToString());
            
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
            SqlDataReader data = test.ExecuteReader();
            comboBox1.Items.Clear();
            while (data.Read())
            {
                comboBox1.Items.Add(data.GetValue(0));
            }
            
            MessageBox.Show("Connection Success");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateConnection();
        }
    }
}
