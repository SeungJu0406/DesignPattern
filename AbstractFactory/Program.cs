using System.Data;
using AbstractFactory.Factory;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GoldFactory goldFactory = new GoldFactory();
            SilverFactory silverFactory = new SilverFactory();
            
            Client goldClient = new Client(goldFactory);
            goldClient.AxeOperation();
            goldClient.SwordOperation();

            Client silverClient = new Client(silverFactory);
            silverClient.AxeOperation();
            silverClient.SwordOperation();
        }
    }
}
