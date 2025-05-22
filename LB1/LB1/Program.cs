using System;
using System.Text;

namespace LB1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Product apple = new("Яблуко", 5, 100);
            Console.WriteLine(apple.GetInfo());

            apple.Sell(20);
            Console.WriteLine(apple.GetInfo());

            apple.Restock(50);
            Console.WriteLine(apple.GetInfo());

            apple.Price = 7;
            Console.WriteLine(apple.GetInfo());

            apple.Name = "Зелене яблуко";
            Console.WriteLine(apple.GetInfo());

            try
            {
                apple.Price = -10;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }

            try
            {
                apple.Name = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }

            apple.Sell(200);
        }
    }
}