using System;
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
    public partial class Sinema_Bufe_Satis : Form
    {
        public Sinema_Bufe_Satis()
        {
            InitializeComponent();
        }

        int kasatutar = 0;

        private void button1_Click(object sender, EventArgs e)
        {

            int misir, bilet, su, cay, toplam;
            misir = Convert.ToInt16(textBox1.Text);
            bilet = Convert.ToInt16(textBox2.Text);
            su = Convert.ToInt16(textBox3.Text);
            cay = Convert.ToInt16(textBox4.Text);

            toplam = misir * 4 + cay * 2 + su * 1 + bilet * 8;
            label10.Text = toplam.ToString() + " TL";

            kasatutar = kasatutar + toplam;
            label11.Text = kasatutar.ToString() + " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();


        }
    }
}
