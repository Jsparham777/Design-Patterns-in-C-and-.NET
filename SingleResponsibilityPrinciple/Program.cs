using System.Diagnostics;
using static System.Console;

namespace Design_Patterns_in_CSharp_and_dotNET
{
    class Program
    {
        static void Main(string[] args)
        {
            var j = new Journal();
            j.AddEntry("Hello there");
            j.AddEntry("Hello again");
            WriteLine(j);

            var p = new Persistence();
            var filename = @"C:\temp\journal.txt";
            p.SaveToFile(j, filename, true);
            Process.Start(filename);
        }
    }
}
