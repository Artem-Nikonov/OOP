using System.Text;

namespace Системы_счисление
{
    public partial class ConvertFrom : Form
    {
        public ConvertFrom()
        {
            InitializeComponent();
        }

        private void ParsCheck(ref int a, TextBox tb) // Парсим текстбоксы с системами счисления(СС)
        {
            if (!int.TryParse(tb.Text, out a))
            {
                MessageBox.Show("Введите систему счисления от 2 до 16!");
            }
            else if (a < 2 | a > 16) // если введенная СС меньше двух или блольше 16, автоматически задаём СС-2
            {
                MessageBox.Show("Вы ввели слищком большое или слишком маленькое значение системы счисления.");
                a = 2;
                tb.Text=a.ToString();
            }
        }


        private enum alphabet // Алфавит для систем счисления, больших 10
        {
            A=10, B=11, C=12,
            D=13, E=14, F=15,
        }

        private int ConvertToDec(string number, int number_system) //переводим число из заданной сс в десятичную.
        {
            int figure;
            int result = 0;
            uint pow = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                if (!int.TryParse(number[i].ToString(), out figure)) // парсим посимвольно введённое число (строку).
                {
                    figure = number[i] switch //Если отпарсить не получается,ищим символ в алфавите и берём числовое значение
                    {                        //символа из алфавита.
                        'A' => (int)alphabet.A,
                        'B' => (int)alphabet.B,
                        'C' => (int)alphabet.C,
                        'D' => (int)alphabet.D,
                        'E' => (int)alphabet.E,
                        'F' => (int)alphabet.F,
                        _ => -1 //Если  символ не найден, присваиваем figure значение -1 (будем считать, что -1 значит, что число задано неверно)
                    };
                }
                if (figure == -1 | figure >= number_system) //Если число было задано неверно, или символ не меньше сс значит выдаём ошибку 
                {
                    MessageBox.Show("Введенные вами символы не содержатся заданной системе счисления.");
                    return -1;
                }
                    
                else
                {
                    result +=(int)(figure * Math.Pow(number_system, pow)); //переводим в десятичную сс
                    pow++;
                }
            }
            return result;
        }
    

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            int number=1; //число
            int initial_system=2; //сс из которой надо перевести 
            int final_system=2; // сс в которую надо перевести

            // парсим введённые сс с помощью определённого выше метода
            ParsCheck(ref initial_system, ConvFrom); 
            ParsCheck(ref final_system, ConvTo);

            //если отпарсить не получилось, метод зпвершает работу
            if (initial_system == 0 | final_system == 0) 
                return;

            //Если удалось перевести число в десятичную сс, то запоминаем полученное число, чтобы перевести его в заданную конечную сс
            if (ConvertToDec(Number.Text, initial_system) != -1)
            {
                number = ConvertToDec(Number.Text, initial_system);
                if(final_system == 10) //если конечная сс 10, то работу метода можно за вершать
                {
                    Result.Text = number.ToString();
                    return;
                }
            }
            else
            {
                Result.Text = "Ошибка";
                return;
            }


            // переводим число из 10 сс в заданную конечную сс
            StringBuilder result= new StringBuilder();
            int ost;
            do
            {
                ost = number % final_system;
                number /= final_system;
                if (ost < 9)
                    result.Insert(0, ost);
                else
                    result.Insert(0, (alphabet)ost);
            } 
            while(number>0);
            
            Result.Text= result.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ConvertFrom_Load(object sender, EventArgs e)
        {

        }
    }
}