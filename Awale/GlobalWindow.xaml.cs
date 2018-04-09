﻿using Awale.vue;
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
using System.Windows.Shapes;

namespace Awale
{
    /// <summary>
    /// Logique d'interaction pour GlobalWindow.xaml
    /// </summary>
    public partial class GlobalWindow : Window
    {
        public GlobalWindow()
        {
            InitializeComponent();
            this.pageContainer.Content = new HomePage();
        }
    }
}
