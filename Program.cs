using System;

namespace ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToyStore t1 = new ToyStore("DeezNuts");

            t1.addToy(new Dolly("Baby1", 100));
            t1.addToy(new Dolly("Baby2", 100));
            t1.addToy(new Dolly("Baby3", 100));

            t1.addToy(new TedyBear("TedyBear", 100, Size.SMALL));
            t1.addToy(new TedyBear("MamaBear", 10, Size.MEDIUM));
            t1.addToy(new TedyBear("PapaBear", 10, Size.LARGE));

            //Console.WriteLine(t1.GetToy(3));
            //Console.WriteLine(t1.SumofAllToysCosts());
            Console.WriteLine(t1.GetTeddyNumber(Size.LARGE));
        }
    }
}
