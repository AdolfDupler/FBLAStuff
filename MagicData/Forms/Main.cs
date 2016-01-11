using MagicData.Classes;
using MagicData.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MagicData
{
    public partial class Main : Form
    {
        public string loadedPath = "", loadedName;
        private List<Member> LoadedData = new List<Member>();
        public SqlConnection current;
        private string title = "MagicData - Main Menu";
        public Main()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Database Files | *.mdf";
            saveFileDialog1.DefaultExt = "mdf";
            openFileDialog1.Filter = "Database Files | *.mdf";
            openFileDialog1.DefaultExt = "mdf";
        }

        

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName.Replace('/', '\\');
                string databasename = System.IO.Path.GetFileNameWithoutExtension(filename);
                connection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; Initial Catalog = tempdb; Integrated Security = True;");
                connection.Open();
                SqlCommand command = connection.CreateCommand();

                command.CommandText = String.Format("CREATE DATABASE {0} ON PRIMARY (NAME = {0}, FILENAME = '{1}'); ", databasename, filename);
                try {
                    command.ExecuteNonQuery();
                }
                catch(SqlException exc)
                {
                    MessageBox.Show("You cannot name your database this.\n\nIf you believe this is an error, show this code to a programmer: " + exc.Message);
                    return;
                }
                command.CommandText = String.Format("EXEC sp_detach_db '{0}', 'true'", databasename);
                command.ExecuteNonQuery();
               
                
                connection.Close();
                loadData(filename);
                

                
                
                
                
                
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                loadData(openFileDialog1.FileName);
            }
        }
        private void loadData(string path)
        {
            loadedPath = path.Replace('/', '\\');
            loadedName = System.IO.Path.GetFileNameWithoutExtension(loadedPath);
            current = new SqlConnection();
            current.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; Integrated Security = True;";
            current.ConnectionString += "AttachDBFilename =" + loadedPath;
            this.Text = title + " - " + loadedName;

            SqlCommand command = new SqlCommand();
            current.Open();
            command.Connection = current;
            command.CommandText = "IF( NOT EXISTS (SELECT * FROM sys.tables WHERE [name] = 'Members'))BEGIN CREATE TABLE Members (MemberID int, FirstName ntext, LastName ntext, SchoolName ntext, State ntext, Email ntext, YearJoined int, Grade int, Active bit, AmountOwed money) END;";
            command.ExecuteNonQuery();
            current.Close();



        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(current == null)
            {
                MessageBox.Show("YOU MUST SPECIFY A DTABASE");
                return;
            }
            AddMember form = new AddMember();
            form.connection = current;
            form.Show();
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            foreach(Member mem in LoadedData)
            {
                mem.compareKey = e.Column;
            }
            LoadedData.Sort();
           
            
        }

        private void refreshData(object sender, EventArgs e) //Call this ONLY after the connection has been established.
        {
            LoadedData.Clear();
            if (current == null)
            {
                return;
            }
            SqlCommand query = new SqlCommand("SELECT * FROM Members;");
            query.Connection = current;
            current.Open();
            SqlDataReader data = query.ExecuteReader();
            
            
            while(data.Read())
            {
                object[] enl = new object[10];
                data.GetValues(enl);
                foreach(object ob in enl)
                {
                    Console.WriteLine(ob.ToString());
                }
                Console.WriteLine(new Member(enl).toString());
                LoadedData.Add(new Member(enl));
                LoadedData.Sort();
            }
            current.Close();
            foreach(Member mem in LoadedData)
            {
                listView1.Items.Add(mem.ToListViewItem());
            }
        }

        
    }
}
