namespace ConsoleApp1.Models
{
    internal class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count;
        public Product(string name, int price)
            
        {
            Name = name;
            Price = price;           
        }
        public override string ToString()
        {
            return $"Product: {Name} -  Price: {Price}";
        }
    }
}
