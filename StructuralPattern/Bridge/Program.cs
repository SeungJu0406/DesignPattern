﻿namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Abstraction abstraction = new Abstraction(new ConcreteImplementations());
            abstraction.Feature1();
            abstraction.Feature2();
            Console.WriteLine();

            abstraction.ChangeImplementation(new TestClass());
            abstraction.Feature1();
            abstraction.Feature2();
            Console.WriteLine();
        }
    }
}
