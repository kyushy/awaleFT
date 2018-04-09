using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Awale.modele
{
    public class Player : INotifyPropertyChanged
    {
        private string _name;
        private string _ip;
        private int _score;

        public Player(string name, string ip)
        {
            this.Name = name;
            this.Ip = ip;
            this.Score = 0;
        }

        public string Name { get => _name; set => _name = value; }
        public string Ip { get => _ip; set => _ip = value; }
        public int Score { get => _score; set { _score = value; OnPropertyChanged("Score"); } }

        public event PropertyChangedEventHandler PropertyChanged;

        // Create the OnPropertyChanged method to raise the event
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
