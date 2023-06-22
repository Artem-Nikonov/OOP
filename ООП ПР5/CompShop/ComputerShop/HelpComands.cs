using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop.App.Cmd
{
    partial class Program
    {
        private static string ReadNotEmptyLine(string title)
        {
            while (true)
            {
                Console.Write($"Введите {title}: ");
                var input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input;
                }

                WriteErrorMessage($"Значение {title} не должен быть пустым");
            }
        }

        private static int ReadIntLine(string title)
        {
            while (true)
            {
                var input = ReadNotEmptyLine(title);
                if (int.TryParse(input, out int result) && result > 0)
                {
                    return Math.Abs(result);
                }

                WriteErrorMessage($"Введите целое положительное число");
            }
        }

        private static void WriteErrorMessage(string message)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"ОШИБКА! {message}");
            Console.ForegroundColor = color;
        }

        private static Command ReadCommand()
        {
            while (true)
            {
                var input = ReadNotEmptyLine("команду");
                if (Enum.TryParse(input, true, out Command command))
                {
                    return command;
                }

                WriteErrorMessage("Не известная команда. Введите help для подсказки");
            }
        }

        private static void WriteHelpMessage()
        {
            Console.WriteLine($"{Command.AddComputer} - Добавить новый компьютер;");
            Console.WriteLine($"{Command.GetAllComputers} - Вывести полный список доступных компьютеров;");
            Console.WriteLine($"{Command.SellComputer} - Продать компьютер;");
            Console.WriteLine($"{Command.ResetAll}- удаление всех товаров и очистка истории продаж;");
            Console.WriteLine($"{Command.GetReport}- Вывести историю продаж");
            Console.WriteLine($"{Command.Exit} - Выход из приложения;");
            Console.WriteLine($"{Command.Help} - Помощь;");
            Console.WriteLine();
        }

        private static void SetMessageColor(string message, ConsoleColor color)
        {
            var FirstColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = FirstColor;
        }
    }
}
