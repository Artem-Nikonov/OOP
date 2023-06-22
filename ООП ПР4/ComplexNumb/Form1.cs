namespace ComplexNumb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        readonly struct ComplexNumber
        {
            public double a { get; init; }
            public double i { get; init; }

            public ComplexNumber(double A, double I)
            {
                this.a = A;
                this.i = I;
            }
            public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
            {
                ComplexNumber res = new ComplexNumber {a = a.a + b.a, i = a.i + b.i};
                return res;
            }
            public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
            {
                ComplexNumber res = new ComplexNumber { a = a.a - b.a, i = a.i - b.i };
                return res;
            }
            public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
            {
                ComplexNumber res = new ComplexNumber { a = a.a * b.a, i = a.i * b.i };
                return res;
            }


            public static bool operator ==(ComplexNumber a, ComplexNumber b) => a.a == b.a && a.i == b.i;
            
            public static bool operator !=(ComplexNumber a, ComplexNumber b) => a.a != b.a || a.i != b.i;


            //private double mod;
            public double Mod
            {
                get { return Math.Sqrt(a * a - i * i); }
            }

            public string ToString()
            {
                return i < 0 ? ($" {a} {i}i") : ($" {a} + {i}i"); 
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("==");
            comboBox1.Items.Add("mod");
            comboBox1.SelectedItem = "+";
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            operation = comboBox1.SelectedItem.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        string? operation = "+";
        private void button1_Click(object sender, EventArgs e)
        {
            double a1 = 1;
            double i1 = 1;
            double a2 = 1;
            double i2 = 1;

            if (!Double.TryParse(A1.Text, out a1) || !Double.TryParse(I1.Text, out i1))
            {
                MessageBox.Show("Первое число введено неверною");
                return;
            }
            ComplexNumber n1 = new ComplexNumber(a1, i1);
            
            if (!Double.TryParse(A2.Text, out a2) || !Double.TryParse(I2.Text, out i2))
            {
                MessageBox.Show("Второе число введено неверною");
                return;
            }
            ComplexNumber n2 = new ComplexNumber(a2, i2);
            
            res.Text = operation switch
            {
                "+" => res.Text = ((n1 + n2).ToString()),
                "-" => res.Text = ((n1 - n2).ToString()),
                "*" => res.Text = ((n1 * n2).ToString()),
                "==" => res.Text = ((n1 == n2).ToString()),
                "mod" => res.Text = ($"{(n1.Mod).ToString()}; {(n2.Mod).ToString()}"),
                _=>"Error"
            };
            
        }
        
    }
}