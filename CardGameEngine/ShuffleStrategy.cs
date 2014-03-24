using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameEngine
{

    public interface ShuffleStrategy
    {
        void Shuffle(List<Card> CardStack);
    }

    public class ShuffleContext
    {
        private ShuffleStrategy Strategy;

        public ShuffleContext(ShuffleStrategy Strategy)
        {
            this.Strategy = Strategy;
        }

        public void Shuffle(List<Card> CardStack)
        {
            this.Strategy.Shuffle(CardStack);
        }
    }

    public class FisherAndYatesShuffle : ShuffleStrategy
    {
        public Random r = new Random();
        
        public void Shuffle(List<Card> CardStack)
        {
            for (int n = CardStack.Count - 1; n > 0; --n)
            {
                int k = r.Next(n + 1);
                Card temp = CardStack[n];
                CardStack[n] = CardStack[k];
                CardStack[k] = temp;
            }
        }
    }
}
