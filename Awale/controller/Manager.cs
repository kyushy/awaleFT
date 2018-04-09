using Awale.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Awale.controller
{
    public class Manager
    {
        private Game _game;

        public Manager(Game game)
        {
            this._game = game;
        }

        public void Play(int slot)
        {
            _game.PickAndDispatchSeeds(slot);
            if((_game.CurrentPlayer == _game.P1 && _game.GameBoard.Board.GetPosition() > 5) || 
                (_game.CurrentPlayer == _game.P2 && _game.GameBoard.Board.GetPosition() < 6))
                    _game.CurrentPlayer.Score += _game.GatherSeeds(_game.GameBoard.Board.GetPosition());

            if (_game.CurrentPlayer.Score >= 25)
                _game.Victory = true;
            else
            {
                //Switch Player
                if (_game.CurrentPlayer == _game.P1)
                    _game.CurrentPlayer = _game.P2;
                else
                    _game.CurrentPlayer = _game.P1;
            }
        }
    }
}
