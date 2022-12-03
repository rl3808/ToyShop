namespace ToyShop
{
    enum Size { LARGE, MEDIUM, SMALL };
    internal class TedyBear : Toy
    {
        private Size bearSize;

        public TedyBear(string name, int price, Size bearSize) : base(name, price)
        {
            this.bearSize = bearSize;
        }

        public override double GetPrice()
        {
            if (bearSize == Size.MEDIUM)
                return base.GetPrice() * (1.0 + (double)15 /100);

            if (bearSize == Size.LARGE)
                return base.GetPrice() * (1.0 + (double)30 / 100);

            return base.GetPrice();
        }
    }
}
