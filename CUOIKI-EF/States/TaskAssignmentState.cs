﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUOIKI_EF.States
{
    public static class TaskAssignmentState
    {
        public static Project SelectedProject { get; set; }
        public static Stage SelectedStage { get; set; }
        public static Team SelectedTeam { get; set; }
        public static Employee SelectedEmployee { get; set; }
    }
}
