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
            int index = 0;
            foreach (Control c in form.Controls[0].Controls)
            {
                if (c is CheckBox)
                {
                    searchingFor[index] = ((CheckBox)c).Checked;

                    if (((CheckBox)c).Checked)
                    {
                        foreach (Control c2 in form.Controls[0].Controls)
                        {
                            if (!(c2 is CheckBox) && c2.Tag == c.Tag)
                            {
                                if (c2 is ComboBox)
                                {
                                    searchingCriteria[index] = ((ComboBox)c2).SelectedIndex;
                                }
                                else
                                {
                                    searchingValues[index] = ((MaskedTextBox)c2).Text;
                                }
                            }
                        }
                    }
                    index++;
                }
            }
            for(int i = 0; i < 10; i++)
            {

            }

        }
    }
}
