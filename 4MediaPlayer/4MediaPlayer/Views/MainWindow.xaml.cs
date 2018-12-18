﻿using Microsoft.Win32;
using System.Windows;

namespace _4MediaPlayer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadVideo_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog
            {
                CheckFileExists = true,
            };
            if (myDialog.ShowDialog() == true)
            {
                mediaPlayer.MediaPath = myDialog.FileName;
            }
        }

        private void StartStopVideoButton_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.PlayClick();
        }
    }
}
