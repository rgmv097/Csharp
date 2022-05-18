using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Kolbasa", 50);
            Product product2 = new Product("Meat", 100);
            Product product3 = new Product("Redbull", 50);
            Product product4 = new Product("Milk", 20);
            Order order = new Order();
            byte choose;
            do
            {
                int i = 0;
                Console.WriteLine($"{++i} - {product1}");
                Console.WriteLine($"{++i} - {product2}");
                Console.WriteLine($"{++i} - {product3}");
                Console.WriteLine($"{++i} - {product4}\n- - - - - - -");
                Console.WriteLine($"{++i} - Get Check\n- - - - - - -");
                Console.Write("Select number to buy: ");
                choose = Convert.ToByte(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.Write($"How Many want to buy {product1.Name} ? ");
                        product1.Count = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        order.BuyProduct(product1);
                        break;
                    case 2:
                        Console.Write($"How Many want to buy {product2.Name} ? ");
                        product2.Count = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        order.BuyProduct(product2);
                        break;
                    case 3:                       
                        Console.Write($"How Many want to buy {product3.Name} ? ");
                        product3.Count = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        order.BuyProduct(product3);
                        break;
                    case 4:
                        Console.Write($"How Many want to buy {product4.Name} ? ");
                        product4.Count = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        order.BuyProduct(product4);
                        break;
                    case 5:
                        Console.Clear();
                        order.GetCheck();
                        break;
                    default:
                        Console.WriteLine("Choose the correct variant\n- - - - -");
                        break;
                }
            } while (choose != 0 && choose!=5);
        }
    }
}
