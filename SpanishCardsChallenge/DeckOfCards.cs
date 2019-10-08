using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpanishCardsChallenge
{
     class DeckOfCards : SpanishPlayingCard
    {
        /// <summary>
        /// List deck is the main collection that holds cards and gets manipulated
        /// </summary>
        public List<SpanishPlayingCard> deck { get; set; } = new List<SpanishPlayingCard>();

        Random random = new Random();

        //this list is used to populate new card object into the deck list 
        List<string> signs = new List<string>() {"golden", "cups", "swords", "sticks" };
        
    

        public DeckOfCards()
        {
            for(int i = 0; i < 4; i++)
            {
                for(int j = 1; j < 13; j++)
                {
                    deck.Add(new SpanishPlayingCard { sign = signs[i], number = j });
                }
            }
        }


        public int NumOfCardsInDeck()
        {
            return deck.Count();
        }

        public SpanishPlayingCard CardFromTop()
        {
            return deck[0];
        }

        public SpanishPlayingCard CardFromPosition(int n)
        {
            if(n < NumOfCardsInDeck())
            {
                Console.WriteLine("There are less cards left than that");
            }
            deck.RemoveAt(n);
            return deck[n];
        }

        public SpanishPlayingCard CardFromRandom()
        {
            return deck[random.Next(0, NumOfCardsInDeck())];
        }

        public void ShowAllDeck()
        {
            foreach(var card in deck)
            {
                card.WriteCardValue();
            }
            Console.WriteLine("----------------"); // just a spacer after long print of whole deck
        }

        public void MixDeck()
        {
            deck = deck.OrderBy(  x => random.Next(0, NumOfCardsInDeck())  ).ToList();
        }

    }
}
