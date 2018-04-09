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
    /// Logique d'interaction pour WinPage.xaml
    /// </summary>
    public partial class WinPage : UserControl
    {
        public WinPage(Player p)
        {
            InitializeComponent();
            this.DataContext = p;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GlobalWindow win = (GlobalWindow)Window.GetWindow(this);
            win.pageContainer.Content = new HomePage();
        }
    }
}
