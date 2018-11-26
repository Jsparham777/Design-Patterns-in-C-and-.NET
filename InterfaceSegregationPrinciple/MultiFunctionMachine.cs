namespace InterfaceSegregationPrinciple
{
    public class MultiFunctionMachine : IMultifunctionDevice
    {
        private IPrinter _printer;
        private IScanner _scanner;

        public MultiFunctionMachine(IPrinter printer, IScanner scanner)
        {
            _printer = printer;
            _scanner = scanner;
        }

        public void Print(Document d)
        {
            _printer.Print(d);
        }

        public void Scan(Document d)
        {
            _scanner.Scan(d);
        }// decorator pattern
    }
}
