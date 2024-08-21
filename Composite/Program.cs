namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Composite composite = new Composite();
            
            Leaf1 leaf1 = new Leaf1();
            Leaf2 leaf2 = new Leaf2();
            Leaf3 leaf3 = new Leaf3();

            composite.Add(leaf1);
            composite.Add(leaf2);
            composite.Add(leaf3);

            composite.Execute();
        }
    }
}
