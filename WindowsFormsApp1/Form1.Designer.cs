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
            this.startCardsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCard2)).BeginInit();
            this.SuspendLayout();
            // 
            // userCard1
            // 
            this.userCard1.Location = new System.Drawing.Point(11, 411);
            this.userCard1.Margin = new System.Windows.Forms.Padding(2);
            this.userCard1.Name = "userCard1";
            this.userCard1.Size = new System.Drawing.Size(169, 231);
            this.userCard1.TabIndex = 0;
            this.userCard1.TabStop = false;
            this.userCard1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // userCard2
            // 
            this.userCard2.Location = new System.Drawing.Point(200, 411);
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
            this.valueLabel.Location = new System.Drawing.Point(12, 373);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(88, 25);
            this.valueLabel.TabIndex = 3;
            this.valueLabel.Text = "Value: ";
            this.valueLabel.Click += new System.EventHandler(this.valueLabel_Click);
            // 
            // startGameBtn
            // 
            this.startGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameBtn.Location = new System.Drawing.Point(851, 10);
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
            this.endGameBtn.Location = new System.Drawing.Point(851, 9);
            this.endGameBtn.Name = "endGameBtn";
            this.endGameBtn.Size = new System.Drawing.Size(181, 36);
            this.endGameBtn.TabIndex = 5;
            this.endGameBtn.Text = "END GAME";
            this.endGameBtn.UseVisualStyleBackColor = true;
            this.endGameBtn.Click += new System.EventHandler(this.endGameBtn_Click);
            // 
            // startCardsBtn
            // 
            this.startCardsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startCardsBtn.Location = new System.Drawing.Point(885, 588);
            this.startCardsBtn.Name = "startCardsBtn";
            this.startCardsBtn.Size = new System.Drawing.Size(147, 53);
            this.startCardsBtn.TabIndex = 6;
            this.startCardsBtn.Text = "Deal";
            this.startCardsBtn.UseVisualStyleBackColor = true;
            this.startCardsBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1044, 653);
            this.Controls.Add(this.startCardsBtn);
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
        private System.Windows.Forms.Button startCardsBtn;
    }
}

