namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Service service = new Service();
            Proxy proxy = new Proxy(service);

            proxy.Operation();
        }
    }
}
