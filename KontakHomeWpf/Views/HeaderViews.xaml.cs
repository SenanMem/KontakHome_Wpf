﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KontakHomeWpf.Views
{
    /// <summary>
    /// Interaction logic for HeaderViews.xaml
    /// </summary>
    public partial class HeaderViews : UserControl
    {
        public HeaderViews()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listBox.Visibility = Visibility.Visible;
        }
    }
}
