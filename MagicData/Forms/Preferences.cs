﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MagicData.Forms
{
    public partial class Preferences : Form
    {
        public Preferences()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FontDialog().ShowDialog();
             
        }
    }
}
