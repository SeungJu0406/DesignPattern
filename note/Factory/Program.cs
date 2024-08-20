namespace Factory
{
    public class Program
    {
        static void Main(string[] args)
        {
            Item potion = ItemFactory.Instantiate("포션");
        }
    }
    // 아이템을 만드는 아이템 팩토리 클래스
    public class ItemFactory
    {
        public static Item Instantiate(string name)
        {
            if(name== "포션")
            {
                Item item = new Item();
                item.name = "포션";
                item.weight = 3;
                return item;
            }
            else
            {
                return null;
            }
        }
    }

    public class Item
    {
        public string name;
        public int weight;
    }
}
