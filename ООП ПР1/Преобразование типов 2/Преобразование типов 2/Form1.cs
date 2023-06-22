using System.Diagnostics.Metrics;
using System.Reflection;
using System.Windows.Forms;

namespace Преобразование_типов_2
{
    public partial class Form1 : Form
    {


        dynamic number = 0;

        //ВЫВОД В ТЕКСТОВОЕ ПОЛЕ ТИПА ВХОДЯЩЕЙ ПЕРЕМЕННОЙ (для удобства)
        public void TypeOut()
        {
            label1.Text = ($"Тип: {(number.GetType()).ToString()}");
        }


        public Form1()
        {
            InitializeComponent();
        }


        //ПАРСИНГ ВХОДЯЩЕГО ЗНАЧЕНИЯ
        private void AsSbyte_Click(object sender, EventArgs e)
        {
            sbyte a;
            if (!SByte.TryParse(textBox1.Text, out a))
                MessageBox.Show("Значение переменной введено неверно!");
            else
                number = a; // ПРИСВОЕНИЕ dynamic ПЕРЕМЕННОЙ ВХОДЯЩЕГО ЗНАЧЕНИЯ ВЫБРАННОГО ТИПА

            TypeOut();
        }

        private void AsByte_Click(object sender, EventArgs e)
        {
            byte a;
            if (!Byte.TryParse(textBox1.Text, out a))
                MessageBox.Show("Значение переменной введено неверно!");
            else
                number = a;

            TypeOut();
        }

        private void AsShort_Click(object sender, EventArgs e)
        {
            short a;
            if (!Int16.TryParse(textBox1.Text, out a))
                MessageBox.Show("Значение переменной введено неверно!");
            else
                number = a;

            TypeOut();
        }

        private void AsUshort_Click(object sender, EventArgs e)
        {
            ushort a;
            if (!UInt16.TryParse(textBox1.Text, out a))
                MessageBox.Show("Значение переменной введено неверно!");
            else
                number = a;

            TypeOut();
        }

        private void AsInt_Click(object sender, EventArgs e)
        {
            int a;
            if (!Int32.TryParse(textBox1.Text, out a))
                MessageBox.Show("Значение переменной введено неверно!");
            else
                number = a;

            TypeOut();
        }

        private void AsUint_Click(object sender, EventArgs e)
        {
            uint a;
            if (!UInt32.TryParse(textBox1.Text, out a))
                MessageBox.Show("Значение переменной введено неверно!");
            else
                number = a;

            TypeOut();
        }

        private void AsLong_Click(object sender, EventArgs e)
        {
            long a;
            if (!Int64.TryParse(textBox1.Text, out a))
                MessageBox.Show("Значение переменной введено неверно!");
            else
                number = a;

            TypeOut();
        }

        private void AsUlong_Click(object sender, EventArgs e)
        {
            ulong a;
            if (!UInt64.TryParse(textBox1.Text, out a))
                MessageBox.Show("Значение переменной введено неверно!");
            else
                number = a;

            TypeOut();
        }

        private void AsChar_Click(object sender, EventArgs e)
        {
            char a;
            if (!Char.TryParse(textBox1.Text, out a))
                MessageBox.Show("Значение переменной введено неверно!");
            else
                number = a;

            TypeOut();
        }

        private void AsFloat_Click(object sender, EventArgs e)
        {
            float a;
            if (!Single.TryParse(textBox1.Text, out a))
                MessageBox.Show("Значение переменной введено неверно!");
            else
                number = a;

            TypeOut();
        }

        private void AsDouble_Click(object sender, EventArgs e)
        {
            double a;
            if (!Double.TryParse(textBox1.Text, out a))
                MessageBox.Show("Значение переменной введено неверно!");
            else
                number = a;

            TypeOut();
        }

