namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton.GetInstance();

            string test = Singleton.instance.test;
            Console.WriteLine(test);
        }
    }
}
