using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUOIKI_EF.Factories
{
    public class StageFactory
    {
        private static string CreateRandomID()
        {
            return "STG" + new Random().Next();
        }

        public static Stage Create(string ProjectID, string Description)
        {
            var stg = new Stage();
            stg.ID = CreateRandomID();
            stg.ProjectID = ProjectID;
            stg.Description = Description;
            return stg;
        }
    }
}
