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
    public partial class Form2 : Form
    {
        private FormMenu menu;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(FormMenu fm)
        {
            InitializeComponent();
            menu = fm;
            menu.Hide(); 
        }

        private void Previous_task_button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(menu);
            form4.Show();
            this.Close();

        }

        private void Back_to_menu_button1_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void Next_task_button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(menu);
            form3.Show();
            this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out var check)
                | !double.TryParse(textBox2.Text, out check) | !double.TryParse(textBox3.Text, out check))
            {
                MessageBox.Show("Вводите действительные числа!");
            }
            else
            {
                double d = double.Parse(textBox1.Text);
                double a = double.Parse(textBox2.Text);
                double b = double.Parse(textBox3.Text);
                double c = a * b;
                double s = c*0.8;
                if (d % 1 != 0)
                {
                    MessageBox.Show("Введите целое число для дня недели!");
                }
                else if (d>7 | d < 0)
                {
                    MessageBox.Show("Введите нормальный день недели!");
                }                
                else if (d!=7)
                {
                    textBox4.Text = (c).ToString();
                }
                else
                {
                    textBox4.Text =  (s).ToString();
                };
                }
            }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
    }
}
