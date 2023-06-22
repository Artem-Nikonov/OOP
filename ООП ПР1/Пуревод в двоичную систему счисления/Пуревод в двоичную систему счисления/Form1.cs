using System.Text;

namespace Пуревод_в_двоичную_систему_счисления
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ToBin_Click(object sender, EventArgs e)
        {
            int i;
            int remain=0;
            StringBuilder binary = new StringBuilder();

            if (!int.TryParse(textBox1.Text, out i))
            {
                MessageBox.Show("Введите целое число!");
            }

            if (i >= 0)
            {
                do
                {
                    remain = i % 2;
                    i /= 2;
                    binary.Insert(0, remain);
                } while (i > 0);

                textBox2.Text = binary.ToString();
            }
            else
                MessageBox.Show("Введите неотрицательне число!");

        }
    }
}