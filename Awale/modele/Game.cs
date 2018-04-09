using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Awale.modele
{
    public class Game : INotifyPropertyChanged
    {
        private GameBoard _gameBoard;
        private Player _p1;
        private Player _p2;
        private Player _currentPlayer;
        private bool victory = false;

        public Game(Player p1, Player p2)
        {
            this.P1 = p1;
            this.P2 = p2;
            this.GameBoard = new GameBoard();

            this.CurrentPlayer = P1;
        }

        public Player P1 { get => _p1; set { _p1 = value; OnPropertyChanged("P1"); } }
        public Player P2 { get => _p2; set { _p2 = value; OnPropertyChanged("P2"); } }
        public GameBoard GameBoard { get => _gameBoard; set => _gameBoard = value; }
        public Player CurrentPlayer { get => _currentPlayer; set { _currentPlayer = value; OnPropertyChanged("CurrentPlayer"); } }
        public bool Victory { get => victory; set => victory = value; }

        public event PropertyChangedEventHandler PropertyChanged;

        // Create the OnPropertyChanged method to raise the event
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void PickAndDispatchSeeds(int slot)
        {
            int seeds = GameBoard.PickSeeds(slot);
            GameBoard.DispatchSeeds(seeds);
            OnPropertyChanged("GameBoard");
        }

        public int GatherSeeds(int slot)
        {
            int points = GameBoard.GetOpponentSeeds(slot);
            OnPropertyChanged("GameBoard");
            return points;
        }
    }
}
