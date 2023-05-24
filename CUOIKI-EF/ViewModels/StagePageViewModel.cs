using CUOIKI_EF.Controllers;
using CUOIKI_EF.Factories;
using CUOIKI_EF.Helpers;
using CUOIKI_EF.States;
using CUOIKI_EF.UI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CUOIKI_EF.ViewModels
{
    public class StagePageViewModel : ViewModelBase
    {
        private DbController db;
        private List<Stage> stageList;
        public StagePageViewModel() 
        {
            db = DbController.Instance;
            ShowID = Visibility.Collapsed;
            stageList = new List<Stage>();
            FetchStageList();
        }

        public Visibility ShowID { get; set; }
        public string StageID { get; set; }
        public string ProjectID 
        {
            get => TaskAssignmentState.SelectedProject.ID;
            set { } 
        }
        public List<Stage> StageList 
        {
            get => stageList;
            set
            {
                stageList = value;
                OnPropertyChanged(nameof(StageList));
            }
        }

        #region Save stage logic
        private string _tobeSavedStageDescription = "";
        public string ToBeSavedStageDescription
        {
            get { return _tobeSavedStageDescription; }
            set
            {
                _tobeSavedStageDescription = value;
                OnPropertyChanged(nameof(ToBeSavedStageDescription));
                CheckValidStageInput();
            }
        }
        private void SaveStageToDB()
        {
            if (ToBeSavedStageDescription.Length == 0) return;
            Stage sToSave;
            if (StageID.Length == 0)
            {
                sToSave = StageFactory.Create(ProjectID, ToBeSavedStageDescription);
            }
            else sToSave = TaskAssignmentState.SelectedStage;
            sToSave.Description = _tobeSavedStageDescription;
            db.Save(sToSave);
        }
        private ICommand _saveStageToState;
        public ICommand CmdSaveStageToState
        {
            get
            {
                if (_saveStageToState == null)
                {
                    _saveStageToState = new RelayCommand(
                        obj => true,
                        obj => SaveStageToState(obj)
                    );
                }
                return _saveStageToState;
            }
        }

        private bool canSaveStage = false;
        private ICommand _saveStageCommand;
        public ICommand SaveStageCommand
        {
            get
            {
                if (_saveStageCommand == null)
                {
                    _saveStageCommand = new RelayCommand(
                    p => this.canSaveStage,
                    p => this.SaveStage());
                }
                return _saveStageCommand;
            }
        }

        private ICommand _AddStageClickCommand;
        public ICommand AddStageClickCommand
        {
            get
            {
                if (_AddStageClickCommand == null)
                {
                    _AddStageClickCommand = new RelayCommand(
                        p => true,
                        p => OpenAddStageForm()
                    );
                }
                return _AddStageClickCommand;
            }
        }
        #endregion

        #region Utils
        private void SaveStageToState(object param)
        {
            if (param == null) return;
            string stageID = (param as string);
            TaskAssignmentState.SelectedStage = StageList.Where(x => x.ID == stageID).FirstOrDefault();
            StageID = TaskAssignmentState.SelectedStage.ID;
            ToBeSavedStageDescription = TaskAssignmentState.SelectedStage.Description;
            ShowID = Visibility.Visible;
        }

        private void FetchStageList()
        {
            StageList.Clear();
            StageList = db.GetStagesOfCurrentProject();
        }

        public void SaveStage()
        {
            SaveStageToDB();
            FetchStageList();
        }

        private void OpenAddStageForm()
        {
            TaskAssignmentState.SelectedStage = null;
            StageID = "";
            _tobeSavedStageDescription = "";
            ShowID = Visibility.Collapsed;
            var addStageForm = new StageForm(this);
            addStageForm.Show();
        }

        private void CheckValidStageInput()
        {
            canSaveStage = !string.IsNullOrEmpty(ToBeSavedStageDescription);
        }

        #endregion

        #region Context menu command functions
        // Can execute variables
        private bool canViewStage = true;
        private bool canEditStage = true;
        private bool canDeleteStage = true;
        private void ViewStage()
        {
            TaskAssignmentState.SelectedStage = StageList.Where(x => x.ID == StageID).FirstOrDefault();
        }
        private void EditStage()
        {
            var stgForm = new StageForm(this);
            stgForm.Show();
        }
        private void DeleteStage()
        {
            MessageBox.Show("Delete stage");
        }
        #endregion

        #region Context menu commands
        private ICommand _cmdViewStage;
        public ICommand CmdViewStage
        {
            get
            {
                if (_cmdViewStage == null)
                {
                    _cmdViewStage = new RelayCommand(
                        p => canViewStage,
                        p => ViewStage()
                    );
                }
                return _cmdViewStage;
            }
        }
        private ICommand _cmdEditStage;
        public ICommand CmdEditStage
        {
            get
            {
                if (_cmdEditStage == null)
                {
                    _cmdEditStage = new RelayCommand(
                    p => canEditStage,
                    p => EditStage());
                }
                return _cmdEditStage;
            }
        }
        private ICommand _cmdDeleteStage;
        public ICommand CmdDeleteStage
        {
            get
            {
                if (_cmdDeleteStage == null)
                {
                    _cmdDeleteStage = new RelayCommand(
                    p => canDeleteStage,
                    p => DeleteStage());
                }
                return _cmdDeleteStage;
            }
        }
        #endregion

    }
}
