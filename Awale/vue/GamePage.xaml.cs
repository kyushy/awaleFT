using Awale.controller;
using Awale.modele;
using Awale.vue.components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Awale.vue
{
    /// <summary>
    /// Logique d'interaction pour GamePage.xaml
    /// </summary>
    public partial class GamePage : UserControl
    {
        private Manager _manager;
        private Game _game;

        public GamePage(Game game, Manager manager)
        {
            InitializeComponent();
            this.DataContext = game;
            this._game = game;
            this._manager = manager;
        }

        private void CircleBorder_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            CircleBorder circle = (CircleBorder)sender;
            int slot = Int32.Parse(circle.Name.Split('c')[1]);

            if((_game.CurrentPlayer == _game.P1 && slot < 6) || (_game.CurrentPlayer == _game.P2 && slot > 5))
            {
                _manager.Play(slot);
                if (_game.Victory)
                {
                    GlobalWindow win = (GlobalWindow)Window.GetWindow(this);
                    win.pageContainer.Content = new WinPage(_game.CurrentPlayer);
                }
            }
        }
    }
}
