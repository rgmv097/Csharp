using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.Models
{
    internal class Order
    {
        public List<Product> Products { get; set; }
        public static int TotalPrice;
        public DateTime Date;
        static Order()
        {
            TotalPrice = 0;
        }
        public Order()
        {
            Products = new List<Product>();
            Date = DateTime.Now;
        }


        public void GetCheck()
        {
            foreach (var item in Products)
            {
                Console.WriteLine($"Name: {item.Name} Price: {item.Price} Count: {item.Count}x ");
                TotalPrice += item.Count*item.Price;
            }
            Console.WriteLine("Total: " + TotalPrice);
            Console.WriteLine("- - - - - - -");
            Predicate<int> predicate = TotalPrice => TotalPrice < 100;          
            Predicate<int> predicate1 = TotalPrice => TotalPrice >= 100 && TotalPrice<=200;
            if (predicate(TotalPrice))
            {
                Console.WriteLine("No discount for less than 100 purchases: "+TotalPrice);
            }
            if (predicate1(TotalPrice))
            {              
                TotalPrice -= TotalPrice / 10;
                Console.WriteLine("You got 10% off: "+TotalPrice);
            }
            else
            {
                TotalPrice -= TotalPrice / 5;
                Console.WriteLine("You got 20% off: "+TotalPrice);
            }
            Console.WriteLine("- - - - - - -");
            Console.WriteLine("Check Time: "+ Date);



        }
        public void BuyProduct(Product product)
        {
            Products.Add(product);
            Console.WriteLine($"{product.Count} eded {product.Name} elave olundu\n- - - - - - -");
        }
    }
}
