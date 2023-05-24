using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUOIKI_EF.Factories
{
    public class TeamFactory
    {
        private static string CreateRandomID()
        {
            return "TEAM" + new Random().Next();
        }

        public static Team Create(string StageID, string TechleadID, string Name)
        {
            var team = new Team
            {
                ID = CreateRandomID(),
                Name = Name,
                StageID = StageID,
                TechLeadID = TechleadID
            };
            return team;
        }
    }
}
