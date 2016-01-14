using MagicData.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MagicData.Classes
{
    class AdvSearch

    {
        public bool[] searchingFor = new bool[10];
        public int[] searchingCriteria = new int[10];
        public object[] searchingValues = new object[10];

        public AdvSearch(AdvancedSearch form)
        {
            int i = 0;
            foreach (CheckBox chckbx in form.Controls[3].Controls.OfType<CheckBox>().OrderBy(val => val.TabIndex))
            {
                searchingFor[i] = chckbx.Checked;
                if (chckbx.Checked)
                {
                    MaskedTextBox text = form.Controls[3].Controls.OfType<MaskedTextBox>().Where(t => t.Tag == chckbx.Tag).ElementAtOrDefault(0);

                    IEnumerable<ComboBox> boxes = form.Controls[3].Controls.OfType<ComboBox>().Where(t => t.Tag == chckbx.Tag).OrderBy(c => c.TabIndex);
                    if(text == null)
                    {
                        if(boxes.ElementAtOrDefault(1) == null)
                        {
                            
                            searchingValues[i] = boxes.ElementAt(0).Text;
                            if (searchingValues[i].ToString().Length < 3) searchingValues[i] = "'" + searchingValues[i] + "'";
                                
                        }
                        else
                        {
                            searchingCriteria[i] = boxes.ElementAt(0).SelectedIndex + 1;
                            searchingValues[i] = boxes.ElementAt(1).SelectedIndex + 9;
                        }
                    }
                    else
                    {
                        searchingCriteria[i] = boxes.ElementAt(0).SelectedIndex + 1;
                        try
                        {
                            searchingValues[i] =  Convert.ToInt32(text.Text);
                        }
                        catch
                        {
                            searchingValues[i] = text.Text;
                        }
                    }
                        
                            
                }
                i++;

                
            }
            
            

        }
        public SqlCommand toCommandSearch()
        {
            StringBuilder commandMaker = new StringBuilder();
            commandMaker.Append("SELECT * FROM Members WHERE ");
            SqlCommand com = new SqlCommand();
            for (int i = 0; i < searchingFor.Length; i++)
            {

                if (searchingFor[i])
                {
                    if (searchingValues[i] is string)
                    {
                        switch (searchingCriteria[i])
                        {
                            case 0:
                                commandMaker.Append(Member.columns[i] + "=" + searchingValues[i] + " ");
                                break;
                            case 1:
                                commandMaker.Append(Member.columns[i] + " LIKE '%' + @" + Member.columns[i] + " + '%' ");
                                com.Parameters.Add("@" + Member.columns[i], SqlDbType.NText).Value = searchingValues[i];
                                break;
                            case 2:
                                commandMaker.Append(Member.columns[i] + "=" + "@" + Member.columns[i] + " ");
                                com.Parameters.Add("@" + Member.columns[i], SqlDbType.NText).Value = searchingValues[i];
                                break;
                            default:
                                throw new Exception("WHAT THE HELL DID YOU DO?");                                                                      
                        }

                    }
                    else
                    {
                        switch(searchingCriteria[i])
                        {
                            case 1:
                                commandMaker.Append(Member.columns[i] + " > " + searchingValues[i] + " ");
                                break;
                            case 2:
                                commandMaker.Append(Member.columns[i] + " < " + searchingValues[i] + " ");
                                break;
                            case 3:
                                commandMaker.Append(Member.columns[i] + " = " + searchingValues[i] + " ");
                                break;
                            default:
                                throw new Exception("Somehow, you broke out of the norm. Congrats.");
                                
                        }
                    }
                    commandMaker.Append("AND ");
                }
            }
            commandMaker.Append("1 = 1;");
            

            com.CommandText = commandMaker.ToString();
            Console.WriteLine(com.CommandText);
            return com;
        }
    }
}
