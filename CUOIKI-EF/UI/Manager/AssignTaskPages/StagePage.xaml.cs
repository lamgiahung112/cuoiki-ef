using CUOIKI_EF.States;
using CUOIKI_EF.ViewModels;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CUOIKI_EF.UI.Manager.AssignTaskPages
{
    /// <summary>
    /// Interaction logic for StagePage.xaml
    /// </summary>
    public partial class StagePage : Page
    {
        public StagePage()
        {
            InitializeComponent();
            this.DataContext = new StagePageViewModel();
        }
        private void back_click(object sender, RoutedEventArgs e)
        {
            TaskAssignmentState.SelectedStage = null;
            NavigationService.GoBack();
        }

        private void BtnStageItem_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            btn.Command.Execute(btn.CommandParameter);
            NavigationService.Navigate(new TeamPage());
        }

        private void BtnStageItem_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            var btn = sender as Button;
            btn.Command.Execute(btn.CommandParameter);
        }

        private void ViewMenuItem_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TeamPage());
        }
    }
}
