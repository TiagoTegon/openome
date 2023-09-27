﻿using Openome.Views;
using System.Windows;

namespace Openome
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MetronomeFrame.Content = new MetronomeView();
        }
    }
}
