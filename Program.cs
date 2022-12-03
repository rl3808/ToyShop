using System;

namespace ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToyStore t1 = new ToyStore("DeezNuts");

            t1.addToy(new Dolly("Baby1", 40));
            t1.addToy(new Dolly("Baby2", 50));
            t1.addToy(new Dolly("Baby3", 60));

            t1.addToy(new TedyBear("TedyBear", 10, Size.SMALL));
            t1.addToy(new TedyBear("MamaBear", 20, Size.MEDIUM));
            t1.addToy(new TedyBear("PapaBear", 30, Size.LARGE));


        }
    }
}
