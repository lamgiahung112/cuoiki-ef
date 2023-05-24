using CUOIKI_EF.Controllers;
using CUOIKI_EF.Factories;
using CUOIKI_EF.Helpers;
using CUOIKI_EF.States;
using CUOIKI_EF.UI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace CUOIKI_EF.ViewModels
{
    public class TeamMemberpageViewModel : ViewModelBase
    {
        private readonly DbController db;

        public TeamMemberpageViewModel() 
        {
            db = DbController.Instance;
            FetchTeamMemberList();
        }

        public string CurrentManagerName
        {
            get => LoginInfoState.Name;
            set { }
        }
        public string CurrentManagerID
        {
            get => LoginInfoState.Id;
            set { }
        }
        public string CurrentTeamName
        {
            get => db.GetTeamName(TaskAssignmentState.SelectedTeam.ID);
            set { }
        }

        #region TeamMemberList
        private List<Employee> _TeamMemberList;
        public List<Employee> TeamMemberList
        {
            get => _TeamMemberList;
            set 
            { 
                _TeamMemberList = value;
                OnPropertyChanged(nameof(TeamMemberList));
            }
        }
        private void FetchTeamMemberList()
        {
            _TeamMemberList.Clear();
            TeamMemberList = db.GetTeamMemberDetailsOfTeam(TaskAssignmentState.SelectedTeam.ID);
        }
        #endregion

        #region Assigner
        private string _CurrentEmployeeName;
        public string CurrentEmployeeName
        {
            get => _CurrentEmployeeName;
            set
            {
                _CurrentEmployeeName = value;
                OnPropertyChanged(nameof(CurrentEmployeeName));
            }
        }
        #endregion

        #region Open task assigment form command
        private ICommand _CmdOpenTaskAssignmentForm;
        public ICommand CmdOpenTaskAssignmentForm
        {
            get
            {
                if (_CmdOpenTaskAssignmentForm == null)
                {
                    _CmdOpenTaskAssignmentForm = new RelayCommand(
                        p => true,
                        p => OpenTaskAssignmentForm()
                    );
                }
                return _CmdOpenTaskAssignmentForm;
            }
        }
        private void OpenTaskAssignmentForm()
        {
            var taskAssignmentForm = new ManagerTaskAssignmentForm(this);
            taskAssignmentForm.Show();
        }
        #endregion

        #region Form input
        private string _ToBeSavedTaskTitle = "";
        private string _ToBeSavedTaskDescription = "";
        private DateTime? _ToBeSavedTaskStartingTime = DateTime.Now;
        private DateTime? _ToBeSavedTaskEndingTime = DateTime.Now;
        public string ToBeSavedTaskTitle
        {
            get { return _ToBeSavedTaskTitle; }
            set
            {
                _ToBeSavedTaskTitle = value;
                OnPropertyChanged(nameof(ToBeSavedTaskTitle));
                CheckValidTaskInput();
            }
        }
        public string ToBeSavedTaskDescription
        {
            get { return _ToBeSavedTaskDescription; }
            set
            {
                _ToBeSavedTaskDescription = value;
                OnPropertyChanged(nameof(ToBeSavedTaskDescription));
                CheckValidTaskInput();
            }
        }
        public DateTime ToBeSavedTaskStartingTime
        {
            get { return _ToBeSavedTaskStartingTime ?? DateTime.Now; }
            set
            {
                _ToBeSavedTaskStartingTime = value;
                OnPropertyChanged(nameof(ToBeSavedTaskStartingTime));
            }
        }
        public DateTime ToBeSavedTaskEndingTime
        {
            get { return _ToBeSavedTaskEndingTime ?? DateTime.Now; }
            set
            {
                _ToBeSavedTaskEndingTime = value;
                OnPropertyChanged(nameof(ToBeSavedTaskEndingTime));
            }
        }
        #endregion

        #region Save task command
        private ICommand _CmdSaveTask;
        public ICommand CmdSaveTask
        {
            get
            {
                if (_CmdSaveTask == null)
                {
                    _CmdSaveTask = new RelayCommand(
                    p => _CanSaveTask,
                    p => SaveTask());
                }
                return _CmdSaveTask;
            }
        }
        private bool _CanSaveTask = false;
        private void SaveTask()
        {
            Task task = TaskFactory.Create(CurrentManagerID, "slected", ToBeSavedTaskTitle, ToBeSavedTaskDescription, ToBeSavedTaskStartingTime, ToBeSavedTaskEndingTime);
            db.Save(task);
            Application.Current.Windows.OfType<Window>().FirstOrDefault(x => x.IsActive == true).Close();
        }
        private void CheckValidTaskInput()
        {
            _CanSaveTask = !string.IsNullOrEmpty(ToBeSavedTaskTitle);
            _CanSaveTask = !string.IsNullOrEmpty(ToBeSavedTaskDescription);
        }
        #endregion

        #region Assign member's task command
        private ICommand _CmdAssignMemberTask;
        public ICommand CmdAssignMemberTask
        {
            get
            {
                if (_CmdAssignMemberTask == null)
                {
                    _CmdAssignMemberTask = new RelayCommand(
                    p => true,
                    p => AssignTaskToMember(p));
                }
                return _CmdAssignMemberTask;
            }
        }
        private void AssignTaskToMember(object p)
        {
            Employee e = (Employee)p;
            TaskAssignmentState.SelectedEmployee = e;
            CurrentEmployeeName = e.Name;
            var taskForm = new ManagerTaskAssignmentForm(this);
            taskForm.Show();
        }
        #endregion

        #region View member's task
        private ICommand _CmdViewMemberTask;
        public ICommand CmdViewMemberTask
        {
            get
            {
                if (_CmdViewMemberTask == null)
                {
                    _CmdAssignMemberTask = new RelayCommand(
                    p => true,
                    p => ViewMemberTask());
                }
                return _CmdAssignMemberTask;
            }
        }
        private void ViewMemberTask()
        {

        }
        #endregion

        #region View member's information
        private ICommand _CmdViewMemberInformation;
        public ICommand CmdViewMemberInformation
        {
            get
            {
                if (_CmdViewMemberInformation == null)
                {
                    _CmdViewMemberInformation = new RelayCommand(
                    p => true,
                    p => ViewMemberInformation(p));
                }
                return _CmdViewMemberInformation;
            }
        }
        private void ViewMemberInformation(object p)
        {
            Employee e = (Employee)p;
            MessageBox.Show("View member's information" + e.ID.ToString());
        }
        #endregion

        #region Open team member management form
        private ICommand _CmdOpenTeamMemberManagementForm;
        public ICommand CmdOpenTeamMemberManagementForm
        {
            get
            {
                _CmdOpenTeamMemberManagementForm = new RelayCommand(
                    p => true,
                    p => OpenTeamMemberManagementForm());
                return _CmdOpenTeamMemberManagementForm;
            }
        }
        private void OpenTeamMemberManagementForm()
        {
            UpdateWorkerList();
            var teamMemberManagementForm = new ManageTeamMembersForm(this);
            teamMemberManagementForm.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            teamMemberManagementForm.Show();
        }
        #endregion

        // TODO: workdto
        #region Team member management logic
        //private List<WorkerDTO>? _workerList;
        //public List<WorkerDTO>? WorkerList
        //{
        //    get => _workerList;
        //    set
        //    {
        //        _workerList = value;
        //        OnPropertyChanged(nameof(WorkerList));
        //    }
        //}

        //private void UpdateWorkerList()
        //{
        //    List<TeamMember>? teamMembers = _controller.GetAllMembersOfTeam(TaskAssignmentState.SelectedTeam!);
        //    List<Employee>? allWorkers = _controller.GetAllWorkers();
        //    _workerList = allWorkers.Select(x => new WorkerDTO()
        //    {
        //        Name = x.Name,
        //        EmployeeID = x.ID,
        //        EmployeeRole = x.Role.ToString(),
        //        IsSelected = teamMembers.Any(tm => tm.EmployeeID == x.ID)
        //    })
        //    .ToList();
        //}
        #endregion

        // todo: Save team
        #region Save changes command
        private ICommand _CmdSaveChanges;
        public ICommand CmdSaveChanges
        {
            get
            {
                if (_CmdSaveChanges == null)
                {
                    _CmdSaveChanges = new RelayCommand(
                    p => true,
                    p => SaveTeamMemberChanges());
                }
                return _CmdSaveChanges;
            }
        }
        private void SaveTeamMemberChanges()
        {
            List<TeamMember>? currentTeamMembers = _controller.GetAllMembersOfTeam(TaskAssignmentState.SelectedTeam!);
            // Get the IDs of selected workers who are not already team members
            List<string> newMemberIDs = _workerList
                .Where(w => w.IsSelected && !currentTeamMembers.Any(m => m.EmployeeID == w.EmployeeID))
                .Select(w => w.EmployeeID)
                .ToList();
            // Get the IDs of deselected workers who are already team members
            List<string> toBeRemovedTeamMemberIDs = _workerList
                .Where(w => !w.IsSelected && currentTeamMembers.Any(m => m.EmployeeID == w.EmployeeID))
                .Select(w => currentTeamMembers.First(m => m.EmployeeID == w.EmployeeID).ID)
                .ToList();
            _controller.AddTeamMembersToTeam(TaskAssignmentState.SelectedTeam!.ID, newMemberIDs);
            _controller.RemoveTeamMembers(toBeRemovedTeamMemberIDs);
            UpdateWorkerList();
            UpdateTeamMemberList();
            Application.Current.Windows.OfType<Window>().FirstOrDefault(x => x.IsActive == true)!.Close();
        }
        #endregion

        #region Cancel command
        private ICommand _CmdCancelTeamManagementForm;
        public ICommand CmdCancelTeamMenagementForm
        {
            get
            {
                if (_CmdCancelTeamManagementForm == null )
                {
                    _CmdCancelTeamManagementForm = new RelayCommand(
                    p => true,
                    p => CancelTeamManagementForm());
                }
                return _CmdCancelTeamManagementForm;
            }
        }
        private void CancelTeamManagementForm()
        {
            Application.Current.Windows.OfType<Window>().FirstOrDefault(x => x.IsActive == true).Close();

        }
        #endregion
        #region Save current employee to state
        private ICommand _CmdSaveEmployeeToCurrentState;
        public ICommand CmdSaveEmployeeToCurrentState
        {
            get
            {
                if (_CmdSaveEmployeeToCurrentState == null )
                {
                    _CmdSaveEmployeeToCurrentState = new RelayCommand(
                        p => true,
                        p => SaveEmployeeToCurrentState(p));
                }
                return _CmdSaveEmployeeToCurrentState;
            }
        }
        private void SaveEmployeeToCurrentState(object parameter)
        {
            Employee e = (Employee)parameter;
            TaskAssignmentState.SelectedEmployee = e;
        }
        #endregion


    }
}
