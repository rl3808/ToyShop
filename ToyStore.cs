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

        public double SumofAllToysCosts()
        {
            double sum = 0;
            for(int i = 0; i < counter; i++)
                sum += toys[i].GetPrice();

            return sum;
        }

        public Dolly[] GetDollys()
        {
            int index = 0;
            Dolly[] d = new Dolly[counter];
            for (int i = 0; i < counter; i++)
                if (toys[i] is Dolly)
                    d[index++] = (Dolly)toys[i];

            return d.Take(index).ToArray();
        }

        public TedyBear[] GetTeddys()
        {
            int index = 0;
            TedyBear[] d = new TedyBear[counter];
            for (int i = 0; i < counter; i++)
                if (toys[i] is TedyBear)
                    d[index++] = (TedyBear)toys[i];

            return d.Take(index).ToArray();
        }

        public TedyBear[] GetBigTeddys()
        {
            int index = 0;
            TedyBear[] d = new TedyBear[counter];
            for (int i = 0; i < counter; i++)
                if (toys[i] is TedyBear && ((TedyBear)toys[i]).BearSize == Size.LARGE)
                    d[index++] = (TedyBear)toys[i];

            return d.Take(index).ToArray();
        }

        public int GetTeddyNumber(Size size)
        {
            int count = 0;
            TedyBear[] d = GetTeddys();
            foreach (TedyBear tedy in d)
                if(tedy.BearSize == size)
                    count++;

            return count;
        }
    }
}
