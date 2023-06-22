namespace Корень
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double squareRoot; // Вычисление корня Math.sqrt()
        decimal numberDecimal;// Вычисление корня методом Ньютона 
        decimal delta = (decimal) Math.Pow(10, -28);// Переменная для проверки точности
        decimal guess=1;//предположение
        decimal result;
        //bool first_iter;//проверка на первую итерацию(для того чтобы определьть начальное предположение и ркзультат)
        int IterOfNewton;

        private void button1_Click(object sender, EventArgs e) // Вычисление корня Math.sqrt()
        {
            label1.Text = Math.Sqrt(squareRoot).ToString();       
        }

        private void Apply_Click(object sender, EventArgs e) //пытаемся отперсить введенное значение корня
        {
            if ((!double.TryParse(textBox1.Text, out squareRoot)) || (!decimal.TryParse(textBox1.Text, out numberDecimal)))
            {
                MessageBox.Show("Введите десятичную дробь!");
            }
            else if (squareRoot < 0) //проверяем, чтобы введённое значение было не меньше 0 
            {
                MessageBox.Show("Введите положительное число!");
            }
            else //очищаем текстовые поля
            {
                label1.Text = null;
                label2.Text = null;
                label3.Text = null;
                IterOfNewton = 0;
            }
        }

        private void Newton_Click(object sender, EventArgs e) // вычисляем корень методом Ньютона
        {
            label3.Text = null;
            guess = numberDecimal / 2; //задаём изначальное предположеие
            result = guess > 0 ? (((numberDecimal / guess) + guess) / 2) : 0; //считаем первый результат
            while (Math.Abs(guess - result) > delta)
            {
                guess = result;
                result = guess > 0 ? (((numberDecimal / guess) + guess) / 2) : 0;  
            }
            label2.Text = result.ToString();
            IterOfNewton = 0;
        }

        
        private void button2_Click(object sender, EventArgs e) // вычисляем корень методом Ньютона по итерациям
        {
            if (IterOfNewton == 0)
            {
                guess = numberDecimal / 2;
                result = guess > 0 ? (((numberDecimal / guess) + guess) / 2) : 0;
                IterOfNewton++;
                goto Print;
            }

            guess = result;
            result = guess > 0 ? (((numberDecimal / guess) + guess) / 2) : 0;
            if (Math.Abs(result - guess) > delta)
                IterOfNewton++;
            else
            {
                label3.Text = "Достигнута максимальная точночть.";
                IterOfNewton = 0;
                return;
            }

            Print:
            label2.Text = result.ToString();
            label3.Text = ($"Итераций: {IterOfNewton}\nПогрешность: {Math.Abs((decimal)Math.Sqrt(squareRoot) - result)}");

        }
    }
}