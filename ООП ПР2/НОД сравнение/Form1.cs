﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace НОД_равнение
{
    
    public partial class Form1 : Form
    {
        static public int FindGCDStein(int u, int v, out long time)
        {

            time = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int k;
            // Step 1.
            // gcd(0, v) = v, because everything divides zero, 
            // and v is the largest number that divides v. 
            // Similarly, gcd(u, 0) = u. gcd(0, 0) is not typically 
            // defined, but it is convenient to set gcd(0, 0) = 0.
            if (u == 0 || v == 0)
            {
                sw.Stop();
                time = sw.ElapsedTicks;
                return u | v;
            } 
            // Step 2.
            // if u and v are both even, then gcd(u, v) = 2•gcd(u/2, v/2), 
            // because 2 is a common divisor. 
            for (k = 0; ((u | v) & 1) == 0; ++k)
            {
                u >>= 1;
                v >>= 1;
            }
            // Step 3.
            // if u is even and v is odd, then gcd(u, v) = gcd(u/2, v), 
            // because 2 is not a common divisor. 
            // Similarly, if u is odd and v is even, 
            // then gcd(u, v) = gcd(u, v/2). 

            while ((u & 1) == 0)
                u >>= 1;
            // Step 4.
            // if u and v are both odd, and u ≥ v, 
            // then gcd(u, v) = gcd((u − v)/2, v). 
            // If both are odd and u < v, then gcd(u, v) = gcd((v − u)/2, u). 
            // These are combinations of one step of the simple 
            // Euclidean algorithm, 
            // which uses subtraction at each step, and an application 
            // of step 3 above. 
            // The division by 2 results in an integer because the 
            // difference of two odd numbers is even.
            do
            {
                while ((v & 1) == 0)  // Loop x
                    v >>= 1;
                // Now u and v are both odd, so diff(u, v) is even.
                //   Let u = min(u, v), v = diff(u, v)/2. 
                if (u < v)
                {
                    v -= u;
                }
                else
                {
                    int diff = u - v;
                    u = v;
                    v = diff;
                }
                v >>= 1;
                // Step 5.
                // Repeat steps 3–4 until u = v, or (one more step) 
                // until u = 0.
                // In either case, the result is (2^k) * v, where k is 
                // the number of common factors of 2 found in step 2. 
            } while (v != 0);
            u <<= k;
            sw.Stop();
            time = sw.ElapsedTicks;
            return u;
        }

        public static int NOD(int a, int b, out long time)//метод Евклида
        {
            time = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();
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
            sw.Stop();
            time = sw.ElapsedTicks;
            return a;
            
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        int a = 0;
        int b = 0;
        private void Evklid_Click(object sender, EventArgs e)
        {
            long time;
            if (!int.TryParse(FirstNumber.Text, out a) | !int.TryParse(SecondNumber.Text, out b))
                MessageBox.Show("Введены некорректные числа");
            label1.Text =($"НОД: {NOD(a, b, out time)}\nВремя:{time}");
        }

        private void Stein_Click(object sender, EventArgs e)
        {
            long time;
            if (!int.TryParse(FirstNumber.Text, out a) | !int.TryParse(SecondNumber.Text, out b))
                MessageBox.Show("Введены некорректные числа");
            label2.Text = ($"НОД: {FindGCDStein(a, b, out time)}\nВремя:{time}");
        }
    }
}
