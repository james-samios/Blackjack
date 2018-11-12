using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Hand
    {
        public List<Card> cards = new List<Card>();
        bool isPlayer = false;
        bool isDealer = false;
        
        public int calculateValue()
        {
            int total = 0;
            int aceCount = 0;

            foreach (Card c in this.cards)
            {
                total += c.Value;
                if (c.Ace)
                {
                    aceCount++;
                }
            }

            return total;

        }

        public void addCard(Card c)
        {
            this.cards.Add(c);
        }

    }
}
