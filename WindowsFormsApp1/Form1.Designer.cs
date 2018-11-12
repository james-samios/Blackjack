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
            this.userCard3 = new System.Windows.Forms.PictureBox();
            this.userCard4 = new System.Windows.Forms.PictureBox();
            this.userCard5 = new System.Windows.Forms.PictureBox();
            this.userCard6 = new System.Windows.Forms.PictureBox();
            this.restartBtn = new System.Windows.Forms.Button();
            this.currentTurnLbl = new System.Windows.Forms.Label();
            this.descLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCard6)).BeginInit();
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
            this.startGameBtn.Location = new System.Drawing.Point(1135, 10);
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
            this.startCardsBtn.Text = "Get First Cards";
            this.startCardsBtn.UseVisualStyleBackColor = true;
            this.startCardsBtn.Click += new System.EventHandler(this.startCardsBtn_Click);
            // 
            // userCard3
            // 
            this.userCard3.Location = new System.Drawing.Point(386, 501);
            this.userCard3.Margin = new System.Windows.Forms.Padding(2);
            this.userCard3.Name = "userCard3";
            this.userCard3.Size = new System.Drawing.Size(169, 231);
            this.userCard3.TabIndex = 9;
            this.userCard3.TabStop = false;
            // 
            // userCard4
            // 
            this.userCard4.Location = new System.Drawing.Point(570, 501);
            this.userCard4.Margin = new System.Windows.Forms.Padding(2);
            this.userCard4.Name = "userCard4";
            this.userCard4.Size = new System.Drawing.Size(169, 231);
            this.userCard4.TabIndex = 10;
            this.userCard4.TabStop = false;
            // 
            // userCard5
            // 
            this.userCard5.Location = new System.Drawing.Point(753, 501);
            this.userCard5.Margin = new System.Windows.Forms.Padding(2);
            this.userCard5.Name = "userCard5";
            this.userCard5.Size = new System.Drawing.Size(169, 231);
            this.userCard5.TabIndex = 11;
            this.userCard5.TabStop = false;
            // 
            // userCard6
            // 
            this.userCard6.Location = new System.Drawing.Point(935, 501);
            this.userCard6.Margin = new System.Windows.Forms.Padding(2);
            this.userCard6.Name = "userCard6";
            this.userCard6.Size = new System.Drawing.Size(169, 231);
            this.userCard6.TabIndex = 12;
            this.userCard6.TabStop = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1328, 741);
            this.Controls.Add(this.descLbl);
            this.Controls.Add(this.currentTurnLbl);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.userCard6);
            this.Controls.Add(this.userCard5);
            this.Controls.Add(this.userCard4);
            this.Controls.Add(this.userCard3);
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
            ((System.ComponentModel.ISupportInitialize)(this.userCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCard6)).EndInit();
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
        private System.Windows.Forms.PictureBox userCard3;
        private System.Windows.Forms.PictureBox userCard4;
        private System.Windows.Forms.PictureBox userCard5;
        private System.Windows.Forms.PictureBox userCard6;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Label currentTurnLbl;
        private System.Windows.Forms.Label descLbl;
    }
}

