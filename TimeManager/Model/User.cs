using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TimeManager.ViewModel;
using System.DirectoryServices.AccountManagement; // для повного імені користувача
using System.Data;



namespace TimeManager.Model
{
    public class User: BaseViewModel
    {

        private bool isSelected = false;
        private string fullName;
        public int ID { get; set; }
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SurName { get; set; }
        public string FullName { get { return LastName + " " + FirstName + " " + SurName; } set { fullName=value; } }
        public string FullNameShorter { get { return LastName + " " + FirstName.Substring(0, 1) + "." + SurName.Substring(0, 1) + "."; } }
        public string FullNameShort { get { return LastName + " " + FirstName; } }
        public string Email { get; set; }
        public int Group { get; set; }
        //public static int onlyOneClientTab { get; set; }
        public string GroupName { get; set; }
        public string WorkColumn { get; set; }
        public string Competition { get; set; }
        public string Position { get; set; }
        //public List<UserStatus> MyStatus { get; set; }
        public List<User> AllUsersInfo { get; set; }
        public bool IsSelected { get { return isSelected; } set { isSelected = value; } }

        //private string currentLogUser;
        //public string CurrentLogUser { get { return currentLogUser = Uname(); ; } set { currentLogUser = value; OnPropertyChanged(); } }

        public void LogToSystem()
        {
            ID = 17;
            Login = Environment.UserName;
            LastName = "Савка";
            FirstName = "Тарас";
            SurName = "Степанович";
            Group = 1;
            GroupName = "Admin";
            WorkColumn = "";
            Competition = "";
            Position = "Працівник ДПК";
            //MyStatus.Add("Передати колекторам");
            //MyStatus = new List<UserStatus>();
            //MyStatus.Add(new UserStatus() { ID = 1, Name = "Передати колекторам" });
            AllUsersInfo = new List<User>();
            AllUsersInfo.Add(new User()
            {
                ID = 1,
                LastName = "Савка",
                FirstName = "Тарас",
                SurName = "Степанович",
                GroupName = "DRS",
                Position = "Аналітик ДРС"
            });
            AllUsersInfo.Add(this);
        }
        public string Uname()
        {
            //UserPrincipal userPrincipal = UserPrincipal.Current;   // повне імя користувача
            //string uName = userPrincipal.DisplayName;
            //string uName = System.Windows.Forms.SystemInformation.UserName;
            string uName = Environment.UserName;   // tssavka
            return uName;
        }
    }
}
