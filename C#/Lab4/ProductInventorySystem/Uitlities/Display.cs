



namespace ProductInventorySystem.Utilities
{
    class Display
    {
        public static void ProductInfo(Product p)
        {
            System.Console.WriteLine($"Product Name : {p.Name}");
            System.Console.WriteLine($"Product ID : {p.ID}");
            System.Console.WriteLine($"Product Category : {p.Category}");
            System.Console.WriteLine($"Product Price : {p.Price:c2}");
            System.Console.WriteLine($"Product Size : {p.Size.Length} x {p.Size.Width} x {p.Size.Depth}");
        }
    }
}