using CUOIKI_EF.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CUOIKI_EF.Factories
{
    public class TaskFactory
    {
        private static string CreateRandomID()
        {
            return "TASK" + new Random().Next();
        }

        public static Task Create(string Assignee, string Assigner, string Title, string Description, DateTime StartingTime, DateTime EndingTime)
        {
            var task = new Task
            {
                ID = CreateRandomID(),
                Assignee = Assignee,
                Assigner = Assigner,
                CreatedAt = DateTime.Now,
                Description = Description,
                StartingTime = StartingTime,
                EndingTime = EndingTime,
                Status = EnumMapper.mapToString(TaskStatus.WIP),
                Title = Title,
                UpdatedAt = DateTime.Now,
            };
            return task;
        }
    }
}
