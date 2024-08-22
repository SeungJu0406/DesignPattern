namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Component a = new Component();
            Decorator b = new Decorator(a);

            b.Execute();
        }
    }
}
