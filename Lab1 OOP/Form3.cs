using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Lab1_OOP
{
    public partial class Form3 : Form
    {
        private FormMenu menu;
        private List<List<int>> matrix;
        private List<List<int>> result;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(FormMenu fm)
        {
            InitializeComponent();
            menu = fm;
            this.matrix = new List<List<int>>();
            this.result = new List<List<int>>();
            menu.Hide();
        }

        private void Back_to_menu_button1_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void Previous_task_button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(menu);
            form2.Show();
            this.Close();
        }
        private void Next_task_button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(menu);
            form4.Show();
            this.Close();
        }

        private void Show_task(object sender, EventArgs e)
        {
            MessageBox.Show("Сформировать матрицу из чисел от 0 до 999,\r\nвывести ее на экран. Посчитать\r\nколичество двузначных чисел в ней.", "Задание на работу");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out var check)
                | !int.TryParse(textBox2.Text, out check))
            {
                MessageBox.Show("Вводите целые числа больше 1!", "Ошибка");
            }
            else
            {
                if (int.Parse(textBox1.Text) < 2
                    | int.Parse(textBox2.Text) < 2)
                {
                    MessageBox.Show("Вводите целые числа больше 1!", "Ошибка");
                }
                else
                {
                    int row_num = int.Parse(textBox1.Text);
                    int col_num = int.Parse(textBox2.Text);
                    if (dataGridView1.Columns.Count < col_num)
                    {
                        for (int i = dataGridView1.Columns.Count; i < col_num; i++)
                        {
                            dataGridView1.Columns.Add($"Column{i + 1}", $"Столбец {i + 1}");
                        }
                    }
                    else if (dataGridView1.Columns.Count > col_num)
                    {
                        for (int i = dataGridView1.Columns.Count; i > col_num; i--)
                        {
                            dataGridView1.Columns.RemoveAt(i - 1);
                        }
                    }
                    dataGridView1.RowCount = row_num;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Проверка, что таблица существует
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Сначала составьте таблицу!", "Ошибка");
                return;
            }
            // Проверка на отсутствие пустых ячеек
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null)
                    {
                        MessageBox.Show("Сначала заполните таблицу!", "Ошибка");
                        return;
                    }
                }
            }
            if (matrix.Count != 0)
            {
                matrix.Clear();
            }
            if (result.Count != 0)
            {
                result.Clear();
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                List<int> row = new List<int>();
                matrix.Add(row);
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    matrix[i].Add(Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value));
                }
            }
            for (int i = 0; i < matrix.Count; i++)
            {
                List<int> row = new List<int>();
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    row.Add(0);
                }
                result.Add(row);
            }

            int dvzn;
            dvzn = 0;

            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    if (matrix[i][j] >= 10 & matrix[i][j] <= 99)
                    {
                       dvzn++;
                    }
                }
            }
            string sdvzn = dvzn.ToString();
            textBox3.Text = sdvzn;
        }

        private void cell_value_validate(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (!int.TryParse(e.FormattedValue.ToString(), out var check))
            {
                MessageBox.Show("Вводите целые числа!", "Ошибка");
                e.Cancel = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = random.Next(0, 999);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
