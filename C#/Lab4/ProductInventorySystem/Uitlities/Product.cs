



namespace ProductInventorySystem.Utilities
{
    class Product
    {
        static HashSet<int> AllIDs = [];
        int id;
        double price;
        public string Name { get; set; }
        public Category Category { get; set; }
        public ProductSize Size { get; set; }
        public int ID
        {
            get { return id; }
            set
            {
                if (AllIDs.Contains(value))
                {
                    Console.WriteLine($"[Error], Another Product have the same id {value}");
                    return;
                }

                id = value;
                AllIDs.Add(value);
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("[Error], Price Must Be Positive");
                    return;
                }

                price = value;
            }
        }

        public Product()
        {
            Name = "";
        }

        public Product(int _id, string _name, double _price, Category _category, ProductSize _size)
        {
            ID = _id;
            Name = _name;
            Price = _price;
            Category = _category;
            Size = _size;
        }


    }
}