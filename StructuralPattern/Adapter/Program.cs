namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
            ClientClass test = new ClientClass(adaptee);

            test.Method();

        }
    }
}
