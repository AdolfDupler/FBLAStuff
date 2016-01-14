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
    public partial class AdvancedSearch : Form
    {
        public Main parent;
        
        public AdvancedSearch(Main load)
        {
            InitializeComponent();
            parent = load;
        }

        private void ChckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            foreach(Control c in tableLayoutPanel1.Controls)
            {
                if (c.Tag == box.Tag & !c.Equals(box))
                {
                    c.Enabled = box.Checked;
                    if(c is ComboBox)
                    {
                        ComboBox combo = (ComboBox) c;
                        combo.SelectedIndex = 0;
                    }


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand query = new AdvSearch(this).toCommandSearch();
            query.Connection = parent.current;
            parent.current.Open();
            SqlDataReader readData = query.ExecuteReader();
            List<Member> results = new List<Member>();
            while (readData.Read())
            {
                object[] row = new object[10];
                readData.GetValues(row);
                results.Add(new Member(row));

            }
            parent.current.Close();
            parent.loadQueryData(results);

            

        }
    }
}
