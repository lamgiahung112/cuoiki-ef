﻿using CUOIKI_EF.ViewModels;
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

namespace CUOIKI_EF.UI.Forms
{
    /// <summary>
    /// Interaction logic for StageForm.xaml
    /// </summary>
    public partial class StageForm : Window
    {
        public StageForm(StagePageViewModel vm)
        {
            InitializeComponent();
            this.DataContext = vm;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
