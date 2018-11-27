using Open_ClosedPrinciple.New;
using static System.Console;

namespace Open_ClosedPrinciple
{
    public class Program
    {
        static void Main(string[] args)
        {
            var apple = new Product("Apple", Colour.Green, Size.Small);
            var tree = new Product("Tree", Colour.Green, Size.Large);
            var house = new Product("House", Colour.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            var pf = new ProductFilter();
            WriteLine("Green products (old):");
            foreach (var p in pf.FilterByColour(products, Colour.Green))
            {
                WriteLine($" - {p.Name} is green");
            }

            var bf = new BetterFilter();
            WriteLine("Green products (new):");
            foreach (var p in bf.Filter(products, new ColourSpecification(Colour.Green))
            {
                WriteLine($" - {p.Name} is green");
            }

            WriteLine("Large blue items");
            foreach (var p in bf.Filter(products, new AndSpecification<Product>(new ColourSpecification(Colour.Blue), new SizeSpecification(Size.Large))))
            {
                WriteLine($" - {p.Name} is big and blue");
            }
        }
    }
}
