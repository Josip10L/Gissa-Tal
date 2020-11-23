using System;
using System.Windows.Forms;

namespace Gissa_talet2
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

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int tal = int.Parse(textBox1.Text);
            if (tal == slumptal)
                label4.Text = "Rätt";
            else if (tal < slumptal)
                label4.Text = "Talet är större, gissa igen";
            else
                label4.Text = "Talet är mindre, gissa igen";
            räknare++;
            label2.Text = räknare.ToString();

        }
    }
}
