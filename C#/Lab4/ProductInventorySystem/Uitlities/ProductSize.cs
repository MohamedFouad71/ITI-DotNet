


namespace ProductInventorySystem.Utilities
{
    struct ProductSize
    {
        float length;
        float width;
        float depth;


        public float Length
        {
            get { return length; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("[Error], Length Can't Be Negative");
                    return;
                }

                length = value;
            }
        }

        public float Width
        {
            get { return width; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("[Error], Width Can't Be Negative");
                    return;
                }

                width = value;
            }
        }

        public float Depth
        {
            get { return depth; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("[Error], Depth Can't Be Negative");
                    return;
                }

                depth = value;
            }
        }

        public ProductSize() { }

        public ProductSize(float l, float w, float h)
        {
            length = l; width = w; depth = h;
        }

    }
}