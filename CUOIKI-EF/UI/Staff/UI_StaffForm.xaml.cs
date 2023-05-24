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

namespace CUOIKI_EF.UI.Staff
{
    /// <summary>
    /// Interaction logic for UI_StaffForm.xaml
    /// </summary>
    public partial class UI_StaffForm : Window
    {
        public UI_StaffForm()
        {
            InitializeComponent();
        }
        public void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        //public bool IsMaximized = false;

        //public void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    if (e.ClickCount == 2)
        //    {
        //        if (IsMaximized)
        //        {
        //            this.WindowState = WindowState.Normal;
        //            this.Width = 1080;
        //            this.Height = 720;

        //            IsMaximized = false;
        //        }
        //        else
        //        {
        //            this.WindowState = WindowState.Maximized;

        //            IsMaximized = true;
        //        }
        //    }
        //}

        private void btn_Information_click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new InformationPage());
        }

        private void btn_WorkSession_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new WorkSessionForm());
        }

        private void btn_LeaveOfAbsence_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new LeaveOfAbsenceForm());
        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btn_ViewTask_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new StaffTaskManagementForm());
        }
    }
}
