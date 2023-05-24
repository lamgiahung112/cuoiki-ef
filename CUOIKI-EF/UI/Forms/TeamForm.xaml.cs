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
using System.Windows.Shapes;

namespace CUOIKI_EF.UI.Forms
{
    /// <summary>
    /// Interaction logic for TeamForm.xaml
    /// </summary>
    public partial class TeamForm : Window
    {
        public TeamForm(TeamPageViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CbbTechLead_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((sender is ComboBox cbb) == false) return;
            (DataContext as TeamPageViewModel).CmdUpdateTechLead.Execute(cbb.SelectedValue?.ToString());
        }
    }
}
