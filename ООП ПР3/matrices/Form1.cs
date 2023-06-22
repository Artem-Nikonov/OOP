using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrices
{
    public partial class Form1 : Form
    {
        //int col1;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void apply1_Click(object sender, EventArgs e) //генирация строк и столбцов для 1 матрицы
        {
            int row = 0;
            int col = 0;
            if (!int.TryParse(textBox1.Text, out row) || !int.TryParse(textBox2.Text, out col) || row < 1 || col < 1)
                MessageBox.Show("Значение строк или столбцов первой матрицы  введено неверно!");
            else
            {
                dataGridView1.RowCount = row;
                dataGridView1.ColumnCount = col;
                dataGridView2.RowCount = 0;
                dataGridView2.ColumnCount = 0;
            }
            
        }

        private void Apply2_Click(object sender, EventArgs e) //генирация строк и столбцов для 2 матрицы
        {
            int row = 0;
            int col = 0;
            if (!int.TryParse(textBox3.Text, out row) || !int.TryParse(textBox4.Text, out col) || row < 1 || col < 1)
                MessageBox.Show("Значение строк или столбцов второй матрицы введено неверно!");
            else
            {
                try
                {
                    if (row == dataGridView1.ColumnCount)
                    {
                        dataGridView2.RowCount = row;
                        dataGridView2.ColumnCount = col;
                    }
                    else throw new ArgumentException("Количество столбцов в первой матрице дожно совпадать с количеством строк во второй.");
                }
                catch(ArgumentException exc)
                {
                    MessageBox.Show(exc.Message);
                }
                
            }

        }

        private void GetResult_Click(object sender, EventArgs e) //перемножение матриц
        {
            dataGridViewRes.RowCount = dataGridView1.RowCount;
            dataGridViewRes.ColumnCount = dataGridView2.ColumnCount;

            for (int i=0; i< dataGridView1.RowCount; i++)
            {
                for(int j=0; j<dataGridView2.ColumnCount; j++)
                {
                    double res=0;
                    for (int n=0; n<dataGridView1.ColumnCount; n++)
                    {
                        try
                        {
                            if (Convert.ToDouble(dataGridView1.Rows[i].Cells[n].Value) < 0)
                                throw new ArgumentException($"Элемент [{i},{n}] Матрицы 1 меньше 0.");
                            else if (Convert.ToDouble(dataGridView2.Rows[n].Cells[j].Value) < 0)
                                throw new ArgumentException($"Элемент [{n},{j}] Матрицы 2 меньше 0.");
                            else if (Convert.ToDouble(dataGridView1.Rows[i].Cells[n].Value) >= 0)
                                res += Convert.ToDouble(dataGridView1.Rows[i].Cells[n].Value) * Convert.ToDouble(dataGridView2.Rows[n].Cells[j].Value);
                        }
                        catch(ArgumentException exc)
                        {
                            MessageBox.Show(exc.Message);
                            return;
                        }
                        
                    }
                    dataGridViewRes.Rows[i].Cells[j].Value = res;
                }
                
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //рандомное заполнение 1 матрицы
        {
            Random rand = new Random();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToDouble(rand.Next(0, 1000)) / 10;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)//рандомное заполнение 2 матрицы
        {
            Random rand = new Random();
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = Convert.ToDouble(rand.Next(0, 1000)) / 10;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) //Очистка 1 матрицы
        {
            dataGridView1.RowCount= 0;
            dataGridView1.ColumnCount= 0;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) //Очистка 2 матрицы
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.RowCount = 0;
            dataGridView2.ColumnCount = 0;
        }


    }
    
}
