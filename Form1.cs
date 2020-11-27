using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gissa_talet
{
    public partial class Form1 : Form
    {
        Random slump = new Random();
        int slumptal;
        int räknare = 0;

        public Form1()
        {
            slumptal = slump.Next(1, 101);
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tal = int.Parse(textBox1.Text);
            if (tal == slumptal)
                label2.Text = "Rätt";
            else if (tal < slumptal)
                label2.Text = "Talet är större, gissa igen";
            else
                label2.Text = "Talet är mindre, gissa igen";
            räknare++;
            label3.Text = räknare.ToString();
        }
    }
}
