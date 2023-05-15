using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUOIKI_EF.Factories
{
    public class ProjectFactory
    {
        private static string CreateRandomID()
        {
            return "PRJ" + new Random().Next();
        }

        public static Project Create(string ManagerID, string ProjectName, string Description)
        {
            var prj = new Project();
            prj.ID = CreateRandomID();
            prj.ManagerID = ManagerID;
            prj.CreatedAt = DateTime.Now;
            prj.Description = Description;
            prj.Name = ProjectName;
            return prj;
        }
    }
}
