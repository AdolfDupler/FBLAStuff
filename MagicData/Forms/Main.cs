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
    /// <summary>
    /// This is the class form the opening window, aka the "Main Menu".
    /// 
    /// </summary>
    public partial class Main : Form
    {
        public string loadedPath = "", loadedName;
        private List<Member> LoadedData = new List<Member>();
        public SqlConnection current;
        private string title = "MagicData - Main Menu";
        /// <summary>
        /// This is the default constructor. Add to it but beware.
        /// </summary>
        public Main()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Database Files | *.mdf";
            saveFileDialog1.DefaultExt = "mdf";
            openFileDialog1.Filter = "Database Files | *.mdf";
            openFileDialog1.DefaultExt = "mdf";
        }

        
        /// <summary>
        /// This method is called when the user hit the new button.
        /// This method creates a database at the filepath specified by save file dialog.
        /// It then calls load data on that database.
        /// </summary>
        /// <param name="sender"> Object that sent the action</param>
        /// <param name="e">Various event arguements.</param>
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
                    MessageBox.Show("You cannot name your database this.\n\nError Code: " + exc.Message);
                    return;
                }
                command.CommandText = String.Format("EXEC sp_detach_db '{0}', 'true'", databasename);
                command.ExecuteNonQuery();
               
                
                connection.Close();
                loadData(filename);
                

                
                
                
                
                
            }
        }
        /// <summary>
        /// Simple action for opening a local databse. It just calls load data on specified database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SqlConnection.ClearAllPools();
                loadData(openFileDialog1.FileName);
                
            }
        }
        /// <summary>
        /// This is the loading method for initializing a local database for use with the program.
        /// It sets the current connection string to point to the database, and it creates a members table if it does not exist.
        /// It also initializes all the variables neccessary for the program to operate.
        /// </summary>
        /// <param name="path"></param>
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
            command.CommandText = "IF( NOT EXISTS (SELECT * FROM sys.tables WHERE [name] = 'Members'))BEGIN CREATE TABLE Members (MemberID int NOT NULL, FirstName nvarchar(13), LastName nvarchar(13), SchoolName nvarchar(50), State nvarchar(2), Email nvarchar(50), YearJoined int, Grade int, Active bit, AmountOwed money, PRIMARY KEY (MemberID)) END;";
            command.ExecuteNonQuery();
            current.Close();
            PullData();
            




        }
        /// <summary>
        /// This opens a new add member form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(current == null)
            {
                MessageBox.Show("YOU MUST SPECIFY A DTABASE");
                return;
            }
            AddMember form = new AddMember(this);
            form.connection = current;
            form.Show();
        }
        /// <summary>
        /// This iterates through the loaded data, sorting it into
        /// the specified order. It also refreshes the data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            foreach(Member mem in LoadedData)
            {
                mem.compareKey = e.Column;
            }
            refreshData();
           
            
        }
        /// <summary>
        /// This is the action for opening a new advanced search.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            new AdvancedSearch(this).Show();
        }

       
        
        /// <summary>
        /// This will place all loaded data into the mai list view
        /// in the order currently established in the member list.
        /// </summary>
        private void refreshData() 
        {
            ViewWindowListView.Items.Clear();
            LoadedData.Sort();
            foreach(Member mem in LoadedData)
            {
                ViewWindowListView.Items.Add(mem.ToListViewItem());
            }
        }
        /// <summary>
        /// This is the main method for changing the loaded data.
        /// </summary>
        /// <param name="querified"></param>
        public void loadQueryData(List<Member> querified)
        {
            ViewWindowListView.Items.Clear();
            LoadedData = querified;
            refreshData();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new ConnectionForm().Show();
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModMember form = new ModMember(LoadedData.ElementAt(ViewWindowListView.SelectedIndices[0]));
            form.parent = this;
            form.con = current;
            form.Show();
        }

        /// <summary>
        /// This loads all the data from the database into the form, as well
        /// as refreshing it.
        /// </summary>
        public void PullData()
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
            


            while (data.Read())
            {
                object[] enl = new object[10];
                data.GetValues(enl);
                LoadedData.Add(new Member(enl));
                
            }
            current.Close();
            refreshData();
        }
       
    }
}
