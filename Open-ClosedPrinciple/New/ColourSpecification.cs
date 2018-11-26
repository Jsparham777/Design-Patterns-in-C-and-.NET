namespace Open_ClosedPrinciple
{
    public class ColourSpecification : ISpecification<Product>
    {
        private Colour _colour;

        public ColourSpecification(Colour colour)
        {
            _colour = colour;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Colour == _colour;
        }
    }
}
