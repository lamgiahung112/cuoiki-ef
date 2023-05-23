using CUOIKI_EF.Controllers;
using CUOIKI_EF.Enums;
using CUOIKI_EF.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CUOIKI_EF.ViewModels
{
    public class UserInformationViewModel : ViewModelBase
    {
        private readonly DbController db;
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserAddress { get; set; }
        public string UserBirth { get; set; }
        public string UserRole { get; set; }
        public string UserGender { get; set; }
        public string UserStatus { get; set; }
        public UserInformationViewModel()
        {
            db = DbController.Instance;
            MessageBox.Show(LoginInfoState.Id);
            Employee e = db.GetByID<Employee>(LoginInfoState.Id);
            UserId = e.ID;
            UserName = e.Name;
            UserAddress = e.Address;
            UserBirth = e.Birth.ToShortDateString();
            UserRole = e.Role;
            UserGender = e.Gender;
            UserStatus = e.EmployeeStatus;
        }

        private List<string> genderList = new List<string>()
        {
            nameof(Gender.Male), nameof(Gender.Female)
        };

        public List<string> GenderList
        {
            get => genderList;
            set => genderList = value;
        }

        private List<string> roleList = new List<string>()
        {
            nameof(Role.Dev), nameof(Role.Designer), nameof(Role.Tester), nameof(Role.TechLead), nameof(Role.Manager), nameof(Role.Hr)
        };

        public List<string> RoleList
        {
            get => roleList;
            set => roleList = value;
        }
    }
}
