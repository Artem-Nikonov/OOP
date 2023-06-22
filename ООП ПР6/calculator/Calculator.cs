using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace calculator
{
    public class CalculatorEventArgs : EventArgs
    {
        public Operations operation { get; }
        public double result { get; }
        public string time { get; private set; }
        

        public CalculatorEventArgs(double result, Operations operation)
        {
            this.result = result;
            this.operation = operation;
            time = DateAndTime.TimeString;
        }
    }



    internal class Calculator
    {
        public event EventHandler<CalculatorEventArgs>? CalculatorEvent;
        
        private void InvokeEven(Object sender, CalculatorEventArgs e) => CalculatorEvent?.Invoke(sender, e);

        public void AddOperation(double a,double b)
        {
            double res = a + b;
            InvokeEven(this, new CalculatorEventArgs(res, Operations.Add));
        }

        public void SubstractOperation(double a, double b)
        {
            double res = a - b;
            InvokeEven(this, new CalculatorEventArgs(res, Operations.Substract));
        }

        private double MultyplyOperation(double a, double b)
        {
            Thread.Sleep(10000);
            double res = a * b;
            return res;
        }

        private double DevisionOperation(double a, double b)
        {
            Thread.Sleep(7000);
            double res;
            try
            {
                res = a / b;
            }
            catch (DivideByZeroException)
            {
                res = 0;
            }
            return res;
        }

        public async void MultiplyAsyncOperation(double a, double b, Operations operation, Action<double, string, Operations> callbackf)
        {
            double res = 0;
            string time = DateAndTime.TimeString;
            //Operations operation = Operations.Multyply;
            if (operation == Operations.Multyply)
            {
                res = await Task.Run(() => MultyplyOperation(a, b));
            }
            else if (operation == Operations.Division)
            {
                res = await Task.Run(() => DevisionOperation(a, b));
            }
            callbackf(res, time, operation);
            //InvokeEven(this, new CalculatorEventArgs(res, Operations.Multyply));
            //System.Windows.Application.Current.Dispatcher.Invoke(() => callbackf(res, time, operation));

        }
    }
}