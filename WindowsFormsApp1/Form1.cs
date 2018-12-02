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
        bool plrBust = false;
        bool c1Bust = false;
        bool c2Bust = true;
        bool c3Bust = true;

        int plrTotal;
        int c1Total;
        int c2Total;
        int c3Total;
        int dlrTotal;

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
            dealerHiddenCard.Hide();
            comp1ValueLbl.Hide();
            comp2ValueLbl.Hide();
            comp3ValueLbl.Hide();
        }

        private void StartGame()
        {
            if (nameBox.TextLength < 1)
            {
                MessageBox.Show("Please enter a name to play!", "NAME REQUIRED");
            } else
            {
                if (selectComputer1.Checked)
                {
                    // Dealer, player, computer 1
                    playerCount = 3;
                    Console.WriteLine("Player Count: " + playerCount);
                    computer1Lbl.Show();
                    com1Card1.Image = cardBack;
                    com1Card2.Image = cardBack;
                } else if (selectComputer2.Checked)
                {
                    // Dealer, player, computer 1, computer 2
                    playerCount = 4;
                    Console.WriteLine("Player Count: " + playerCount);
                    computer1Lbl.Show();
                    computer2Lbl.Show();
                    com1Card1.Image = cardBack;
                    com1Card2.Image = cardBack;
                    com2Card1.Image = cardBack;
                    com2Card2.Image = cardBack;
                } else if (selectComputer3.Checked)
                {
                    // Dealer, player, computer 1, computer 2, computer 3
                    playerCount = 5;
                    Console.WriteLine("Player Count: " + playerCount);
                    computer1Lbl.Show();
                    computer2Lbl.Show();
                    computer3Lbl.Show();
                    com1Card1.Image = cardBack;
                    com2Card1.Image = cardBack;
                    com3Card1.Image = cardBack;
                    com1Card2.Image = cardBack;
                    com2Card2.Image = cardBack;
                    com3Card2.Image = cardBack;
                } else
                {
                    // Default - Dealer, player, computer 1
                    playerCount = 3;
                    Console.WriteLine("Player Count: " + playerCount);
                    computer1Lbl.Show();
                    com1Card1.Image = cardBack;
                    com1Card2.Image = cardBack;
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

                com1Card1.SizeMode = PictureBoxSizeMode.StretchImage;
                com1Card2.SizeMode = PictureBoxSizeMode.StretchImage;
                com2Card1.SizeMode = PictureBoxSizeMode.StretchImage;
                com2Card2.SizeMode = PictureBoxSizeMode.StretchImage;
                com3Card1.SizeMode = PictureBoxSizeMode.StretchImage;
                com3Card2.SizeMode = PictureBoxSizeMode.StretchImage;

                // Dealer's hidden card.
                dealerHiddenCard.Show();
                dealerCard2.Show();
                dealerCard1.SizeMode = PictureBoxSizeMode.StretchImage;
                dealerCard2.SizeMode = PictureBoxSizeMode.StretchImage;
                dealerHiddenCard.SizeMode = PictureBoxSizeMode.StretchImage;
                userCard1.SizeMode = PictureBoxSizeMode.StretchImage;
                userCard2.SizeMode = PictureBoxSizeMode.StretchImage;

                userCard1.Image = cardBack;
                userCard2.Image = cardBack;
                dealerCard1.Image = cardBack;
                dealerCard2.Image = cardBack;
                dealerHiddenCard.Image = cardBack;

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
            if (computer1Lbl.Visible == true) {
                playerCount = 3;
            } if (computer2Lbl.Visible == true)
            {
                playerCount = 4;
            } if (computer3Lbl.Visible == true) {
                playerCount = 5;
            }
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
            foreach (Hand h in players)
            {
                string cardString = "";
                foreach (Card c in h.cards)
                {
                    cardString += c.Value + ", ";
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
            comp1ValueLbl.Show();

            if (computer2Lbl.Visible == true)
            {
                comp2ValueLbl.Show();
            } if (computer3Lbl.Visible == true)
            {
                comp2ValueLbl.Show();
                comp3ValueLbl.Show();
            }


            // player
            Hand h = players[0];
            h.cardObjects.Add(userCard1);
            h.cardObjects.Add(userCard2);
            h.valueLabel = valueLabel;
            h.winLoseLbl = winLoseLbl;
            h.dealBtn = dealBtn;
            h.standBtn = standBtn;
            h.isPlayer = true;

            // player card dimensions
            h.cardX = 131;
            h.cardY = 194;
            h.cardLeft = 11;
            h.cardTop = 539;
            h.cardSep = 14;

            h.showCards();

            // dealer
            Hand dlr = players[1];
            dlr.cardObjects.Add(dealerCard1);
            dlr.cardObjects.Add(dealerCard2);
            dlr.valueLabel = dealerValueLbl;
            dlr.winLoseLbl = winLoseLbl;
            dlr.dealBtn = dealBtn;
            dlr.standBtn = standBtn;
            dlr.isDealer = true;

            // dealer card dimensions
            dlr.cardX = 107;
            dlr.cardY = 141;
            dlr.cardLeft = 377;
            dlr.cardTop = 50;
            dlr.cardSep = 13;

            dlr.showCards();

            Hand comp1 = players[2];
            comp1.cardObjects.Add(com1Card1);
            comp1.cardObjects.Add(com1Card2);
            comp1.valueLabel = comp1ValueLbl;
            comp1.winLoseLbl = comp1Bust;
            comp1.dealBtn = dealBtn;
            comp1.standBtn = standBtn;

            // computer 1 card dimensions
            comp1.cardX = 83;
            comp1.cardY = 117;
            comp1.cardLeft = 890;
            comp1.cardTop = 158;
            comp1.cardSep = 16;

            comp1.showCards();

            if (computer2Lbl.Visible == true)
            {
                // computer 2
                Hand comp2 = players[3];
                comp2.cardObjects.Add(com2Card1);
                comp2.cardObjects.Add(com2Card2);
                comp2.valueLabel = comp2ValueLbl;
                comp2.winLoseLbl = comp2Bust;
                comp2.dealBtn = dealBtn;
                comp2.standBtn = standBtn;

                // computer 2 card dimensions
                comp2.cardX = 83;
                comp2.cardY = 117;
                comp2.cardLeft = 890;
                comp2.cardTop = 309;
                comp2.cardSep = 16;

                comp2.showCards();
            }

            if (computer3Lbl.Visible == true)
            {
                // computer 3
                Hand comp3 = players[4];
                comp3.cardObjects.Add(com3Card1);
                comp3.cardObjects.Add(com3Card2);
                comp3.valueLabel = comp3ValueLbl;
                comp3.winLoseLbl = comp3Bust;
                comp3.dealBtn = dealBtn;
                comp3.standBtn = standBtn;

                // computer 3 card dimensions
                comp3.cardX = 83;
                comp3.cardY = 117;
                comp3.cardLeft = 890;
                comp3.cardTop = 464;
                comp3.cardSep = 16;

                comp3.showCards();
            }

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

        public void ShowDealerCard()
        {
            // This happens when someone loses and all values are revealed, including the Dealer's hidden card, or when the dealer reveals their card at the end.
            dealerCard1.Show();
            dealerHiddenCard.Hide();
            dealerValueLbl.Show();
        }

        private void CreateDeck()
        {
            string[] suits = { "hearts", "spades", "diamonds", "clubs" };
            string[] uCodes = { "\u2665", "\u2660", "\u2666", "\u2663" };
            Brush[] colors = { Brushes.Red, Brushes.Black, Brushes.Red, Brushes.Black };
            byte[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };
            string[] names = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            for (int n = 1; n <= numberOfDecks; n++) {
                for (int s = 0; s <= 3; s++)
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

            for (int i = 0; i <= shuffleamount; i++)
            {
                Card temp = new Card();
                int card1 = r.Next(deck.Count() - 1);
                int card2 = r.Next(deck.Count() - 1);

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

            if (int.Parse(h.calculateValue().ToString()) > 21)
            {
                plrTotal = 0;
                descLbl.Text = "You have busted...";
                plrBust = true;
                descLbl.ForeColor = Color.Red;
                Wait(2000);
                Computer1AI();
            }
        }

        // Start game button
        private void startCardsBtn_Click(object sender, EventArgs e)
        {
            GetCards();
        }

        // Stand button
        private void standBtn_Click(object sender, EventArgs e)
        {
            Hand h = players[0];
            plrTotal = h.calculateValue();
            standBtn.Enabled = false;
            dealBtn.Enabled = false;
            descLbl.Text = "You have chosen to stand.";
            Wait(1500);

            Computer1AI();
        }

        // Computer 1
        private void Computer1AI()
        {
            Wait(1500);
            descLbl.ForeColor = Color.Black;
            descLbl.Text = "Computer 1 is deciding...";
            currentTurnLbl.Text = "TURN: Computer 1";
            Wait(1500);
            c1Bust = false;

            Hand c1 = players[2];

            if (int.Parse(c1.calculateValue().ToString()) < 18)
            {
                descLbl.Text = "Computer 1 has decided to hit.";
                Wait(1000);
                c1.addCard(deck[0]);
                deck.Remove(deck[0]);
                c1.showCards();
                if (int.Parse(c1.calculateValue().ToString()) > 21)
                {
                    c1Total = 0;
                    descLbl.Text = "Computer 1 has busted.";
                    c1Bust = true;
                    descLbl.ForeColor = Color.Red;
                    Wait(2000);
                    descLbl.ForeColor = Color.Black;
                    Computer2AI();
                }
                else if (int.Parse(c1.calculateValue().ToString()) <= 17)
                {
                    Wait(1500);
                    descLbl.Text = "Computer 1 is deciding...";
                    Wait(1500);
                    descLbl.Text = "Computer 1 has decided to hit.";
                    Wait(1000);
                    c1.addCard(deck[0]);
                    deck.Remove(deck[0]);
                    c1.showCards();
                    if (int.Parse(c1.calculateValue().ToString()) > 21)
                    {
                        c1Total = 0;
                        descLbl.Text = "Computer 1 has busted.";
                        c1Bust = true;
                        descLbl.ForeColor = Color.Red;
                        Wait(2000);
                        descLbl.ForeColor = Color.Black;
                        Computer2AI();
                    }
                    else if (int.Parse(c1.calculateValue().ToString()) <= 21)
                    {
                        c1Total = c1.calculateValue();
                        descLbl.Text = "Computer 1 is deciding...";
                        Wait(1500);
                        descLbl.Text = "Computer 1 has decided to stand.";
                        Wait(1500);
                        Computer2AI();
                    }
                }
                else
                {
                    c1Total = c1.calculateValue();
                    Wait(1500);
                    descLbl.Text = "Computer 1 is deciding...";
                    Wait(1500);
                    descLbl.Text = "Computer 1 has decided to stand.";
                    Wait(2000);
                    Computer2AI();
                }
            }
            else
            {
                c1Total = c1.calculateValue();
                descLbl.ForeColor = Color.Black;
                Wait(1500);
                descLbl.Text = "Computer 1 has decided to stand.";
                Wait(2000);
                Computer2AI();
            }
        }

        // Computer 2
        private void Computer2AI()
        {
            if (computer2Lbl.Visible == true)
            {
                currentTurnLbl.Text = "TURN: Computer 2";
                descLbl.Text = "Computer 2 is deciding...";
                Wait(1500);
                c2Bust = false;

                Hand c2 = players[3];

                if (int.Parse(c2.calculateValue().ToString()) < 18)
                {
                    descLbl.Text = "Computer 2 has decided to hit.";
                    Wait(1000);
                    c2.addCard(deck[0]);
                    deck.Remove(deck[0]);
                    c2.showCards();
                    if (int.Parse(c2.calculateValue().ToString()) > 21)
                    {
                        c2Total = 0;
                        descLbl.Text = "Computer 2 has busted.";
                        c2Bust = true;
                        descLbl.ForeColor = Color.Red;
                        Wait(2000);
                        descLbl.ForeColor = Color.Black;
                        Computer3AI();
                    }
                    else if (int.Parse(c2.calculateValue().ToString()) <= 17)
                    {
                        Wait(1500);
                        descLbl.Text = "Computer 2 is deciding...";
                        Wait(1500);
                        descLbl.Text = "Computer 2 has decided to hit.";
                        Wait(1000);
                        c2.addCard(deck[0]);
                        deck.Remove(deck[0]);
                        c2.showCards();
                        if (int.Parse(c2.calculateValue().ToString()) > 21)
                        {
                            c2Total = 0;
                            descLbl.Text = "Computer 2 has busted.";
                            c2Bust = true;
                            descLbl.ForeColor = Color.Red;
                            Wait(2000);
                            descLbl.ForeColor = Color.Black;
                            Computer3AI();
                        }
                        else if (int.Parse(c2.calculateValue().ToString()) <= 21)
                        {
                            c2Total = c2.calculateValue();
                            descLbl.Text = "Computer 2 is deciding...";
                            Wait(1500);
                            descLbl.Text = "Computer 2 has decided to stand.";
                            Wait(1500);
                            Computer3AI();
                        }
                    }
                    else
                    {
                        c2Total = c2.calculateValue();
                        Wait(1500);
                        descLbl.Text = "Computer 2 is deciding...";
                        Wait(1500);
                        descLbl.Text = "Computer 2 has decided to stand.";
                        Wait(2000);
                        Computer3AI();
                    }
                }
                else
                {
                    c2Total = c2.calculateValue();
                    descLbl.ForeColor = Color.Black;
                    Wait(1500);
                    descLbl.Text = "Computer 2 has decided to stand.";
                    Computer2AI();
                }
            }
            // DEALER (NO COMPUTER 2)
            else
            {
                DealerAI();
            }
        }

        // Computer 3
        private void Computer3AI()
        {
            if (computer3Lbl.Visible == true)
            {
                currentTurnLbl.Text = "TURN: Computer 3";
                descLbl.Text = "Computer 3 is deciding...";
                Wait(1500);
                c3Bust = false;

                Hand c3 = players[4];

                if (int.Parse(c3.calculateValue().ToString()) < 18)
                {
                    descLbl.Text = "Computer 3 has decided to hit.";
                    Wait(1000);
                    c3.addCard(deck[0]);
                    deck.Remove(deck[0]);
                    c3.showCards();
                    if (int.Parse(c3.calculateValue().ToString()) > 21)
                    {
                        c3Total = 0;
                        descLbl.Text = "Computer 3 has busted.";
                        c3Bust = true;
                        descLbl.ForeColor = Color.Red;
                        Wait(2000);
                        descLbl.ForeColor = Color.Black;
                        DealerAI();
                    }
                    else if (int.Parse(c3.calculateValue().ToString()) <= 17)
                    {
                        Wait(1500);
                        descLbl.Text = "Computer 3 is deciding...";
                        Wait(1500);
                        descLbl.Text = "Computer 3 has decided to hit.";
                        Wait(1000);
                        c3.addCard(deck[0]);
                        deck.Remove(deck[0]);
                        c3.showCards();
                        if (int.Parse(c3.calculateValue().ToString()) > 21)
                        {
                            c3Total = 0;
                            descLbl.Text = "Computer 3 has busted.";
                            c3Bust = true;
                            descLbl.ForeColor = Color.Red;
                            Wait(2000);
                            descLbl.ForeColor = Color.Black;
                            DealerAI();
                        }
                        else if (int.Parse(c3.calculateValue().ToString()) <= 21)
                        {
                            c3Total = c3.calculateValue();
                            descLbl.Text = "Computer 3 is deciding...";
                            Wait(1500);
                            descLbl.Text = "Computer 3 has decided to stand.";
                            Wait(1500);
                            DealerAI();
                        }
                    }
                    else
                    {
                        c3Total = c3.calculateValue();
                        Wait(1500);
                        descLbl.Text = "Computer 3 is deciding...";
                        Wait(1500);
                        descLbl.Text = "Computer 3 has decided to stand.";
                        Wait(2000);
                        DealerAI ();
                    }
                }
                else
                {
                    c3Total = c3.calculateValue();
                    descLbl.ForeColor = Color.Black;
                    Wait(1500);
                    descLbl.Text = "Computer 3 has decided to stand.";
                    DealerAI();
                }
            }
            // DEALER (NO COMPUTER 3)
            else
            {
                DealerAI();
            }
        }

        private void DealerAI()
        {
            currentTurnLbl.Text = "TURN: Dealer";
            descLbl.Text = "Dealer is deciding...";

            Hand dlr = players[1];
            Wait(1500);

            // If everyone has busted
            if ((plrBust == true) && (c1Bust == true) && (c2Bust == true) && (c3Bust == true))
            {
                descLbl.Text = "Everyone has busted, game over.";
                ShowDealerCard();
                dealerValueLbl.Text = "Final Value: " + dlr.calculateValue().ToString();
            } 
            // If not everyone has busted
            else
            {
                descLbl.Text = "Dealer is deciding...";
                Wait(1500);

                if (int.Parse(dlr.calculateValue().ToString()) < 17)
                {
                    Wait(1500);
                    descLbl.Text = "Dealer has decided to hit.";
                    dlr.addCard(deck[0]);
                    deck.Remove(deck[0]);
                    dlr.showCards();
                    Wait(1500);
                    descLbl.Text = "Dealer is deciding...";
                    if (int.Parse(dlr.calculateValue().ToString()) < 17)
                    {
                        Wait(1500);
                        descLbl.Text = "Dealer has decided to hit.";
                        dlr.addCard(deck[0]);
                        deck.Remove(deck[0]);
                        dlr.showCards();
                        Wait(1500);
                        if (int.Parse(dlr.calculateValue().ToString()) > 21)
                        {
                            dlrTotal = 0;
                            descLbl.Text = "Dealer has busted.";
                            descLbl.ForeColor = Color.Red;
                            Wait(2000);
                            ShowDealerCard();
                            dealerValueLbl.Text = "Final Value: " + dlr.calculateValue().ToString();
                            CalculateWinner();
                        }
                        else if (int.Parse(dlr.calculateValue().ToString()) < 21)
                        {
                            dlrTotal = dlr.calculateValue();
                            descLbl.Text = "Dealer is deciding...";
                            Wait(1500);
                            descLbl.Text = "Dealer has decided to stand.";
                            Wait(1500);
                            descLbl.Text = "Dealer is revealing their other card...";
                            ShowDealerCard();
                            dealerValueLbl.Text = "Value: " + dlr.calculateValue().ToString();

                            CalculateWinner();
                        }
                    }
                    else if (int.Parse(dlr.calculateValue().ToString()) > 21)
                    {
                        dlrTotal = 0;
                        descLbl.Text = "Dealer has busted.";
                        descLbl.ForeColor = Color.Red;
                        Wait(2000);
                        ShowDealerCard();
                        dealerValueLbl.Text = "Final Value: " + dlr.calculateValue().ToString();
                        CalculateWinner();
                    }
                }
                else if (int.Parse(dlr.calculateValue().ToString()) >= 17)
                {
                    dlrTotal = dlr.calculateValue();
                    descLbl.Text = "Dealer has decided to stand.";
                    Wait(1500);
                    descLbl.Text = "Dealer is revealing their other card...";
                    ShowDealerCard();
                    dealerValueLbl.Text = "Value: " + dlr.calculateValue().ToString();

                    CalculateWinner();
                }
            }
        }

        private void CalculateWinner()
        {
            int[] playerTotals = { plrTotal, c1Total, c2Total, c3Total, dlrTotal };
            int winningValue = playerTotals.Max();

            if (winningValue == plrTotal)
            {
                descLbl.Text = nameBox.Text + " WINS!";
                descLbl.ForeColor = Color.Green;
            } else if (winningValue == c1Total)
            {
                descLbl.Text = "COMPUTER 1 WINS!";
                descLbl.ForeColor = Color.Orange;
            }
            else if (winningValue == c2Total)
            {
                descLbl.Text = "COMPUTER 2 WINS!";
                descLbl.ForeColor = Color.Orange;
            }
            else if (winningValue == c3Total)
            {
                descLbl.Text = "COMPUTER 3 WINS!";
                descLbl.ForeColor = Color.Orange;
            }
            else if (winningValue == c2Total)
            {
                descLbl.Text = "DEALER WINS!";
                descLbl.ForeColor = Color.Orange;
            }
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
