using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_OOP
{
    public partial class Form4 : Form
    {
        private FormMenu menu;
        private List<double> arr;
        public Form4()
        {
            InitializeComponent();
        }

        public Form4(FormMenu fm)
        {
            InitializeComponent();
            menu = fm;
            arr = new List<double>();
            menu.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(menu);
            form5.Show();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(menu);
            form2.Show();
            this.Close();
        }



        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Money money = new Money(long.Parse(textBox1.Text), int.Parse(textBox2.Text));
                double num = double.Parse(textBox3.Text);
                textBox4.Text = money.Summary(num).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка");
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            try
            {
                Money money = new Money(long.Parse(textBox1.Text), int.Parse(textBox2.Text));
                double num = double.Parse(textBox3.Text);
                textBox4.Text = money.Minus(num).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка");
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                Money money = new Money(long.Parse(textBox1.Text), int.Parse(textBox2.Text));
                double num = double.Parse(textBox3.Text);
                textBox4.Text = money.Delenie(num).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                Money money = new Money(long.Parse(textBox1.Text), int.Parse(textBox2.Text));
                double num = double.Parse(textBox3.Text);
                textBox4.Text = money.Umnozhit(num).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                Money money = new Money(long.Parse(textBox1.Text), int.Parse(textBox2.Text));
                double num = double.Parse(textBox3.Text);
                textBox4.Text = money.Sravnenie(num).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка");
            }
        }
    }
    public class Money
    {
        public long rub;
        public int kop;
        public double sum;

        public Money(long rub, int kop)
        {
            if (kop > 99)
            {
                throw new Exception("Копейки - это от 0 до 99");
            }
            this.rub = rub;
            this.kop = kop;
            if (rub > 0)
            {
                sum = kop;
            }
            else
            {
                sum = -kop;
            }
            sum /= 100;
            sum += rub;
        }

        public double Summary(double num)
        {
            return sum += num;
        }

        public double Minus(double num)
        {
            return sum -= num;
        }

        public double Umnozhit(double num)
        {
            return sum *= num;
        }

        public double Delenie(double num)
        {
            return sum / num;
        }

        public string Sravnenie(double num)
        {
            
            if (sum > num)
            {
                return ">";
            }
            else if (sum < num)
            {
                return "<";
            }
            else
            {
                return "=";
            }
        }
    }
}
