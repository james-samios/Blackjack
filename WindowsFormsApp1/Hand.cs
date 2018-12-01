using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Hand
    {
        public List<Card> cards = new List<Card>();
        public List<PictureBox> cardObjects = new List<PictureBox>();
        public Label valueLabel;
        public Label winLoseLbl;
        public Button dealBtn;
        public Button standBtn;
        bool isPlayer = false;
        bool isDealer = false;
        Form1 main;

        public Hand(Form1 frm)
        {
            main = frm;
        }

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

        public void showCards()
        {
            while (cardObjects.Count < cards.Count)
            {
                PictureBox newCard = new PictureBox();

                newCard.Size = new Size(169, 231);
                newCard.Left = 11 + cardObjects.Count * 169 + (cardObjects.Count) * 20;
                newCard.Top = 502;
                main.Controls.Add(newCard);
                cardObjects.Add(newCard);

                Console.WriteLine("added new card. left: " + newCard.Left.ToString());
            }


            for (int i = 0; i < cards.Count; i++)
            {
                cardObjects[i].Image = cards[i].GetImage();
            }

            if (valueLabel.Visible)
            {
                valueLabel.Text = "Value: " + calculateValue().ToString();
                if (calculateValue() > 21)
                {
                    winLoseLbl.Text = "BUST - YOU LOSE";
                    winLoseLbl.ForeColor = Color.Red;
                    standBtn.Enabled = false;
                    dealBtn.Enabled = false;
                }
            }
        }
    }
}
