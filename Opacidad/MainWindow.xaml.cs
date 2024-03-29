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

namespace Opacidad
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpacityImage_MouseEnter(object sender, MouseEventArgs e)
        {
            Image imagen = (Image)sender;

            imagen.Opacity = 1.0;
        }

        private void OpacityImage_MouseLeave(object sender, MouseEventArgs e)
        {
            Image imagen = (Image)sender;

            imagen.Opacity = 0.5;
        }
    }
}
