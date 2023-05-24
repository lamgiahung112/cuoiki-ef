using CUOIKI_EF.Controllers;
using CUOIKI_EF.Helpers;
using CUOIKI_EF.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using CUOIKI_EF.Factories;
using CUOIKI_EF.UI.Forms;
using CUOIKI_EF.Enums;

namespace CUOIKI_EF.ViewModels
{
    public class TeamPageViewModel : ViewModelBase
    {
        private DbController db;

        public TeamPageViewModel()
        {
            db = DbController.Instance;
            _teamList = new List<Team>();
            TechLeadsFromDB = db.GetEmployeesByRole(Role.TechLead);
            FetchTeamList();
        }

        #region List Team Binding
        private List<Team> _teamList;
        public List<Team> TeamList
        {
            get { return _teamList; }
            set
            {
                _teamList = value;
                OnPropertyChanged(nameof(TeamList));
            }
        }

        private void FetchTeamList()
        {
            TeamList = db.GetTeamsOfCurrentStage() ?? new List<Team>();
        }

        #endregion

        #region Add/Edit Team Command Binding
        private ICommand _CmdAddTeam;
        public ICommand CmdAddTeam
        {
            get
            {
                if (_CmdAddTeam == null )
                {
                    _CmdAddTeam = new RelayCommand(
                        p => true,
                        p => OpenAddTeamForm()
                    );
                }
                return _CmdAddTeam;
            }
        }

        private ICommand _CmdEditTeam;
        public ICommand CmdEditTeam
        {
            get
            {
                if (_CmdEditTeam == null )
                {
                    _CmdEditTeam = new RelayCommand(
                        p => true,
                        p => OpenEditTeamForm()
                    );
                }
                return _CmdEditTeam;
            }
        }

        private ICommand _CmdSave;
        public ICommand CmdSave
        {
            get
            {
                if (_CmdSave == null )
                {
                    _CmdSave = new RelayCommand(
                        p => TechLead?.ID.Length > 0 && TeamName.Length > 0,
                        p => SaveTeam()
                    );
                }
                return _CmdSave;
            }
        }

        private void SaveTeam()
        {
            Team team = TaskAssignmentState.SelectedTeam ?? TeamFactory.Create(StageID, TechLead.ID, TeamName);
            team.TechLeadID = TechLead.ID;
            team.Name = TeamName;
            db.Save(team);
            FetchTeamList();
        }

        private void OpenEditTeamForm()
        {
            ShowID = Visibility.Visible;

            StageID = TaskAssignmentState.SelectedTeam.StageID;
            TechLead = TechLeadsFromDB.Where(x => x.ID == TaskAssignmentState.SelectedTeam.TechLeadID).FirstOrDefault();
            TeamName = TaskAssignmentState.SelectedTeam.Name;

            var f = new TeamForm(this);
            f.Show();
        }

        private void OpenAddTeamForm()
        {
            TeamID = "";
            ShowID = Visibility.Collapsed;
            StageID = TaskAssignmentState.SelectedStage.ID;
            TechLead = null;
            TeamName = "";
            var f = new TeamForm(this);
            f.Show();
        }

        #endregion

        #region Team Form Bindings
        public string StageID { get; set; }
        private string _TeamID;
        public string TeamID
        {
            get { return _TeamID; }
            set
            {
                _TeamID = value;
                OnPropertyChanged(nameof(TeamID));
            }
        }

        private Visibility _ShowID;
        public Visibility ShowID
        {
            get { return _ShowID; }
            set
            {
                _ShowID = value;
                OnPropertyChanged(nameof(ShowID));
            }
        }

        private List<Employee> _techLeadsFromDB;
        public List<Employee> TechLeadsFromDB
        {
            get { return _techLeadsFromDB; }
            set
            {
                _techLeadsFromDB = value;
                OnPropertyChanged(nameof(TechLeadsFromDB));
            }
        }

        private Employee _TechLead;
        public Employee TechLead
        {
            get { return _TechLead; }
            set
            {
                _TechLead = value;
                OnPropertyChanged(nameof(TechLead));
            }
        }

        private string _TeamName;
        public string TeamName
        {
            get { return _TeamName; }
            set
            {
                _TeamName = value;
                OnPropertyChanged(nameof(TeamName));
            }
        }

        private ICommand _CmdUpdateTechLead;
        public ICommand CmdUpdateTechLead
        {
            get
            {
                if (_CmdUpdateTechLead == null)
                {
                    _CmdUpdateTechLead = new RelayCommand(
                        p => true,
                        p =>
                        {
                            TechLead = TechLeadsFromDB.Where(x => x.ID == p.ToString()).First();
                        }
                    );
                }
                return _CmdUpdateTechLead;
            }
        }

        #endregion

        #region Context Menu Bindings
        private ICommand _CmdSaveTeamToState;
        public ICommand CmdSaveTeamToState
        {
            get
            {
                if (_CmdSaveTeamToState == null)
                {
                    _CmdSaveTeamToState = new RelayCommand(
                        p => true,
                        p => SaveTeamToState(p)
                    );
                }
                return _CmdSaveTeamToState;
            }
        }

        private void SaveTeamToState(object param)
        {
            if ((param is string id) == false)
            {
                return;
            }
            TaskAssignmentState.SelectedTeam = TeamList.Where(x => x.ID == id).FirstOrDefault();
            TeamID = id;
        }
        #endregion

    }
}
