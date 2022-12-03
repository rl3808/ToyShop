using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop
{
    internal class ToyStore
    {
        private string storeName;
        private Toy[] toys;
        private int counter;

        public ToyStore(string storeName)
        {
            this.storeName = storeName;
            toys = new Toy[50];
            counter = 0;
        }

        public void addToy(Toy t) { toys[counter++] = t; }

        public string GetToy(int index)
        {
            if (index < 0 || index >= toys.Length)
                return "TOY NOT FOUND!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!";

            return toys[index].ToString();
        }
    }
}
