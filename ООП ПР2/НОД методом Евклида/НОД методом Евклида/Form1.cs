using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace НОД_методом_Евклида
{
    
    public partial class Form1 : Form
    {
        public static int NOD(int a, int b) //метод Евклида
        {
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int a;
            int b;

            if (!int.TryParse(FirstNumber.Text, out a))
                MessageBox.Show("Введите целое число.");
            else
                a = Math.Abs(a);

            if (!int.TryParse(SecondNumber.Text, out b))
                MessageBox.Show("Введите целое число.");
            else
                b = Math.Abs(b);

            Result.Text = (NOD(a, b)).ToString();
        }
    }
}
//a=33 b =9
//a=24; a=15; a=6;
//b=9-6 b=3