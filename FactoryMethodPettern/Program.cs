using FactoryMethodPettern.FactoryMethod;

namespace FactoryMethodPettern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteCreatorA A = new ConcreteCreatorA();
            ConcreteCreatorB B = new ConcreteCreatorB();
            A.SomeOperation();
            B.SomeOperation();
        }
    }
}
