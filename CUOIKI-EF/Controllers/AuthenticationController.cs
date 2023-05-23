using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUOIKI_EF.Controllers
{
    public class AuthenticationController
    {
        public AuthenticationController() { }

        public Employee Login(string id, string password)
        {
            using (var db = new DatabaseContext())
            {
                Employee foundEmployee = db.Employees.Where(x => x.ID == id).FirstOrDefault();
                return foundEmployee != null && BCrypt.Net.BCrypt.Verify(password, foundEmployee.Password) ? foundEmployee : null;
            }
        }
    }
}
