namespace Open_ClosedPrinciple
{
    public class Product
    {
        public string Name { get; set; }
        public Colour Colour { get; set; }
        public Size Size { get; set; }

        public Product(string name, Colour colour, Size size)
        {
            Name = name;
            Colour = colour;
            Size = size;
        }
    }
}
