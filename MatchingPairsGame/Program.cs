using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MatchingPairsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();

            while (true)
            {
                board.Draw();
                int turn1 = int.Parse(Console.ReadLine());
                board.Reveal(turn1);
                board.Draw();
                int turn2 = int.Parse(Console.ReadLine());
                board.Reveal(turn2);
                board.Draw();
                //TODO: check to see if they match
                Thread.Sleep(TimeSpan.FromSeconds(2));
                board.Hide(turn1);
                board.Hide(turn2);

            }

            
            
        }
    }
}
