using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mohammeds_minräknare
{
    public partial class Form1 : Form
    {
        private string mode = "";
        double number = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (label1.Text == "0")
            {
                label1.Text = btn.Text;
            }
            else
            {
                label1.Text = label1.Text + btn.Text;
            }
        }



        private void button10_Click(object sender, EventArgs e)
        {
            double tmp = double.Parse(label1.Text);

            if (mode == "+")
            {
                label1.Text = (number + tmp).ToString();
            }
            else if (mode == "-")
            {
                label1.Text = (number + tmp).ToString();
            }
            else if (mode == "*")
            {
                label1.Text = (number + tmp).ToString();
            }
            else if (mode == "/")
            {
                label1.Text = (number + tmp).ToString();
            }




            else if (mode == "x^y")
            {
                
                label1.Text = Math.Pow(number, tmp).ToString();
            }
            else if (mode == "%")
            {
                label1.Text = ((number / 100) * tmp).ToString();
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            mode = btn.Text;
            number = double.Parse(label1.Text);
            label1.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if(label1.Text.Length == 1)
            {
                label1.Text = "0";
            }
            else
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1);
            }
        }



        private void button25_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToInt64(label1.Text, 2).ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToInt64(label1.Text, 2).ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double tmp = double.Parse(label1.Text);
            label1.Text = Math.Sqrt(tmp).ToString();



        }

        private void button21_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }
    }
    
}   

        










