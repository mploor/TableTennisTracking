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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TableTennisTracker
{
    /// <summary>
    /// Interaction logic for Splash.xaml
    /// </summary>
    public partial class Splash : Page
    {
        public Splash()
        {
            InitializeComponent();
        }

        private async void NewGame(object sender, RoutedEventArgs e)
        {
            PBMain.Visibility = Visibility.Visible;
            await Task.Delay(1900);
            if (GlobalClass.tableHeight == 0)
            {
                NavigationService.Navigate(new Calibration());
            }
            else
            {
                NavigationService.Navigate(new SelectPlayers());
            }

        }

        private async void NewPlayer(object sender, RoutedEventArgs e)
        {
            PBMain.Visibility = Visibility.Visible;
            await Task.Delay(1900);
            NavigationService.Navigate(new NewPlayer());


        }
        private async void Leaderboard(object sender, RoutedEventArgs e)
        {

            PBMain.Visibility = Visibility.Visible;
            await Task.Delay(1900);
            NavigationService.Navigate(new Leaderboard());


        }
    }
}
