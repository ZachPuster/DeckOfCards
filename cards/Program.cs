using System;
using cards.Controllers;

namespace cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new Deck();
            deck.dealOneCard();
        }
    }
}