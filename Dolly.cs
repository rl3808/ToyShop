using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop
{
    internal class Dolly:Toy
    {
        private int numOfAccessories;
        private double priceOfAccessories;

        public Dolly(string name, int price, int numOfAccessories, double priceOfAccessories):base(name, price)
        {
            this.numOfAccessories = numOfAccessories;
            this.priceOfAccessories = priceOfAccessories;
        }
        public Dolly(string name, int price) : this(name, price, 0, 0) { }
        public override double GetPrice() { return base.GetPrice() + priceOfAccessories; }
    }
}
