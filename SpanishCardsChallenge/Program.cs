using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpanishCardsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            DeckOfCards myCards = new DeckOfCards();

            myCards.ShowAllDeck();
            //myCards.MixDeck();
            //myCards.ShowAllDeck();
            //myCards.CardFromTop().WriteCardValue();
            myCards.CardFromPosition(5).WriteCardValue();
            //myCards.CardFromRandom().WriteCardValue();
            Console.WriteLine($"Cards Remaining { myCards.NumOfCardsInDeck() }");
            //myCards.ShowAllDeck();

            Console.ReadLine();
        }
    }
}
