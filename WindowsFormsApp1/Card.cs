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
        
        private string makeCardCode()
        {
            string s = "";
            IDictionary<string, string> dict = new Dictionary<string, string>()
            {
                {"hearts",  "2"},
                {"spades", "1" },
                {"clubs", "4" },
                {"diamonds", "3" }
            };

            s += this.Name;
            s += "-";
            s += dict[this.Suit];

            return s;
        }

        public Image GetImage()
        {
             return Image.FromFile(@"../../Cards/" + makeCardCode() + ".png");

        }

        public string uCode { get; set; }
        public Brush color { get; set; }
        
    }
}
