using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_7.hhh
{
    public partial class Form1 : Form
    {
        private readonly object tbY;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {


            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text=string.Empty;

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)|| string.IsNullOrEmpty(textBox2.Text))
                {
                    textBox3.Text = "Не введено данних!";
                    return;
                }
            string a = textBox1.Text;
            string b = textBox2.Text;
            double x1 = Convert.ToDouble(a);
            double x2 = Convert.ToDouble(b);
            double y = (4 * Math.Sin(3 + x1 * x2)) / (34 - 9 * Math.Pow(x2, 3));
                textBox3.Text = y.ToString("0.###");
            double min = Math.Min(x1, x2);
            textBox4.Text = min.ToString("0.###");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
