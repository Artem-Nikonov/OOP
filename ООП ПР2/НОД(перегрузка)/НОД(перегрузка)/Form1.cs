using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace НОД_перегрузка_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }
        /*enum QuantityOfNumbers {Three, Four, Five, More };
        QuantityOfNumbers quantity;
        private void QuantityCheck()
        {
            switch (quantity)
            {
                case QuantityOfNumbers.Three:
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    break;
                case QuantityOfNumbers.Four:
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = false;
                    break;
                case QuantityOfNumbers.Five:
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    break;
                case QuantityOfNumbers.More:
                    textBox2.Visible = false;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    break;
            }
        }

        private void ThreeNumbers_CheckedChanged(object sender, EventArgs e)
        {
            quantity= QuantityOfNumbers.Three;
            QuantityCheck();
        }

        private void FourNumbers_CheckedChanged(object sender, EventArgs e)
        {
            quantity = QuantityOfNumbers.Four;
            QuantityCheck();
        }

        private void FiveNumbers_CheckedChanged(object sender, EventArgs e)
        {
            quantity = QuantityOfNumbers.Five;
            QuantityCheck();
        }

        private void MoreNumbers_CheckedChanged(object sender, EventArgs e)
        {
            quantity = QuantityOfNumbers.More;
            QuantityCheck();
        }*/


        public static int NOD(int a, int b) //метод Евклида для 2 чисел
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            if (a == 0) return b;
            while (b != 0)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }
        
        public static int NOD(int a, int b, int c) //метод Евклида для 3 чисел
        {
            return NOD(NOD(a, b), c);
        }

        public static int NOD(int a, int b, int c, int d) //метод Евклида для 4 чисел
        {
            return NOD(NOD(a, b, c), d);
        }

        public static int NOD(int a, int b, int c, int d, int e) //метод Евклида для 5 чисел
        {
            return NOD(NOD(a, b, c, d), e);
        }

        public static int NOD(params int[] numbers) // метод Евклида для n чисел
        {
            if (numbers.Length == 1)
                return numbers[0];

            int b = numbers[numbers.Length-1];
            Array.Resize(ref numbers, numbers.Length - 1);
            return NOD(b, NOD(numbers));
        }

        int a, b, c, d, f;

        private void MoreNumbers_Click(object sender, EventArgs e)
        {
            string[] str_numbers = textBox6.Text.Split(' ');
            int[] numbers= new int[str_numbers.Length];

            for (int i = 0; i < numbers.Length; i++){
                if (!int.TryParse(str_numbers[i].ToString(), out numbers[i]))
                {
                    MessageBox.Show($"{i + 1} число введено неверно!");
                    return;
                }
                else
                    numbers[i] = Math.Abs(numbers[i]);
            }

            Result2.Text = NOD(numbers).ToString();

        }


        private bool StarterCheckParse()
        {
            if (!int.TryParse(textBox1.Text, out a) | !int.TryParse(textBox2.Text, out b) | !int.TryParse(textBox3.Text, out c))
            {
                MessageBox.Show("Введены некорректные числа.");
                return false;
            }
            else
                return true;
               
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (StarterCheckParse())
                Result.Text = NOD(a, b, c).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!StarterCheckParse() | !int.TryParse(textBox4.Text, out d))
                MessageBox.Show("Введены некорректные числа.");
            else
            Result.Text = NOD(a, b, c, d).ToString();
    
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!StarterCheckParse() | !int.TryParse(textBox4.Text, out d) | !int.TryParse(textBox5.Text, out f))
                MessageBox.Show("Введены некорректные числа.");
            else
                Result.Text = NOD(a, b, c, d, f).ToString();

        }
    }

   
}
