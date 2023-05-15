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
    /// Interaction logic for TeamMemberPage.xaml
    /// </summary>
    public partial class TeamMemberPage : Page
    {
        public TeamMemberPage()
        {
            InitializeComponent();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            //TaskAssignmentState.SelectedTeam = null;
            //NavigationService.GoBack();
        }

        private void btn_ViewTask_Click(object sender, RoutedEventArgs e)
        {
            //var btn = sender as Button;
            //btn.Command.Execute(btn.CommandParameter);
            //NavigationService.Navigate(new ViewTask());
        }
    }
}
