using CUOIKI_EF.Controllers;
using CUOIKI_EF.Enums;
using CUOIKI_EF.States;
using CUOIKI_EF.UI.Manager;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace CUOIKI_EF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly AuthenticationController _authController;
        public MainWindow()
        {
            InitializeComponent();
            _authController = new AuthenticationController();
        }
        public bool IsDarkTheme { get; set; }
        private readonly PaletteHelper paletteHelper = new PaletteHelper();

        private void toggleTheme(object sender, RoutedEventArgs e)
        {
            ITheme theme = paletteHelper.GetTheme();

            if (IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)
            {
                IsDarkTheme = false;
                theme.SetBaseTheme(Theme.Light);
            }
            else
            {
                IsDarkTheme = true;
                theme.SetBaseTheme(Theme.Dark);
            }
            paletteHelper.SetTheme(theme);
        }

        private void exitApp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Employee foundEmployee = _authController.Login(txtUsername.Text, txtPassword.Password);

            if (foundEmployee == null)
            {
                MessageBox.Show("Invalid Credentials");
                return;
            }

            LoginInfoState.Id = foundEmployee.ID;
            LoginInfoState.Name = foundEmployee.Name;
            LoginInfoState.Role = (Role)Enum.Parse(typeof(Role), foundEmployee.Role);

            if (foundEmployee.Role == EnumMapper.mapToString(Role.Manager))
            {
                UI_ManagerForm uI_ManagerForm = new UI_ManagerForm();
                uI_ManagerForm.Show();

            }
            //else if (foundEmployee.Role == Role.Hr)
            //{
            //    UI_HrForm uI_HrForm = new();
            //    uI_HrForm.Show();
            //}
            //else
            //{
            //    UI_StaffForm uI_StaffForm = new();
            //    uI_StaffForm.Show();
            //}
            this.Close();
        }
    }
}
