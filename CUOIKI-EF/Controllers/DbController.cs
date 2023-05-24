﻿using CUOIKI_EF.Enums;
using CUOIKI_EF.States;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace CUOIKI_EF.Controllers
{
    public class DbController
    {
        private static DbController instance;
        private static databaseContext db;
        private DbController()
        {
            db = new databaseContext();
        }

        public static DbController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DbController();
                }
                return instance;
            }
        }
        public void Save<T>(T entry)
        {
            if (entry is Project)
            {
                db.Projects.AddOrUpdate(entry as Project);
            }
            else if (entry is Stage)
            {
                db.Stages.AddOrUpdate(entry as Stage);
            }
            else if (entry is Team)
            {
                db.Teams.AddOrUpdate(entry as Team);
            }
            else if (entry is TeamMember)
            {
                db.TeamMembers.AddOrUpdate(entry as TeamMember);
            }
            else if (entry is Task)
            {
                db.Tasks.AddOrUpdate(entry as Task);
            }
            else if (entry is WorkSession)
            {
                db.WorkSessions.AddOrUpdate(entry as WorkSession);
            }

            db.SaveChanges();
        }

        public void Delete<T>(T entry)
        {
            if (entry is Project)
            {
                db.Projects.Remove(entry as Project);
            }
            else if (entry is Stage)
            {
                db.Stages.Remove(entry as Stage);
            }
            else if (entry is Team)
            {
                db.Teams.Remove(entry as Team);
            }
            else if (entry is TeamMember)
            {
                db.TeamMembers.Remove(entry as TeamMember);
            }
            else if (entry is Task)
            {
                db.Tasks.Remove(entry as Task);
            }
            else if (entry is WorkSession)
            {
                db.WorkSessions.Remove(entry as WorkSession);
            }
            db.SaveChanges();
        }

        public List<Project> GetProjectsOfCurrentUser()
        {
            if (LoginInfoState.Role == Role.Manager)
            {
                return db.Projects.Where(x => x.ManagerID == LoginInfoState.Id).ToList();
            }
            else if (LoginInfoState.Role == Role.TechLead)
            {
                var query = from prj in db.Projects
                            join stg in db.Stages on prj.ID equals stg.ProjectID
                            join tm in db.Teams on stg.ID equals tm.StageID
                            where tm.TechLeadID == LoginInfoState.Id
                            select prj;
                return query.ToList();
            }
            else
            {
                var query = from prj in db.Projects
                            join stg in db.Stages on prj.ID equals stg.ProjectID
                            join tm in db.Teams on stg.ID equals tm.StageID
                            join member in db.TeamMembers on tm.ID equals member.ID
                            join employee in db.Employees on member.EmployeeID equals employee.ID
                            where employee.ID == LoginInfoState.Id
                            select prj;
                return query.ToList();
            }

        }

        public List<Stage> GetStagesOfCurrentProject()
        {
            return db.Stages.Where(x => x.ProjectID == TaskAssignmentState.SelectedProject.ID).ToList();
        }

        public List<Team> GetTeamsOfCurrentStage()
        {
            return db.Teams.Where(x => x.StageID == TaskAssignmentState.SelectedStage.ID).ToList();
        }

        public List<Employee> GetEmployeesByRole(Role role)
        {
            string r = EnumMapper.mapToString(role);
            return db.Employees.Where(x => x.Role == r).ToList();
        }
    }
}
