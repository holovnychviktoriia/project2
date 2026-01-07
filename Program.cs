// Головнич Вікторія КН21
// Тема лабораторної роботи №2 - "Магазин побутової техніки"

using System;

namespace HomeAppliancesStore
{    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Магазин побутової техніки";
            ShowMenu();
        }
        static void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n--- ГОЛОВНЕ МЕНЮ ---");
            Console.ResetColor();
            Console.WriteLine("1. Перегляд товарів");
            Console.WriteLine("2. Розрахувати покупку");
            Console.WriteLine("3. Інформація про магазин");
            Console.WriteLine("4. Налаштування");
            Console.WriteLine("0. Вихід");
            Console.Write("Ваш вибір: ");

            int choice;
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Помилка: введено не число!");
                Console.ResetColor();
                ShowMenu();
                return;
            }

            switch (choice)
            {
                case 1:
                    ShowProducts();
                    break;
                case 2:
                    CalculatePurchase();
                    break;
                case 3:
                    ShowShopInfo();
                    break;
                case 4:
                    OpenSettings();
                    break;
                case 0:
                    Console.WriteLine("Вихід з програми...");
                    return; 
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Невірний вибір! Спробуйте ще раз.");
                    Console.ResetColor();
                    break;
            }

            ShowMenu();
        }

        static void ShowProducts()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n--- Наявні товари ---");
            Console.ResetColor();
            Console.WriteLine("1. Телевізор Samsung (15000 грн)");
            Console.WriteLine("2. Холодильник Bosch (22000 грн)");
            Console.WriteLine("3. Пральна машина LG (18500 грн)");
        }

        static void CalculatePurchase()
        {
            Console.WriteLine("\n--- Розрахунок покупки ---");
            
            double priceTv = 15000.00;
            double priceFridge = 22000.00;
            double priceWasher = 18500.00;

            try
            {
                Console.WriteLine("Введіть кількість телевізорів:");
                int countTv = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введіть кількість холодильників:");
                int countFridge = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введіть кількість пральних машин:");
                int countWasher = Convert.ToInt32(Console.ReadLine());

                double widthTv = 90; 
                double heightTv = 50; 
                double diagonal = Math.Sqrt(Math.Pow(widthTv, 2) + Math.Pow(heightTv, 2));

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Довідка: діагональ телевізорів = " + Math.Round(diagonal, 1) + " см");
                Console.ResetColor();

                double totalSum = (priceTv * countTv) + (priceFridge * countFridge) + (priceWasher * countWasher);

                Random rnd = new Random();
                int discountPercent = rnd.Next(1, 15);
                double discountAmount = totalSum * discountPercent / 100;
                double finalPrice = totalSum - discountAmount;

                Console.WriteLine("------------------------------");
                Console.WriteLine("Сума без знижки: " + totalSum + " грн");
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Знижка (" + discountPercent + "%): " + Math.Round(discountAmount, 2) + " грн");
                Console.WriteLine("ДО СПЛАТИ: " + Math.Round(finalPrice, 2) + " грн");
                Console.ResetColor();
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Помилка: введено некоректне значення кількості!");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Сталася помилка: " + ex.Message);
            }
        }
        static void ShowShopInfo()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nФункція 'Інформація про магазин' знаходиться в розробці...");
            Console.ResetColor();
        }
        static void OpenSettings()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nФункція 'Налаштування' знаходиться в розробці...");
            Console.ResetColor();
        }
    }
}