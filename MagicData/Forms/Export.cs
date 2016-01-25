using MagicData.Classes;
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
    public partial class Export : Form
    {
        public Export()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string temp = openFileDialog1.FileName;
                string path = saveFileDialog1.FileName;
                new ExcelExport(temp, path);
            }
            else
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string temp = openFileDialog1.FileName;
                string path = saveFileDialog1.FileName;
                new ExcelExport(temp, path).SaveAndExport(true, true);
            }
            else
            {
                return;
            }
        }
    }
}
