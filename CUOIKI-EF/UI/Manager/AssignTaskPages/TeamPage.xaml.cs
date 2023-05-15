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
    /// Interaction logic for TeamPage.xaml
    /// </summary>
    public partial class TeamPage : Page
    {
        public TeamPage()
        {
            InitializeComponent();
            this.DataContext = new TeamPageViewModel();
        }

        private void back_click(object sender, RoutedEventArgs e)
        {
            TaskAssignmentState.SelectedStage = null;
            NavigationService.GoBack();
        }

        public void Team_Click(object sender, RoutedEventArgs e)
        {
            if (sender as Button is null)
            {
                return;
            }
            var btn = sender as Button;
            btn.Command.Execute(btn.CommandParameter);
            NavigationService.Navigate(new TeamMemberPage());
        }

        private void BtnTeamItem_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            var btn = sender as Button;
            btn.Command.Execute(btn.CommandParameter);
        }

        private void ViewMenuItem_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TeamMemberPage());
        }
    }
}
