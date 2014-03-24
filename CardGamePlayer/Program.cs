using CardGameEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGamePlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            ShuffleContext Context = new ShuffleContext(new FisherAndYatesShuffle());
            StandardBicycleDeck BikeDeck = new StandardBicycleDeck(Context);

            Console.WriteLine("Current Deck: ");

            foreach (Card c in BikeDeck)
            {
                Console.WriteLine(c);
            }

            Console.ReadLine();
        }
    }
}
