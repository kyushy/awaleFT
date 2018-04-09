using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Awale.modele
{
    public class GameBoard
    {
        private CircularList<int> _board;

        public GameBoard()
        {
            Board = new CircularList<int>(12);
            Board.SetAll(4);
        }

        public CircularList<int> Board { get => _board; set => _board = value; }

        /// <summary>
        /// Get seeds from the selected slot
        /// </summary>
        /// <param name="slot"></param>
        /// <returns></returns>
        public int PickSeeds(int slot)
        {
            Board.SetCurrent(slot);
            int seeds = Board.Value;
            Board.Value = 0;
            return seeds;
        }

        /// <summary>
        /// Dispatch seeds in the next slot of the gameboard
        /// </summary>
        /// <param name="seeds"></param>
        /// <param name="slot"></param>
        public void DispatchSeeds(int seeds)
        {
            while (seeds != 0)
            {
                Board.Next();
                Board.Value++;
                seeds--;
            }
        }

        public int GetOpponentSeeds(int slot)
        {
            int seeds = 0;
            while(Board.Value > 1 && Board.Value < 4)
            {
                seeds += Board.Value;
                Board.Value = 0;
                Board.Prev();
            }
            return seeds;
        }
    }
}
