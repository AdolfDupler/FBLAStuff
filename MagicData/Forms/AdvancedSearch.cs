using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MagicData.Forms
{
    public partial class AdvancedSearch : Form
    {

        public AdvancedSearch()
        {
            InitializeComponent();
            
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
    }
}
