using System;
using System.Collections.Generic;
using System.Linq;
using cards.Models;

namespace cards.Controllers
{
    public class Deck
    {
        private const string ConsoleMessage = "Your card is: {0} of {1}";
        private List<Card> cards { get; }
        private static readonly Random _random = new Random();  

        //Populate the deck from the defined enumerations
        public Deck()
        {
            cards = new List<Card>();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    cards.Add( new Card(suit, rank));
                }
            }
        }
        
        //Shuffle function
        private static void Shuffle<T>(IList<T> list)  
        {  
            var n = list.Count;  
            while (n > 1) {  
                n--;  
                var k = _random.Next(n + 1);  
                var value = list[k];  
                list[k] = list[n];  
                list[n] = value;  
            }  
        }
        
        //Deal one card when no input is given
        public void dealOneCard()
        {
            DealXCards(1);    
        }

        private void DealXCards(int numCards)//Guarantee that an input does not exceed list size
        {
            //var newCards = new Deck();
            Shuffle(cards);
            if (numCards > cards.Count)
            {
                numCards = cards.Count;
            }

            for (int i = 0; i < numCards; i++)
            {
                var card = cards.ElementAt(i);
                Console.Write(ConsoleMessage, card.rank, card.suit);
            }
        }
    }
}