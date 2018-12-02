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
        public PictureBox dealerCard1;
        public int cardX;
        public int cardY;
        public int cardLeft;
        public int cardTop;
        public int cardSep;
        public bool isPlayer = false;
        public bool isDealer = false;
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

                newCard.SizeMode = PictureBoxSizeMode.StretchImage;
                newCard.Size = new Size(cardX, cardY);
                newCard.Left = cardLeft + cardObjects.Count * cardX + (cardObjects.Count) * cardSep;
                newCard.Top = cardTop;
                main.Controls.Add(newCard);
                cardObjects.Add(newCard);

                Console.WriteLine("Added new card. Left: " + newCard.Left.ToString());
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
                    winLoseLbl.Text = "BUST";
                    winLoseLbl.ForeColor = Color.Red;
                    standBtn.Enabled = false;
                    dealBtn.Enabled = false;
                    valueLabel.Text = "Final Value: " + calculateValue().ToString();
                }
            }
        }
    }
}
