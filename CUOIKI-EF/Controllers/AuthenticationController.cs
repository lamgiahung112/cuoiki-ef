using System.Linq;

namespace CUOIKI_EF.Controllers
{
    public class AuthenticationController
    {
        public AuthenticationController() { }

        public Employee Login(string id, string password)
        {
            using (var db = new databaseContext())
            {
                Employee foundEmployee = db.Employees.Where(x => x.ID == id).First();
                return foundEmployee != null && password == foundEmployee.Password ? foundEmployee : null;
            }
        }
    }
}
