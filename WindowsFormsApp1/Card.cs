using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Card
    {
        public string Suit { get; set; }
        public byte Value { get; set; }
        public string Name { get; set; }
        public bool Ace { get; set; }
        public string uCode { get; set; }
        public Brush color { get; set; }
        
        public string GetImage()
        {
            // https://docs.microsoft.com/en-us/dotnet/framework/winforms/advanced/how-to-create-a-bitmap-at-run-time

            Bitmap cardImage = new Bitmap(169, 231);
            Graphics cardGraphics = Graphics.FromImage(cardImage);

            //cardGraphics.FillRectangle(Brushes.White, 0, 0, 169, 231);

            Point vPoint = new Point();
            vPoint.X = 0;
            vPoint.Y = 0;

            Point sPoint = new Point();
            sPoint.X = 110;
            sPoint.Y = 160;

            Font vfont = new Font("Helvetica", 50);
            Font sfont = new Font("Helvetica", 50);

            //cardGraphics.DrawString(this.Value.ToString(), vfont, this.color, vPoint);
            //cardGraphics.DrawString(this.uCode, sfont, this.color, sPoint); 

            string cardSettings = (this.Name);
            

            return cardSettings;
        }
    }
}
