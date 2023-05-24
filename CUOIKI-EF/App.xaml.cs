using CUOIKI_EF.Factories;
using System.Data.Entity.Migrations;
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
                Employee employee = EmployeeFactory.Create("Tin", "Tin", "Binh Dinh", Enums.EmployeeStatus.Active, "123", Enums.Gender.Male, Enums.Role.Dev);
                db.Employees.AddOrUpdate(employee);
                db.SaveChanges();
            }
            base.OnStartup(e);
        }
    }
}
