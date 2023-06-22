using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Переполнение
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 2147483647;
            int b = 2;

            try
            {
                checked { a *= b; }
                label3.Text = (a).ToString();
            }
            catch(OverflowException exc)
            {
                label3.Text = exc.Message.ToString();
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 2147483647;
            int b = 2;
            try
            {
                unchecked { a*= b; }
                label4.Text = (a).ToString();
            }
            catch (OverflowException exc)
            {
                label4.Text = exc.Message.ToString();
            }
        }
    }
}
