using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchingPairsGame
{
    class Card
    {
        public char Image { get; set; }
        public bool Visible { get; set; }

        public Card(char image)
        {
            Image = image;
            Visible = false;
        }
    }
}
