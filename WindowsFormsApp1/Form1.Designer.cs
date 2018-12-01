namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userCard1 = new System.Windows.Forms.PictureBox();
            this.userCard2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.startGameBtn = new System.Windows.Forms.Button();
            this.endGameBtn = new System.Windows.Forms.Button();
            this.dealBtn = new System.Windows.Forms.Button();
            this.standBtn = new System.Windows.Forms.Button();
            this.startCardsBtn = new System.Windows.Forms.Button();
            this.restartBtn = new System.Windows.Forms.Button();
            this.currentTurnLbl = new System.Windows.Forms.Label();
            this.descLbl = new System.Windows.Forms.Label();
            this.winLoseLbl = new System.Windows.Forms.Label();
            this.dealerLbl = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.selectComputer1 = new System.Windows.Forms.RadioButton();
            this.selectComputer2 = new System.Windows.Forms.RadioButton();
            this.selectComputer3 = new System.Windows.Forms.RadioButton();
            this.dealerCard1 = new System.Windows.Forms.PictureBox();
            this.dealerCard2 = new System.Windows.Forms.PictureBox();
            this.computer1Lbl = new System.Windows.Forms.Label();
            this.computer2Lbl = new System.Windows.Forms.Label();
            this.computer3Lbl = new System.Windows.Forms.Label();
            this.com1Card1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.userCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.com1Card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // userCard1
            // 
            this.userCard1.Location = new System.Drawing.Point(11, 502);
            this.userCard1.Margin = new System.Windows.Forms.Padding(2);
            this.userCard1.Name = "userCard1";
            this.userCard1.Size = new System.Drawing.Size(169, 231);
            this.userCard1.TabIndex = 0;
            this.userCard1.TabStop = false;
            this.userCard1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // userCard2
            // 
            this.userCard2.Location = new System.Drawing.Point(200, 502);
            this.userCard2.Margin = new System.Windows.Forms.Padding(2);
            this.userCard2.Name = "userCard2";
            this.userCard2.Size = new System.Drawing.Size(169, 231);
            this.userCard2.TabIndex = 1;
            this.userCard2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "BLACKJACK";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLabel.Location = new System.Drawing.Point(12, 464);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(88, 25);
            this.valueLabel.TabIndex = 3;
            this.valueLabel.Text = "Value: ";
            this.valueLabel.Click += new System.EventHandler(this.valueLabel_Click);
            // 
            // startGameBtn
            // 
            this.startGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameBtn.Location = new System.Drawing.Point(544, 309);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(181, 36);
            this.startGameBtn.TabIndex = 4;
            this.startGameBtn.Text = "START GAME";
            this.startGameBtn.UseVisualStyleBackColor = true;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // endGameBtn
            // 
            this.endGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endGameBtn.Location = new System.Drawing.Point(1135, 9);
            this.endGameBtn.Name = "endGameBtn";
            this.endGameBtn.Size = new System.Drawing.Size(181, 36);
            this.endGameBtn.TabIndex = 5;
            this.endGameBtn.Text = "END GAME";
            this.endGameBtn.UseVisualStyleBackColor = true;
            this.endGameBtn.Click += new System.EventHandler(this.endGameBtn_Click);
            // 
            // dealBtn
            // 
            this.dealBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealBtn.Location = new System.Drawing.Point(1119, 679);
            this.dealBtn.Name = "dealBtn";
            this.dealBtn.Size = new System.Drawing.Size(197, 53);
            this.dealBtn.TabIndex = 6;
            this.dealBtn.Text = "Hit";
            this.dealBtn.UseVisualStyleBackColor = true;
            this.dealBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // standBtn
            // 
            this.standBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standBtn.Location = new System.Drawing.Point(1119, 610);
            this.standBtn.Name = "standBtn";
            this.standBtn.Size = new System.Drawing.Size(197, 53);
            this.standBtn.TabIndex = 7;
            this.standBtn.Text = "Stand";
            this.standBtn.UseVisualStyleBackColor = true;
            this.standBtn.Click += new System.EventHandler(this.standBtn_Click);
            // 
            // startCardsBtn
            // 
            this.startCardsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startCardsBtn.Location = new System.Drawing.Point(386, 679);
            this.startCardsBtn.Name = "startCardsBtn";
            this.startCardsBtn.Size = new System.Drawing.Size(299, 53);
            this.startCardsBtn.TabIndex = 8;
            this.startCardsBtn.Text = "DEAL";
            this.startCardsBtn.UseVisualStyleBackColor = true;
            this.startCardsBtn.Click += new System.EventHandler(this.startCardsBtn_Click);
            // 
            // restartBtn
            // 
            this.restartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartBtn.Location = new System.Drawing.Point(1135, 52);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(181, 36);
            this.restartBtn.TabIndex = 13;
            this.restartBtn.Text = "RESTART";
            this.restartBtn.UseVisualStyleBackColor = true;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // currentTurnLbl
            // 
            this.currentTurnLbl.AutoSize = true;
            this.currentTurnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTurnLbl.Location = new System.Drawing.Point(12, 84);
            this.currentTurnLbl.Name = "currentTurnLbl";
            this.currentTurnLbl.Size = new System.Drawing.Size(106, 31);
            this.currentTurnLbl.TabIndex = 14;
            this.currentTurnLbl.Text = "TURN: ";
            // 
            // descLbl
            // 
            this.descLbl.AutoSize = true;
            this.descLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLbl.Location = new System.Drawing.Point(14, 125);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(0, 24);
            this.descLbl.TabIndex = 15;
            // 
            // winLoseLbl
            // 
            this.winLoseLbl.AutoSize = true;
            this.winLoseLbl.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLoseLbl.Location = new System.Drawing.Point(14, 430);
            this.winLoseLbl.Name = "winLoseLbl";
            this.winLoseLbl.Size = new System.Drawing.Size(0, 25);
            this.winLoseLbl.TabIndex = 16;
            // 
            // dealerLbl
            // 
            this.dealerLbl.AutoSize = true;
            this.dealerLbl.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerLbl.Location = new System.Drawing.Point(583, 20);
            this.dealerLbl.Name = "dealerLbl";
            this.dealerLbl.Size = new System.Drawing.Size(102, 25);
            this.dealerLbl.TabIndex = 17;
            this.dealerLbl.Text = "DEALER";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(544, 196);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(181, 23);
            this.nameBox.TabIndex = 18;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Verdana", 9.25F);
            this.nameLbl.Location = new System.Drawing.Point(541, 177);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(50, 16);
            this.nameLbl.TabIndex = 19;
            this.nameLbl.Text = "Name:";
            // 
            // selectComputer1
            // 
            this.selectComputer1.AutoSize = true;
            this.selectComputer1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectComputer1.Location = new System.Drawing.Point(544, 225);
            this.selectComputer1.Name = "selectComputer1";
            this.selectComputer1.Size = new System.Drawing.Size(121, 22);
            this.selectComputer1.TabIndex = 20;
            this.selectComputer1.TabStop = true;
            this.selectComputer1.Text = "1 Computer";
            this.selectComputer1.UseVisualStyleBackColor = true;
            // 
            // selectComputer2
            // 
            this.selectComputer2.AutoSize = true;
            this.selectComputer2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectComputer2.Location = new System.Drawing.Point(544, 253);
            this.selectComputer2.Name = "selectComputer2";
            this.selectComputer2.Size = new System.Drawing.Size(130, 22);
            this.selectComputer2.TabIndex = 21;
            this.selectComputer2.TabStop = true;
            this.selectComputer2.Text = "2 Computers";
            this.selectComputer2.UseVisualStyleBackColor = true;
            // 
            // selectComputer3
            // 
            this.selectComputer3.AutoSize = true;
            this.selectComputer3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectComputer3.Location = new System.Drawing.Point(544, 281);
            this.selectComputer3.Name = "selectComputer3";
            this.selectComputer3.Size = new System.Drawing.Size(130, 22);
            this.selectComputer3.TabIndex = 22;
            this.selectComputer3.TabStop = true;
            this.selectComputer3.Text = "3 Computers";
            this.selectComputer3.UseVisualStyleBackColor = true;
            // 
            // dealerCard1
            // 
            this.dealerCard1.Location = new System.Drawing.Point(377, 52);
            this.dealerCard1.Margin = new System.Windows.Forms.Padding(2);
            this.dealerCard1.Name = "dealerCard1";
            this.dealerCard1.Size = new System.Drawing.Size(107, 141);
            this.dealerCard1.TabIndex = 23;
            this.dealerCard1.TabStop = false;
            // 
            // dealerCard2
            // 
            this.dealerCard2.Location = new System.Drawing.Point(497, 50);
            this.dealerCard2.Margin = new System.Windows.Forms.Padding(2);
            this.dealerCard2.Name = "dealerCard2";
            this.dealerCard2.Size = new System.Drawing.Size(107, 141);
            this.dealerCard2.TabIndex = 24;
            this.dealerCard2.TabStop = false;
            // 
            // computer1Lbl
            // 
            this.computer1Lbl.AutoSize = true;
            this.computer1Lbl.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computer1Lbl.Location = new System.Drawing.Point(1139, 170);
            this.computer1Lbl.Name = "computer1Lbl";
            this.computer1Lbl.Size = new System.Drawing.Size(171, 25);
            this.computer1Lbl.TabIndex = 25;
            this.computer1Lbl.Text = "COMPUTER 1:";
            // 
            // computer2Lbl
            // 
            this.computer2Lbl.AutoSize = true;
            this.computer2Lbl.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computer2Lbl.Location = new System.Drawing.Point(1139, 309);
            this.computer2Lbl.Name = "computer2Lbl";
            this.computer2Lbl.Size = new System.Drawing.Size(171, 25);
            this.computer2Lbl.TabIndex = 26;
            this.computer2Lbl.Text = "COMPUTER 2:";
            // 
            // computer3Lbl
            // 
            this.computer3Lbl.AutoSize = true;
            this.computer3Lbl.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computer3Lbl.Location = new System.Drawing.Point(1139, 450);
            this.computer3Lbl.Name = "computer3Lbl";
            this.computer3Lbl.Size = new System.Drawing.Size(171, 25);
            this.computer3Lbl.TabIndex = 27;
            this.computer3Lbl.Text = "COMPUTER 3:";
            // 
            // com1Card1
            // 
            this.com1Card1.Location = new System.Drawing.Point(1030, 196);
            this.com1Card1.Margin = new System.Windows.Forms.Padding(2);
            this.com1Card1.Name = "com1Card1";
            this.com1Card1.Size = new System.Drawing.Size(68, 99);
            this.com1Card1.TabIndex = 28;
            this.com1Card1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1030, 341);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 99);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(1030, 485);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 99);
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1328, 741);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.com1Card1);
            this.Controls.Add(this.computer3Lbl);
            this.Controls.Add(this.computer2Lbl);
            this.Controls.Add(this.computer1Lbl);
            this.Controls.Add(this.dealerCard2);
            this.Controls.Add(this.dealerCard1);
            this.Controls.Add(this.selectComputer3);
            this.Controls.Add(this.selectComputer2);
            this.Controls.Add(this.selectComputer1);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.dealerLbl);
            this.Controls.Add(this.winLoseLbl);
            this.Controls.Add(this.descLbl);
            this.Controls.Add(this.currentTurnLbl);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.startCardsBtn);
            this.Controls.Add(this.standBtn);
            this.Controls.Add(this.dealBtn);
            this.Controls.Add(this.endGameBtn);
            this.Controls.Add(this.startGameBtn);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userCard2);
            this.Controls.Add(this.userCard1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BLACKJACK";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.com1Card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userCard1;
        private System.Windows.Forms.PictureBox userCard2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Button startGameBtn;
        private System.Windows.Forms.Button endGameBtn;
        private System.Windows.Forms.Button dealBtn;
        private System.Windows.Forms.Button standBtn;
        private System.Windows.Forms.Button startCardsBtn;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Label currentTurnLbl;
        private System.Windows.Forms.Label descLbl;
        private System.Windows.Forms.Label winLoseLbl;
        private System.Windows.Forms.Label dealerLbl;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.RadioButton selectComputer1;
        private System.Windows.Forms.RadioButton selectComputer2;
        private System.Windows.Forms.RadioButton selectComputer3;
        private System.Windows.Forms.PictureBox dealerCard1;
        private System.Windows.Forms.PictureBox dealerCard2;
        private System.Windows.Forms.Label computer1Lbl;
        private System.Windows.Forms.Label computer2Lbl;
        private System.Windows.Forms.Label computer3Lbl;
        private System.Windows.Forms.PictureBox com1Card1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

