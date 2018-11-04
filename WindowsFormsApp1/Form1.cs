using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int numberOfDecks = 4;
        List<Card> deck = new List<Card>();

        private void Form1_Load(object sender, EventArgs e)
        {
            valueLabel.Hide();
            startCardsBtn.Hide();
            startGameBtn.Show();
            endGameBtn.Hide();
            
        }

        private void StartGame()
        {
            startGameBtn.Hide();
            startCardsBtn.Show();
            endGameBtn.Show();

            Image cardBack = Image.FromFile(@"../../Cards/Back.png");

            userCard1.Image = cardBack;
            userCard2.Image = cardBack;
        }

        private void GetCards()
        {
            startCardsBtn.Hide();
            CreateDeck();
            Shuffle();
            foreach (Card c in deck)
            {
                Console.WriteLine(c.Name + ", " + c.Value);
            }

            // 1: Spades, 2: Hearts, 3: Diamonds, 4: Clubs
            Random ct = new Random();
            int card1 = ct.Next(1, 5);
            int card2 = ct.Next(1, 5);

            valueLabel.Show();

            userCard1.Image = Image.FromFile(@"../../Cards/" + deck[0].GetImage() + "-" + card1 + ".png");
            userCard2.Image = Image.FromFile(@"../../Cards/" + deck[1].GetImage() + "-" + card2 + ".png");

            // Value of cards
            // value1 = deck0
            // value2 = deck1
            int value1 = 0;
            int value2 = 0;

            if (deck[0].GetImage() == "King" || deck[0].GetImage() == "Queen" || deck[0].GetImage() == "Jack")
            {
                value1 += 10;
            }
            if (deck[1].GetImage() == "King" || deck[1].GetImage() == "Queen" || deck[1].GetImage() == "Jack")
            {
                value2 += 10;
            }
            if (deck[0].GetImage() == "2" || deck[0].GetImage() == "3" || deck[0].GetImage() == "4" || deck[0].GetImage() == "5" || deck[0].GetImage() == "6" || deck[0].GetImage() == "7" || deck[0].GetImage() == "8" || deck[0].GetImage() == "9" || deck[0].GetImage() == "10")
            {
                int deck0 = Convert.ToInt32(deck[0].GetImage());
                value1 += deck0;
            }
            if (deck[0].GetImage() == "Ace")
            {
                value1 += 11;
            }
            if (deck[1].GetImage() == "Ace")
            {
                value2 += 11;
            }
            if (deck[1].GetImage() == "2" || deck[1].GetImage() == "3" || deck[1].GetImage() == "4" || deck[1].GetImage() == "5" || deck[1].GetImage() == "6" || deck[1].GetImage() == "7" || deck[1].GetImage() == "8" || deck[1].GetImage() == "9" || deck[1].GetImage() == "10")
            {
                int deck1 = Convert.ToInt32(deck[1].GetImage());
                value2 += deck1;
            }

            int finalValue = value1 + value2;
            Console.WriteLine("------------\nCARD 1: " + value1 + "\nCARD 2: " + value2 + "\nTOTAL: " + finalValue + "\n------------");

            valueLabel.Text = "Value: " + finalValue;
        }

        private void EndGame()
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // Do nothing
            }
        }

        private void CreateDeck()
        {
            string[] suits = { "hearts", "spades", "diamonds", "clubs" };
            string[] uCodes = { "\u2665", "\u2660", "\u2666", "\u2663" };
            Brush[] colors = { Brushes.Red, Brushes.Black, Brushes.Red, Brushes.Black };
            byte[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };
            string[] names = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            for(int n = 1; n <= numberOfDecks; n++) {
                for(int s = 0; s <= 3; s++)
                {
                    for (int i = 0; i <= 12; i++)
                    {
                        Card card = new Card();
                        card.Suit = suits[s];
                        card.uCode = uCodes[s];
                        card.color = colors[s];

                        card.Value = values[i];
                        card.Name = names[i];

                        if (values[i] == 1 || values[i] == 11)
                        {
                            card.Ace = true;
                        }
                        else
                        {
                            card.Ace = false;
                        }

                        deck.Add(card);
                    }
                }
            }
        }

        private void Shuffle()
        {
            Random r = new Random();
            int shuffleamount = 100000;

            for(int i = 0; i<= shuffleamount; i++)
            {
                Card temp = new Card();
                int card1 = r.Next(deck.Count()-1);
                int card2 = r.Next(deck.Count()-1);

                temp = deck[card1];
                deck[card1] = deck[card2];
                deck[card2] = temp;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void valueLabel_Click(object sender, EventArgs e)
        {

        }

        private void startGameBtn_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void endGameBtn_Click(object sender, EventArgs e)
        {
            EndGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetCards();
        }
    }
}
