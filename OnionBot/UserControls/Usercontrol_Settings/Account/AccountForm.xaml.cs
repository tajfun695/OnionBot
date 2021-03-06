﻿using System;
using System.Net;
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
using System.IO;

namespace OnionBot.UserControls.Usercontrol_Settings.Account
{
    /// <summary>
    /// Interaction logic for AccountForm.xaml
    /// </summary>
    public partial class AccountForm : UserControl
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        private void btnTwitchConnect(object sender, RoutedEventArgs e)
        {
            TwitchLogin loginWindow = new TwitchLogin();
            loginWindow.Show();
            ConnectGrid.Visibility = Visibility.Collapsed;
            loginWindow.Closed += LoginWindow_Closed;
        }

        private void LoginWindow_Closed(object sender, EventArgs e)
        {
            userGrid.Visibility = Visibility.Visible;
        }
    }
}