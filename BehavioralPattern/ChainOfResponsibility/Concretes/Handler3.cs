namespace ChainOfResponsibility.Concretes
{
    public class Handler3 : BaseHandler
    {
        public override void Handle(string food)
        {
            if (CanHandle(food))
            {
                Console.WriteLine($"{food}는 고기입니다");
            }
            else
            {
                Console.WriteLine($"{food}은 고기가 아닙니다");
                base.Handle(food);
            }
        }
        private bool CanHandle(string food)
        {
            if (food.Equals("치킨"))
            {
                return true;
            }
            return false;
        }
    }
}
