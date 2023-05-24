using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUOIKI_EF.Factories
{
    public class WorkLeaveFactory
    {
        private static string CreateRandomID()
        {
            return "WL" + new Random().Next();
        }

        public static WorkLeave Create(string EmployeeID, DateTime FromDate, DateTime ToDate, string Reason)
        {
            var entry = new WorkLeave();
            entry.EmployeeID = EmployeeID;
            entry.FromDate = FromDate;
            entry.ToDate = ToDate;
            entry.ReasonOfLeave = Reason;
            return entry;
        }
    }
}
