using CUOIKI_EF.Enums;
using CUOIKI_EF.Factories;
using System.Windows;

namespace CUOIKI_EF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            using (var db = new DatabaseContext())
            {
                Employee currentEmp = EmployeeFactory.Create("Tin", "Tin", "Binh Dinh", EmployeeStatus.Active, "123", Gender.Male, Role.Dev);
                db.Employees.Add(currentEmp);
                db.SaveChanges();
            }
            base.OnStartup(e);
        }
    }
}
