﻿using System;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Skylar_home
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double sidepanelWidth;
        double mainpanelWidth;
        bool hidden;
        public MainWindow()
        {
            InitializeComponent();
            sidepanelWidth = sidePanel.Width;
            mainpanelWidth = mainPanel.Width;
        }
       
    }
}
