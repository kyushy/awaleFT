using Awale.controller;
using Awale.modele;
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
    /// Logique d'interaction pour HomePage.xaml
    /// </summary>
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void localGameButton_Click(object sender, RoutedEventArgs e)
        {
            GlobalWindow win = (GlobalWindow)Window.GetWindow(this);
            Game game = new Game(new Player(this.playerNameBox.Text, ""), new Player("Joueur 2", ""));
            Manager manager = new Manager(game);
            win.pageContainer.Content = new GamePage(game, manager);
        }
    }
}
