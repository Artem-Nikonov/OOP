using ComputerShop.DI;
using ComputerShop.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ComputerShop.App.Cmd
{

    internal partial class Program
    {
        #region DI - Внедрение зависимости
        private static Configuration _configuration;

        private static IComputer CreateComputer(string name, string firm, int price, int quantity)
        {
            var computer = _configuration.Container.GetInstance<IComputer>();
            computer.Firm = firm;
            computer.Name = name;
            computer.Price = price;
            computer.Quantity = quantity;

            var shop = _configuration.Container.GetInstance<IShop>();
            shop.Add(computer);

            return computer;
        }

        private static ICheck CreateCheck(IComputer computer)
        {
            var shop = _configuration.Container.GetInstance<IShop>();
            var check = shop.Sell(computer);

            return check;
        }


        private static IShop CreateShop(string name, string address)
        {
            var shop = _configuration.Container.GetInstance<IShop>();
            shop.Name = name;
            shop.Address = address;

            return shop;
        }

        private static IEnumerable<IComputer> GetAllComputers()
        {
            var shop = _configuration.Container.GetInstance<IShop>();
            var computers = shop.GetAllComputers();

            return computers;
        }

        private static IEnumerable<ICheck> GetAllChecks()
        {
            var shop = _configuration.Container.GetInstance<IShop>();
            var checks = shop.GetAllChecks();

            return checks;
        }

        private static void ResetDB()
        {
            var shop = _configuration.Container.GetInstance<IShop>();
            shop.ResetAll();
        }
        #endregion



        static void Main()
        {
            try
            {
                _configuration = new Configuration();

                var shop = CreateShop("CFUSHOP", "pr. Vernadskogo 4");

                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Добрый день. Добро пожаловать в панель управления магазином");
                Console.WriteLine("Пожалуйста, введите нужную команду или help для помощи");
                Console.WriteLine();

                while (true)
                {
                    switch (ReadCommand())
                    {
                        case Command.Exit:
                            Environment.Exit(0);
                            break;
                        case Command.Help:
                            WriteHelpMessage();
                            break;
                        case Command.AddComputer:
                            AddComputer();
                            break;
                        case Command.GetAllComputers:
                            ShowAllComputers();
                            break;
                        case Command.SellComputer:
                            SellComputer();
                            break;
                        case Command.GetReport:
                            GetReport();
                            break;
                        case Command.ResetAll:
                            ResetAll();
                            break;
                        default:
                            WriteErrorMessage("Не обрабатываемая команда. Свяжитесь с разработчиком");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }


        private static void AddComputer()
        {
            Console.WriteLine("Добавление нового компьютера:");

            var firm = ReadNotEmptyLine("Фирму");
            var name = ReadNotEmptyLine("Название устройства");
            var price = ReadIntLine("Стоимость устройства");
            var quantity = ReadIntLine("Количество единиц товара");

            var computer = CreateComputer(name, firm, price, quantity) ?? throw new Exception("Ошибка при добавлении компьютера");

            string message = $"Компьютер [{computer}] успешно добавлен";
            SetMessageColor(message, ConsoleColor.Green);
            Console.WriteLine();
        }

        private static void ShowAllComputers()
        {
            string message = "Список всех доступных в магазине компьютеров:";
            SetMessageColor(message, ConsoleColor.Green);

            var computers = GetAllComputers();
            foreach (var comp in computers)
            {
                Console.WriteLine($"{comp}");
            }
            Console.WriteLine();
        }

        private static void ShowAllAccessibleComputers()
        {
            string message = "Список доступных для продажи компьютеров:";
            SetMessageColor(message, ConsoleColor.Green);

            var computers = GetAllComputers();
            foreach (var comp in computers)
            {
                Console.WriteLine($"{comp}");
            }
            Console.WriteLine();
        }

        private static void GetReport()
        {
            SetMessageColor("История продаж:", ConsoleColor.Green);
            var checks = GetAllChecks().ToList();
            foreach (var check in checks)
            {
                Console.WriteLine($"{check}");
            }
            Console.WriteLine();
        }

        private static void SellComputer()
        {
            Console.WriteLine("Новая продажа компьютера");
            ShowAllAccessibleComputers();

            IComputer computer;
            while (true)
            {
                var name = ReadNotEmptyLine("Название компьютера");
                var computers = GetAllComputers();
                var result = computers.FirstOrDefault(b => b.Name.Equals(name));

                if (result != null)
                {
                    computer = result;
                    break;
                }
                if (name == "exit") return;
                WriteErrorMessage("Данный компьютер не найден");

            }

            var check = CreateCheck(computer);
            SetMessageColor($"Новая продажа в магазине {check.Shop.Name}", ConsoleColor.DarkYellow);
            SetMessageColor($"по адресу {check.Shop.Address}", ConsoleColor.DarkYellow);
            Console.WriteLine($"{check.DateTime}");
            Console.WriteLine($"Наименование товара: {check.Computer.Firm}\t{check.Computer.Name}");
            Console.WriteLine($"Стоимость: {check.Computer.Price}$");
            Console.WriteLine();
        }

        private static void ResetAll()
        {
            ResetDB();
            string message = "База данных успешно очищена.\n";
            SetMessageColor(message, ConsoleColor.Yellow);
        }
    }
            
                
}
