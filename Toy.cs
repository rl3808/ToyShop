using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop
{
    internal class Toy
    {
        private string name;
        private double price;

        public Toy(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public virtual string GetName() { return this.name; }
        public virtual double GetPrice() { return this.price; }
        public override string ToString() { return $"{name} costs {GetPrice()}"; }
    }
}