        private void AsDecimal_Click(object sender, EventArgs e)
        {
            decimal a;
            if (!Decimal.TryParse(textBox1.Text, out a))
                MessageBox.Show("Значение переменной введено неверно!");
            else
                number = a;

            TypeOut();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TypeOut();
        }


        //ВЫВОД ТИПА В КОТОРЫЙ ИДЕТ ПРЕОБРАЗОВАНИЕ
        public string ResultTypeOut<T>(T numb)
        {
            return($"Тип: {Convert.ToString(numb.GetType())}");
        }


        //ПРЕОБРАЗОВАНИЕ ВВЕДЕННОЙ ПЕРЕМЕННОЙ В ВЫБРАННЫЙ ТИП
        private void ToSbyte_Click(object sender, EventArgs e)
        {
            sbyte a;
            try
            {
                a = number;
                textBoxResult.Text = a.ToString();
                labelResult.Text = ($"{ResultTypeOut(a)}\nПреобразование: неявное");
            }
            catch 
            {
                
                a = (sbyte)number;
                textBoxResult.Text = a.ToString();
                labelResult.Text = ($"{ResultTypeOut(a)}\nПреобразование: явное\n");
            }

            //ПРОВЕРКА НА ПЕРЕПОЛНЕНИЕ
            checked
            {
                try { a = (sbyte)number; }
                catch (OverflowException) { labelResult.Text += ("OverflowException"); }

            }
        }

        private void ToByte_Click(object sender, EventArgs e)
        {
            byte a;
            try
            {
                a = number;
                textBoxResult.Text = a.ToString();
                labelResult.Text = ($"{ResultTypeOut(a)}\nПреобразование: неявное");
            }
            catch
            {
                unchecked
                {
                    a = (byte)number;
                }
                //a = (byte)number;
                textBoxResult.Text = a.ToString();
                labelResult.Text = ($"{ResultTypeOut(a)}\nПреобразование: явное\n");
            }
            checked
            {
                try { a = (byte)number; }
                catch (OverflowException) { labelResult.Text += ("OverflowException"); }

            }
        }

        private void ToShort_Click(object sender, EventArgs e)
        {
            short a;
            try
            {
                a = number;
                textBoxResult.Text = a.ToString();
                labelResult.Text = ($"{ResultTypeOut(a)}\nПреобразование: неявное");
            }
            catch
            {
                a = (short)number;
                textBoxResult.Text = a.ToString();
                labelResult.Text = ($"{ResultTypeOut(a)}\nПреобразование: явное\n");
            }
            checked
            {
                try { a = (short)number; }
                catch (OverflowException) { labelResult.Text += ("OverflowException"); }

            }
        }

        private void ToUshort_Click(object sender, EventArgs e)
        {
            ushort a;
            try
            {
                a = number;
                textBoxResult.Text = a.ToString();
                labelResult.Text = ($"{ResultTypeOut(a)}\nПреобразование: неявное");
            }
            catch
            {
                a = (ushort)number;
                textBoxResult.Text = a.ToString();
                labelResult.Text = ($"{ResultTypeOut(a)}\nПреобразование: явное\n");
            }
            checked
            {
                try { a = (ushort)number; }
                catch (OverflowException) { labelResult.Text += ("OverflowException"); }

            }
        }

        private void ToInt_Click(object sender, EventArgs e)
        {
            int a;
            try
            {
                a = number;
                textBoxResult.Text = a.ToString();
                labelResult.Text = ($"{ResultTypeOut(a)}\nПреобразование: неявное");
            }
            catch
            {
                a = (int)number;
                textBoxResult.Text = a.ToString();
                labelResult.Text = ($"{ResultTypeOut(a)}\nПреобразование: явное\n");
            }
            checked
            {
                try { a = (int)number; }
                catch (OverflowException) { labelResult.Text += ("OverflowException"); }

            }
        }

