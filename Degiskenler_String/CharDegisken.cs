﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_String
{
    public partial class CharDegisken : Form
    {
        public CharDegisken()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //char takim;
            //takim = 'g';
            //label1.Text = takim.ToString();

            char ders;
            ders = Convert.ToChar(textBox1.Text);
            label1.Text = ders.ToString();
        }
    }
}
