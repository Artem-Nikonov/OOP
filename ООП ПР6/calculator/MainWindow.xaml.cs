using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace calculator
{

    public  enum  Operations {Add, Substract, Multyply, Division}
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Calculator calculator = new Calculator();

        public MainWindow()
        {
            InitializeComponent();
            
            OperationsBox.Items.Add(Operations.Add);
            OperationsBox.Items.Add(Operations.Substract);
            OperationsBox.Items.Add(Operations.Multyply);
            OperationsBox.Items.Add(Operations.Division);
            resHistory.Items.Add($"Время\tОперация\tРезультат");

            calculator.CalculatorEvent += CalculatorEvent;

        }

       
        private void CalculatorEvent(object sender, CalculatorEventArgs e)
        {
            string time = e.time;
            double result = e.result; 
            Operations operation = e.operation;
            resHistory.Items.Add($"{time}\t{operation}\t{result}");
        }

        private void AsincOperation(double result, string time, Operations operation)
        {
            resHistory.Items.Add($"{time}\t{operation}\t{result}");
            MessageBox.Show($"Операция {operation}, запущенная в {time} успешно завершена.");
        }

        private void ClculateButton_Click(object sender, RoutedEventArgs e)
        {
            double a, b;

            if(!double.TryParse(number1.Text, out a) || !double.TryParse(number2.Text, out b))
            {
                MessageBox.Show("Введите числа корректно!");
                return;
            }

            switch (OperationsBox.SelectedItem)
            {
                case (Operations.Add):
                    calculator.AddOperation(a, b);
                    break;
                case (Operations.Substract):
                    calculator.SubstractOperation(a, b);
                    break;
                case (Operations.Multyply):
                    calculator.MultiplyAsyncOperation(a, b, Operations.Multyply, AsincOperation);
                    break;
                case (Operations.Division):
                    calculator.MultiplyAsyncOperation(a, b, Operations.Division, AsincOperation);
                    break;

            }
        }
    }
}
