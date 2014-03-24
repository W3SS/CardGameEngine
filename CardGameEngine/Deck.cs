using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameEngine
{
    public abstract class Deck : IEnumerable
    {
        public List<Card> CardStack;
        protected ShuffleContext Context;
        public void Shuffle()
        {
            this.Context.Shuffle(this.CardStack);
        }


        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this.CardStack;
        }
    }

    public class StandardBicycleDeck : Deck
    {
        public StandardBicycleDeck(ShuffleContext Context)
        {
            this.Context = Context;
        }

        public void Initialize()
        {
        }
    }

}
