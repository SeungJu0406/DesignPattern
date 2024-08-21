namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Composite composite = new Composite();          

            composite.Add(new Leaf1());
            composite.Add(new Leaf1());
            composite.Add(new Leaf2());

            composite.Execute();
        }
    }
}