        private void ToUint_Click(object sender, EventArgs e)
        {
            uint a;
            try
            {
                a = number;
                textBoxResult.Text = a.ToString();
                labelResult.Text = ($"{ResultTypeOut(a)}\nПреобразование: неявное");
            }
            catch
            {
                a = (uint)number;
                textBoxResult.Text = a.ToString();
                labelResult.Text = ($"{ResultTypeOut(a)}\nПреобразование: явное\n");
            }
            checked
            {
                try { a = (uint)number; }
                catch (OverflowException) { labelResult.Text += ("OverflowException"); }

            }
        }

        private void ToLong_Click(object sender, EventArgs e)
        {
            long a;
            try
            {
                a = number;
                textBoxResult.Text = a.ToString();
                labelResult.Text = ($"{ResultTypeOut(a)}\nПреобразование: неявное");
            }
            catch
            {
                a = (long)number;
                textBoxResult.Text = a.ToString();
                labelResult.Text = ($"{ResultTypeOut(a)}\nПреобразование: явное\n");
            }
            checked
            {
                try { a = (long)number; }
                catch (OverflowException) { labelResult.Text += ("OverflowException"); }

            }
        }

        private void ToUlong_Click(object sender, EventArgs e)
        {
            ulong a;
            try
            {
                a = number;
                textBoxResult.Text = a.ToString();
                labelResult.Text = ($"{ResultTypeOut(a)}\nПреобразование: неявное");
            }
            catch
            {
                a = (ulong)number;
                textBoxResult.Text = a.ToString();
                labelResult.Text = ($"{ResultTypeOut(a)}\nПреобразование: явное\n");
            }
            checked
            {
                try { a = (ulong)number; }
                catch (OverflowException) { labelResult.Text += ("OverflowException"); }

            }
        }

        private void ToChar_Click(object sender, EventArgs e)
        {
            char a;
            try
            {
                a = number;
                textBoxResult.Text = a.ToString();
                labelResult.Text = ($"{ResultTypeOut(a)}\nПреобразование: неявное");
            }
            catch
            {
                a = (char)number;
                textBoxResult.Text = a.ToString();
                labelResult.Text = ($"{ResultTypeOut(a)}\nПреобразование: явное\n");
            }
            checked
            {
                try { a = (char)number; }
                catch (OverflowException) { labelResult.Text += ("OverflowException"); }

            }
        }

        private void ToFloat_Click(object sender, EventArgs e)
        {
            float a;
            try
            {
                a = number;
                textBoxResult.Text = a.ToString();
                labelResult.Text = ($"{ResultTypeOut(a)}\nПреобразование: неявное");
            }
            catch
            {
                a = (Single)number;
                textBoxResult.Text = a.ToString();
                labelResult.Text = ($"{ResultTypeOut(a)}\nПреобразование: явное\n");
            }
            checked
            {
                try { a = (Single)number; }
                catch (OverflowException) { labelResult.Text += ("OverflowException"); }

            }
        }

        private void ToDouble_Click(object sender, EventArgs e)
        {
            double a;
            try
            {
                a = number;
                textBoxResult.Text = a.ToString();
                labelResult.Text = ($"{ResultTypeOut(a)}\nПреобразование: неявное");
            }
            catch
            {
                a = (double)number;
                textBoxResult.Text = a.ToString();
                labelResult.Text = ($"{ResultTypeOut(a)}\nПреобразование: явное\n");
            }
            checked
            {
                try { a = (double)number; }
                catch (OverflowException) { labelResult.Text += ("OverflowException"); }

            }
        }

        private void ToDecimal_Click(object sender, EventArgs e)
        {
            decimal a;
            try
            {
                a = number;
                textBoxResult.Text = a.ToString();
                labelResult.Text = ($"{ResultTypeOut(a)}\nПреобразование: неявное");
            }
            catch
            {
                a = (decimal)number;
                textBoxResult.Text = a.ToString();
                labelResult.Text = ($"{ResultTypeOut(a)}\nПреобразование: явное\n");
            }
            checked
            {
                try { a = (decimal)number; }
                catch (OverflowException) { labelResult.Text += ("OverflowException"); }

            }
        }



