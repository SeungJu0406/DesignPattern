using System.Reflection;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prototype prototype = new Prototype();
            Console.WriteLine($"{prototype.field1}");

            Prototype copy = prototype.Clone();
            Console.WriteLine($"{copy.field1}");
        }
    }
}
