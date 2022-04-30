namespace ConsoleApp2
{
    internal abstract class Product
    {
        public string ProductName { get; set; }
        public  int Price { get; set; }
        public  int Count { get; set; }
        public int TotalIncome { get; set; }
        public Product(string productName, int price, int count)
        {
            ProductName = productName;
            Price = price;
            Count = count;
            
        }
      
        public abstract void Sell();
        public abstract void GetProduct();



    }
}