        //Классы и метод для проверки работы ключевых слов as и is
        class human//класс "человек"
        {
            protected int age;
            protected string surname;
            public string GetHumanInfo()
            {
                return ($"Фамилия: {surname} Возраст:{age}");
            }
        }

        class student:human//класс "студент"
        {
            private int group;
            private float score;
            public student(int age, string surname, int group, float score)
            {
                this.age = age;
                this.surname = surname;
                this.group = group;
                this.score = score;
            }


        }

        class dog//класс "собака"
        {
            private int age { get; set; }
            private string breed { get; set; }

            public dog(int age, string breed)
            {
                this.age = age;
                this.breed = breed;
            }
        }


        //Метод, использующий ключевые слова as и is, который выводит информацию о человеке 
        public void GetInfo(object obj)
        {
            //AS
            human human1 = obj as human;
            if (human1 != null)
            {
                label3.Text += ($"{human1.GetHumanInfo()} (приведение с помощью as)\n");

            }
            else
            {
                label3.Text += ($"Данный объект не является человеком (приведение с помощью as)\n");

            }

            //IS
            if (obj is human human2)
            {
                label3.Text += ($"{human2.GetHumanInfo()} (приведение с помощью is)\n");

            }
            else
            {
                label3.Text += ($"Данный объект не является человеком (приведение с помощью is)\n");
            }
        }


        // создание объектов класса student и dog и вызов метода GetInfo() 
        private void AsIs_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            student Vasya = new student(20, "Ivanov", 212, 4.7f);
            dog dog1 = new dog(2, "husky");

            label3.Text += ("Объект класса 'Student':\n ");
            GetInfo(Vasya);
            label3.Text += ("Объект класса 'Dog':\n");
            GetInfo(dog1);
        }


        //Пользовательское преобразование

        class Point
        {
            public int x;
            
            public static implicit operator Point(int p)
            {
                return new Point { x = p };
            }
            public static explicit operator int(Point point)
            {
                return point.x;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //explicit/ implicit
            Point point1 = new Point { x = 17 };
            label4.Text = ($"point1.x={point1.x}\n");
            int x = (int)point1;
            label4.Text += ($"int x = (int)point1 -> x={x} (explicit)\n");   

            Point point2 = x;
            label4.Text += ($"Point point2 = x -> point2.x={point2.x} (implicit)");
        }

  
    }
}
/*
НЕЯВНЫЕ ПРЕОБРАЗОВАНИЯ
FROM -> в
sbyte   short, int, long, float, double или decimal
byte    short, ushort, int, uint, long, float, double или decimal
short   int, long, float, double или decimal
ushort  int, uint, long, ulong, float, double или decimal
Int     long, float, double или decimal
uint    long, ulong, float, double или decimal
long    float, double или decimal
char    ushort, int, uint, long, ulong, float, double или decimal
float   double
ulong   float, double или decimal

ЯВНЫЕ ПРЕОБРАЗОВАНИЯ
FROM -> в
sbyte   byte, ushort, uint, ulong или char
byte    Sbyte или char
short   sbyte, byte, ushort, uint, ulong или char
ushort  sbyte, byte, short или char
int     sbyte, byte, short, ushort, uint, ulong или char
uint    sbyte, byte, short, ushort, int или char
long    sbyte, byte, short, ushort, int, uint, ulong или char
ulong   sbyte, byte, short, ushort, int, uint, long или char
char    sbyte, byte или short
float   sbyte, byte, short, ushort, int, uint, long, ulong, char или decimal
double  sbyte, byte, short, ushort, int, uint, long, ulong, char, float илиdecimal
decimal sbyte, byte, short, ushort, int, uint, long, ulong, char, float или double

*/
