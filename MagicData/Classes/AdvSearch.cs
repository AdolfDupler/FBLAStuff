using MagicData.Forms;
using System;
using System.Collections.Generic;
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
                        }
                        else
                        {
                            searchingCriteria[i] = boxes.ElementAt(0).SelectedIndex + 1;
                            searchingValues[i] = boxes.ElementAt(1).Text;
                        }
                    }
                    else
                    {
                        searchingCriteria[i] = boxes.ElementAt(0).SelectedIndex + 1;
                        searchingValues[i] = text.Text;
                    }
                        
                            
                }
                i++;

                
            }
            for(int iny = 0; iny < 10; iny++)
            {
                Console.WriteLine(searchingFor[iny] + ":" + searchingCriteria[iny] + ":" + searchingValues[iny]);
            }
            

        }
    }
}
