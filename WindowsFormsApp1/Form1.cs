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
        Hand dealer;
        Image cardBack = Image.FromFile(@"../../Cards/Back.png");


        private void Form1_Load(object sender, EventArgs e)
        {
            CreateGame();
            dealer = new Hand(this);

            valueLabel.Hide();
            dealBtn.Hide();
            startGameBtn.Show();
            endGameBtn.Hide();
            standBtn.Hide();
            startCardsBtn.Hide();
            currentTurnLbl.Hide();
            winLoseLbl.Show();
            dealerLbl.Hide();
            restartBtn.Hide();
            dealerCard1.Hide();
            dealerCard2.Hide();
            computer1Lbl.Hide();
            computer2Lbl.Hide();
            computer3Lbl.Hide();
        }

        private void StartGame()
        {
            if (nameBox.TextLength < 1)
            {
                MessageBox.Show("Please enter a name to play!","NAME REQUIRED");
            } else
            {
                if (selectComputer1.Checked)
                {
                    // Dealer, player, computer 1
                    playerCount = 3;
                    Console.WriteLine("Player Count: " + playerCount);
                    computer1Lbl.Show();
                } else if (selectComputer2.Checked)
                {
                    // Dealer, player, computer 1, computer 2
                    playerCount = 4;
                    Console.WriteLine("Player Count: " + playerCount);
                    computer1Lbl.Show();
                    computer2Lbl.Show();
                } else if (selectComputer3.Checked)
                {
                    // Dealer, player, computer 1, computer 2, computer 3
                    playerCount = 5;
                    Console.WriteLine("Player Count: " + playerCount);
                    computer1Lbl.Show();
                    computer2Lbl.Show();
                    computer3Lbl.Show();
                } else
                {
                    // Default - Dealer, player, computer 1
                    playerCount = 3;
                    Console.WriteLine("Player Count: " + playerCount);
                    computer1Lbl.Show();
                }
                startGameBtn.Hide();
                dealBtn.Hide();
                endGameBtn.Show();
                startCardsBtn.Show();
                dealerLbl.Show();
                restartBtn.Show();
                nameLbl.Hide();
                nameBox.Hide();
                HideRadioBtns();

                dealerCard1.Show();
                dealerCard2.Show();
                dealerCard1.SizeMode = PictureBoxSizeMode.StretchImage;
                dealerCard2.SizeMode = PictureBoxSizeMode.StretchImage;

                userCard1.Image = cardBack;
                userCard2.Image = cardBack;
                dealerCard1.Image = cardBack;
                dealerCard2.Image = cardBack;

                string turn = "Dealer";
                currentTurnLbl.Show();
                currentTurnLbl.Text = "TURN: " + turn;
            }
 
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
                players.Add(new Hand(this));
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

        private void GetCards()
        {
            descLbl.Text = "The Dealer is giving everyone their cards.";
            Wait(1500);
            descLbl.Text = "";

            startCardsBtn.Hide();
            dealBtn.Show();
            standBtn.Show();


            valueLabel.Show();

            Hand h = players[0];
            h.cardObjects.Add(userCard1);
            h.cardObjects.Add(userCard2);
            h.valueLabel = valueLabel;
            h.winLoseLbl = winLoseLbl;
            h.dealBtn = dealBtn;
            h.standBtn = standBtn;

            h.showCards();

            currentTurnLbl.Text = "TURN: " + nameBox.Text;
            descLbl.Text = "It is your turn.";
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
            Shuffle();
        }

        private void HideRadioBtns()
        {
            selectComputer1.Hide();
            selectComputer2.Hide();
            selectComputer3.Hide();
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

            Hand h = players[0];

            h.addCard(deck[0]);
            deck.Remove(deck[0]);

            h.showCards();

            descLbl.Text = "You have chosen to hit.";
            Wait(1500);
            descLbl.Text = "It is your turn.";


        }

        private void startCardsBtn_Click(object sender, EventArgs e)
        {
            GetCards();
        }

        private void standBtn_Click(object sender, EventArgs e)
        {
            standBtn.Enabled = false;
            dealBtn.Enabled = false;
            descLbl.Text = "You have chosen to stand.";
            Wait(1500);
            descLbl.Text = "Computer 1 is deciding...";
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
