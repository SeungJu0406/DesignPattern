namespace Flyweight
{
    public class FlyweightFactory
    {
        private List<Flyweight> cache;

        public FlyweightFactory() 
        {
            cache = new List<Flyweight>();
        }
        public Flyweight GetFlyweight(RepeatingState repeatingState)
        {
            bool IsReaptingState = false;
            int index = 0;
            foreach (Flyweight flyweight in cache)
            {
                if (flyweight.repeatingState == repeatingState)
                {
                    IsReaptingState = true;
                    break;
                }
                index++;
            }
            if (!(IsReaptingState))
            {
                cache.Add(new Flyweight(repeatingState));
            }

            return IsReaptingState ? cache[index] : cache[cache.Count - 1];
        }
    }
}
