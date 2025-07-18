





using ProductInventorySystem.Utilities;

namespace ProductInventorySystem
{
    class Program
    {
        public static double GetTotalPrice(Product[] products)
        {
            double totalPrice = 0;

            foreach (var item in products)
                totalPrice += item.Price;

            return totalPrice;
        }

        public static Product GetMostExpensive(Product[] products)
        {

            Product mostExpensive = new() { Price = 0.00000000000001 };

            if (products.Length == 0)
                System.Console.WriteLine("[Error] empty list, returning a new product");

            foreach (var item in products)
                if (item.Price > mostExpensive.Price) mostExpensive = item;

            return mostExpensive;
        }
        public static void Main(string[] args)
        {

            ProductSize[] sizes =
            {
                new(49, 20, 10),
                new(39, 10, 5 ),
                new(40, 20, 8 )
            };

            Product[] products =
            {
                new(1 , "Laptop" , 999.99, Category.Electronics, sizes[0]),
                new(2 , "T-Shirt" , 49.99, Category.Clothing, sizes[1]),
                new(3 , "Mobile Phone" , 599.99, Category.Electronics, sizes[2])
            };

            foreach (Product p in products)
            {
                Display.ProductInfo(p);
                System.Console.WriteLine();
            }

            System.Console.WriteLine($"Total Price : {GetTotalPrice(products):c2}\n");
            System.Console.WriteLine($"Most Expensive : ");
            Display.ProductInfo(GetMostExpensive(products));

        }
    }
}