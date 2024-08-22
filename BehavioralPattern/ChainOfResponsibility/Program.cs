using ChainOfResponsibility.Concretes;

namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHandler h1 = new Handler1();
            IHandler h2 = new Handler2();
            IHandler h3 = new Handler3();

            h1.SetNext(h2);
            h2.SetNext(h3);

            //바나나, 토마토, 치킨
            h1.Handle("토마토");
        }
    }
}
