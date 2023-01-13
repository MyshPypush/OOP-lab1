using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1_OOP
{
    public partial class Form1 : Form
    {

        private FormMenu menu;
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(FormMenu fm)
        {
            InitializeComponent();
            menu = fm;
            fm.Hide();

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out var check)
                | !double.TryParse(textBox2.Text, out check))
            {
                MessageBox.Show("Вводите действительные числа!");
            }
            else
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                if (a >= -1 & b >= -1 & a <= 1 & b <= 1)
                {
                    textBox4.Text = "Точка принадлежит заштрихованной части плоскости ";
                }
                else if (a < -1 | a > 1 | b < -1 | b > 1)
                {
                    textBox4.Text = "Точка не принадлежит заштрихованной части плоскости ";
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(menu);
            form5.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
    

