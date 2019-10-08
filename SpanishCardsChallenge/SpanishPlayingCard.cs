using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpanishCardsChallenge
{
     public class SpanishPlayingCard
    {
        public int number { get; set; }
        public string sign { get; set; }

        public SpanishPlayingCard() { }

        public SpanishPlayingCard(int number, string sign)
        {
            this.number = number;
            this.sign = sign;
        }

        public void WriteCardValue()
        {
            Console.WriteLine($"{ number } { sign }");
        }


    }
}
