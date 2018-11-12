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
        int playerCount = 2;
        List<Card> deck = new List<Card>();
        List<Hand> players = new List<Hand>();
        Hand dealer = new Hand();
        Image cardBack = Image.FromFile(@"../../Cards/Back.png");


        private void Form1_Load(object sender, EventArgs e)
        {
            CreateGame();

            valueLabel.Hide();
            dealBtn.Hide();
            startGameBtn.Show();
            endGameBtn.Hide();
            standBtn.Hide();
            startCardsBtn.Hide();
            userCard3.Hide();
            userCard4.Hide();
            userCard5.Hide();
            userCard6.Hide();
            currentTurnLbl.Hide();

        }

        private void StartGame()
        {
            startGameBtn.Hide();
            dealBtn.Hide();
            endGameBtn.Show();
            startCardsBtn.Show();


            userCard1.Image = cardBack;
            userCard2.Image = cardBack;

            string turn = "Dealer";
            currentTurnLbl.Show();
            currentTurnLbl.Text = "TURN: " + turn;
        }

        public void Wait(int ms)
        {
            DateTime start = DateTime.Now;
            while ((DateTime.Now - start).TotalMilliseconds < ms)
                Application.DoEvents();

        }

        public void dealCards()
        {
            foreach (Hand h in players)
            {
                h.addCard(deck[0]);
                deck.Remove(deck[0]);
            }
        }
        public void createPlayers()
        {
            for (int i = 0; i < playerCount; i++)
            {
                players.Add(new Hand());
            }
        }
        public void CreateGame()
        {
            CreateDeck();
            createPlayers();
            dealCards();
            dealCards();
            foreach(Hand h in players)
            {
                string cardString = "";
                foreach (Card c in h.cards)
                {
                    cardString += c.Value+", ";
                }
                Console.WriteLine("Total: " + h.calculateValue().ToString() + ", Cards: " + cardString);
            }

        }

        //private void GetCards()
        //{
        //    descLbl.Text = "The Dealer is giving everyone their cards.";
        //    Wait(1500);
        //    descLbl.Text = "";

        //    startCardsBtn.Hide();
        //    dealBtn.Show();
        //    standBtn.Show();
        //    CreateDeck();

        //    // 1: Spades, 2: Hearts, 3: Diamonds, 4: Clubs
        //    Random ct = new Random();
        //    int card1 = ct.Next(1, 5);
        //    int card2 = ct.Next(1, 5);

        //    valueLabel.Show();

        //    userCard1.Image = Image.FromFile(@"../../Cards/" + deck[0].GetImage() + "-" + card1 + ".png");
        //    userCard2.Image = Image.FromFile(@"../../Cards/" + deck[1].GetImage() + "-" + card2 + ".png");

            
        //    int finalValue = (deck[0].Value + deck[1].Value);
        //    Console.WriteLine("------------\nCARD 1: " + deck[0].Value + "\nCARD 2: " + deck[1].Value + "\nCARD 3: " + deck[2].Value + "\nCARD 4: " + deck[3].Value + "\nCARD 5: " + deck[4].Value + "\nCARD 6: " + deck[5].Value + "\nTOTAL (CARD 1 & 2): " + finalValue + "\n------------");

        //    valueLabel.Text = "Value: " + finalValue;
        //}

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
            Shuffle();
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
        private static int card = 2;

        private void button1_Click(object sender, EventArgs e)
        {
            card++;

            userCard3.Show();
            userCard4.Show();
            userCard5.Show();
            userCard6.Show();

            Random ct = new Random();
            int card3 = ct.Next(1, 5);
            int card4 = ct.Next(1, 5);
            int card5 = ct.Next(1, 5);
            int card6 = ct.Next(1, 5);

            //if (card == 3)
            //{
            //    userCard3.Image = cardBack;
            //    descLbl.Text = "You have decided to Hit. You have been given another card.";
            //    Wait(1000);
            //    descLbl.Text = "";
            //    userCard3.Image = Hand.image;
            //    int finalValue = (deck[0].Value + deck[1].Value + deck[2].Value);
            //    valueLabel.Text = "Value: " + finalValue;
            //    if (finalValue > 21) {
            //        dealBtn.Enabled = false;
            //        standBtn.Enabled = false;
            //        valueLabel.Text = "BUST - YOU LOSE! Final Value: " + finalValue;
            //        valueLabel.ForeColor = Color.Red;
            //    } else if (finalValue == 21)
            //    {
            //        dealBtn.Enabled = false;
            //        standBtn.Enabled = false;
            //        valueLabel.Text = "YOU WIN! Final Value: " + finalValue;
            //        valueLabel.ForeColor = Color.Green;
            //    }
            //} else if (card == 4)
            //{
            //    userCard4.Image = Image.FromFile(@"../../Cards/Back.png");
            //    descLbl.Text = "You have decided to Hit. You have been given another card.";
            //    Wait(1000);
            //    descLbl.Text = "";
            //    userCard4.Image = Image.FromFile(@"../../Cards/" + deck[3].GetImage() + "-" + card4 + ".png");
            //    int finalValue = (deck[0].Value + deck[1].Value + deck[2].Value + deck[3].Value);
            //    valueLabel.Text = "Value: " + finalValue;
            //    if (finalValue > 21)
            //    {
            //        dealBtn.Enabled = false;
            //        standBtn.Enabled = false;
            //        valueLabel.Text = "BUST - YOU LOSE! Final Value: " + finalValue;
            //        valueLabel.ForeColor = Color.Red;
            //    }
            //    else if (finalValue == 21)
            //    {
            //        dealBtn.Enabled = false;
            //        standBtn.Enabled = false;
            //        valueLabel.Text = "YOU WIN! Final Value: " + finalValue;
            //        valueLabel.ForeColor = Color.Green;
            //    }
            //} else if (card == 5)
            //{
            //    userCard5.Image = Image.FromFile(@"../../Cards/Back.png");
            //    descLbl.Text = "You have decided to Hit. You have been given another card.";
            //    Wait(1000);
            //    descLbl.Text = "";
            //    userCard5.Image = Image.FromFile(@"../../Cards/" + deck[4].GetImage() + "-" + card5 + ".png");
            //    int finalValue = (deck[0].Value + deck[1].Value + deck[2].Value + deck[3].Value + deck[4].Value);
            //    valueLabel.Text = "Value: " + finalValue;
            //    if (finalValue > 21)
            //    {
            //        dealBtn.Enabled = false;
            //        standBtn.Enabled = false;
            //        valueLabel.Text = "BUST - YOU LOSE! Final Value: " + finalValue;
            //        valueLabel.ForeColor = Color.Red;
            //    }
            //    else if (finalValue == 21)
            //    {
            //        dealBtn.Enabled = false;
            //        standBtn.Enabled = false;
            //        valueLabel.Text = "YOU WIN! Final Value: " + finalValue;
            //        valueLabel.ForeColor = Color.Green;
            //    }
            //} else if (card == 6)
            //{
            //    userCard6.Image = Image.FromFile(@"../../Cards/Back.png");
            //    descLbl.Text = "You have decided to Hit. You have been given another card.";
            //    Wait(1000);
            //    descLbl.Text = "";
            //    userCard6.Image = Image.FromFile(@"../../Cards/" + deck[5].GetImage() + "-" + card6 + ".png");
            //    int finalValue = (deck[0].Value + deck[1].Value + deck[2].Value + deck[3].Value + deck[4].Value + deck[5].Value);
            //    valueLabel.Text = "Value: " + finalValue;
            //    dealBtn.Enabled = false;
            //    if (finalValue > 21)
            //    {
            //        dealBtn.Enabled = false;
            //        standBtn.Enabled = false;
            //        valueLabel.Text = "BUST - YOU LOSE! Final Value: " + finalValue;
            //        valueLabel.ForeColor = Color.Red;
            //    }
            //    else if (finalValue == 21)
            //    {
            //        dealBtn.Enabled = false;
            //        standBtn.Enabled = false;
            //        valueLabel.Text = "YOU WIN! Final Value: " + finalValue;
            //        valueLabel.ForeColor = Color.Green;
            //    }
            //}


        }

        private void startCardsBtn_Click(object sender, EventArgs e)
        {
            //GetCards();
        }

        private void standBtn_Click(object sender, EventArgs e)
        {
            // Stand button
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to restart?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Restart();
            }
            else
            {
                // Do nothing
            }
        }
    }
}
