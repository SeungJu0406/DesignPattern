using Builder.Builder;
using Builder.Product;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            Builder1 builder1 = new Builder1();           
          
            director.ChangeBuilder(builder1);
            director.Make(IsPhoneNumber.No);
            Product1 product1 = builder1.GetResult();
            Console.WriteLine($"{product1.name}, {product1.age}, {product1.phoneNumber}");


            Builder2 builder2 = new Builder2();

            director.ChangeBuilder(builder2);
            director.Make(IsPhoneNumber.Yes);
            Product2 product2 = builder2.GetResult();
            Console.WriteLine($"{product2.name}, {product2.age}, {product2.phoneNumber}");
        }
    }
}
