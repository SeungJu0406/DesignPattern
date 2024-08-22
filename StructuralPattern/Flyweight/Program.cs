namespace Flyweight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepeatingState repeating = new RepeatingState();
            UniqueState unique = new UniqueState();

            Context context = new Context(repeating, unique);

            context.Operation();
        }
    }
}
