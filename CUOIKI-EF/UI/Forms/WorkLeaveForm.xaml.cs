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
    /// Interaction logic for WorkLeaveForm.xaml
    /// </summary>
    public partial class WorkLeaveForm : Window
    {
        public WorkLeaveForm(LeavePageViewModel vm)
        {
            InitializeComponent();
            this.DataContext = vm;
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
