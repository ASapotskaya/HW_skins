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

namespace HW_skins
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void bt_1_Click(object sender, RoutedEventArgs e)
        {
            ResourceDictionary newRD = new ResourceDictionary();
            newRD.Source = new Uri("Skin1.xaml", UriKind.Relative);
            Resources.MergedDictionaries[0] = newRD;
            LabelSkin.Content = "Скин №1";
        }

        private void bt_2_Click(object sender, RoutedEventArgs e)
        {
            ResourceDictionary newRD = new ResourceDictionary();
            newRD.Source = new Uri("Skin2.xaml", UriKind.Relative);
            Resources.MergedDictionaries[0] = newRD;
            LabelSkin.Content = "Скин №2";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResourceDictionary newRD = new ResourceDictionary();
            newRD.Source = new Uri("DefaultStyle.xaml", UriKind.Relative);
            Resources.MergedDictionaries[0] = newRD;
            LabelSkin.Content = "Скин по умолчанию";
        }

        private void bt_3_Click(object sender, RoutedEventArgs e)
        {
            ResourceDictionary newRD = new ResourceDictionary();
            newRD.Source = new Uri("Skin3.xaml", UriKind.Relative);
            Resources.MergedDictionaries[0] = newRD;
            LabelSkin.Content = "Скин №3";
        }
    }
}
