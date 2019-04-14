using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchingPairsGame
{
    class Board
    {
        public List<Card> cards = new List<Card> {
            new Card('£'),
            new Card('£'),
            new Card('£'),
            new Card('£'),
            new Card('$'),
            new Card('$'),
            new Card('$'),
            new Card('$'),
            new Card('%'),
            new Card('%'),
            new Card('%'),
            new Card('%'),
            new Card('&'),
            new Card('&'),
            new Card('&'),
            new Card('&')
        };

        public void Draw()
        {
            Console.Clear();
            for (int i = 0; i < cards.Count; i++)
            {
                Console.WriteLine(cards[i].Visible ? cards[i].Image.ToString() : (i + 1).ToString());
                
            }
        }

        public void Reveal(int index)
        {
            cards[index - 1].Visible = true;
        }

        public void Hide(int index)
        {
            cards[index - 1].Visible = false;
        }
    }
}
