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

        public Size BearSize { get { return bearSize; } }

        public override double GetPrice()
        {
            if (bearSize == Size.MEDIUM)
                return base.GetPrice() * (1.0 + 0.15 );

            if (bearSize == Size.LARGE)
                return base.GetPrice() * (1.0 + 0.30 );

            return base.GetPrice();
        }
    }
}
