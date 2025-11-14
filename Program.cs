// Головнич Вікторія КН-21

using System;
namespace FarmerMarketApp
{
    class Program
    {
        private static readonly double priceApples = 15.50;
        private static readonly double priceMilk = 32.00;
        private static readonly double priceEggs = 65.00;

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            ShowMainMenu();
        }

        static void ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("================================================");
            Console.WriteLine("   Головне меню 'Фермерського магазину'");
            Console.WriteLine("================================================");
            Console.WriteLine("Оберіть опцію:");
            Console.WriteLine("1. Переглянути товари та ціни");
            Console.WriteLine("2. Розрахувати нову покупку");
            Console.WriteLine("3. Інформація про магазин");
            Console.WriteLine("4. Налаштування");
            Console.WriteLine("0. Вихід з програми");
            Console.Write("Ваш вибір: ");

            string input = Console.ReadLine()!;
            int choice;

            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Помилка! Введіть число від 0 до 4.");
                Pause();
                ShowMainMenu();
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
                    ShowStoreInfo();
                    break;
                case 4:
                    ShowSettings();
                    break;
                case 0:
                    Console.WriteLine("\nДякуємо, що завітали! До побачення!");
                    return;
                default:
                    Console.WriteLine("Невірний вибір! Спробуйте ще раз.");
                    break;
            }

            Pause();
            ShowMainMenu();
        }

        static void ShowProducts()
        {
            Console.Clear();
            Console.WriteLine("--- Наші товари ---");
            Console.WriteLine("1. Яблука - " + priceApples + " грн/кг");
            Console.WriteLine("2. Молоко - " + priceMilk + " грн/пляшка");
            Console.WriteLine("3. Яйця (10 шт) - " + priceEggs + " грн/уп");
        }

        static void CalculatePurchase()
        {
            Console.Clear();
            Console.WriteLine("--- Розрахунок нової покупки ---");

            try
            {
                Console.Write("Введіть кількість яблук (кг): ");
                double qtyApples = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введіть кількість пляшок молока: ");
                int qtyMilk = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введіть кількість упаковок яєць: ");
                int qtyEggs = Convert.ToInt32(Console.ReadLine());

                double totalApples = qtyApples * priceApples;
                double totalMilk = qtyMilk * priceMilk;
                double totalEggs = qtyEggs * priceEggs;

                double finalTotal = totalApples + totalMilk + totalEggs;
                double roundedFinalTotal = Math.Round(finalTotal, 2);

                double testNumber = 9;
                double sqrtResult = Math.Sqrt(testNumber);
                double powResult = Math.Pow(2, 3);

                Console.WriteLine("\n---------------------------------------------");
                Console.WriteLine("           ВАШЕ ЗАМОВЛЕННЯ");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Яблука: " + totalApples + " грн");
                Console.WriteLine("Молоко: " + totalMilk + " грн");
                Console.WriteLine("Яйця: " + totalEggs + " грн");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Загальна сума (не округлена): " + finalTotal + " грн");
                Console.WriteLine("ЗАГАЛЬНА СУМА ДО СПЛАТИ (округлена): " + roundedFinalTotal + " грн");

                Console.WriteLine("\n--- Демонстрація Math ---");
                Console.WriteLine("Корінь з " + testNumber + " = " + sqrtResult);
                Console.WriteLine("2 в 3 степені = " + powResult);
            }
            catch (FormatException)
            {
                Console.WriteLine("\nПомилка вводу! Ви ввели не число. Розрахунок скасовано.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nСталася непередбачена помилка: {ex.Message}");
            }
        }

        static void ShowStoreInfo()
        {
            Console.Clear();
            Console.WriteLine("--- Інформація про магазин ---");
            Console.WriteLine("Наша адреса: с. Щасливе, вул. Фермерська, 1.");
            Console.WriteLine("Цей розділ ще доповнюється.");
        }

        static void ShowSettings()
        {
            Console.Clear();
            Console.WriteLine("--- Налаштування ---");
            Console.WriteLine("Функція в розробці.");
        }

        static void Pause()
        {
            Console.WriteLine("\nНатисніть будь-яку клавішу, щоб повернутися до меню...");
            Console.ReadKey();
        }
    }
}