using System.Collections.Generic;

namespace Open_ClosedPrinciple
{
    public class ProductFilter
    {
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var p in products)
                if (p.Size == size)
                    yield return p;
        }

        public IEnumerable<Product> FilterByColour(IEnumerable<Product> products, Colour colour)
        {
            foreach (var p in products)
                if (p.Colour == colour)
                    yield return p;
        }

        public IEnumerable<Product> FilterBySizeAndColour(IEnumerable<Product> products, Size size, Colour colour)
        {
            foreach (var p in products)
                if (p.Size == size && p.Colour == colour)
                    yield return p;
        }
    }
}
