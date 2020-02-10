using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeManager.Model;

namespace TimeManager.ViewModel
{
    public class UserViewModel : BaseViewModel
    {
        private User newUser = new User();
        public User NewUser { get { return newUser; } set { newUser = value; OnPropertyChanged(); } }
        private ObservableCollection<User> userInfo = new ObservableCollection<User>();
        public ObservableCollection<User> UserInfo { get { return userInfo; } set { userInfo = value; OnPropertyChanged(); } }
        private ObservableCollection<User> groupInfo = new ObservableCollection<User>();
        public ObservableCollection<User> GroupInfo { get { return groupInfo; } set { groupInfo = value; OnPropertyChanged(); } }
        private User selectedGroup = new User();
        public User SelectedGroup { get { return selectedGroup; } set { selectedGroup = value; OnPropertyChanged(); } }

        private User currentUser = new User();
        public User CurrentUser { get { return currentUser = UserInfo.First();  } set {  currentUser = value; OnPropertyChanged(); } }
        //public User CurrentUser { get { return currentUser = UserInfo.First(u => u.Login == Environment.UserName); } set { currentUser = value; OnPropertyChanged(); } }
  
        private string currentLogUser = Environment.UserName;
        public string CurrentLogUser { get { return currentLogUser = UserInfo.First().FullName; } set { currentLogUser = value; OnPropertyChanged(); } }
        //public string CurrentLogUser { get { return currentLogUser = UserInfo.First(u => u.Login == Environment.UserName).FullName; } set { currentLogUser = value; OnPropertyChanged(); } }

        //Uname

        ConnectToBase ConnectBase = new ConnectToBase();
        public DataTable dt = new DataTable();
        public DataTable Dt { get { return dt; } set { dt = value; OnPropertyChanged(); } }



        public UserViewModel()
        {
            //UserInfo.Add(new User() { ID = 18, Login = "tssavka", LastName = "Савка", FirstName = "Тарас", SurName = "Степанович", Email = "taras.savka@kredobank.com.ua", Group = 1, GroupName = "Admin", WorkColumn = "", Competition = "" });
            //UserInfo.Add(new User() { ID = 17, Login = "avmusiiovskyi", LastName = "Мусійовський", FirstName = "Андрій", SurName = "Володимирович", Email = "andriy.musiiovskyi@kredobank.com.ua", Group = 1, GroupName = "Admin", WorkColumn = "", Competition = "" });

            //CurrentUser.FirstName = CurrentUser.Uname();

            //GroupInfo.Add(new User() { Group = 1, GroupName = "Admin" });
            //GroupInfo.Add(new User() { Group = 2, GroupName = "User" });
            //SelectedGroup = GroupInfo[1];



            //Dt = ConnectBase.Select("SELECT * FROM " + ConnectBase.userBase);
            //for (int i = 0; i < Dt.Rows.Count; i++)
            //{
            //    NewUser = new User() {ID= (int)Dt.Rows[i]["ID"], Login = Dt.Rows[i]["Login"].ToString(), LastName = Dt.Rows[i]["LastName"].ToString(), FirstName = Dt.Rows[i]["FirstName"].ToString(), SurName = Dt.Rows[i]["SurName"].ToString(), GroupName = Dt.Rows[i]["GroupName"].ToString(), Position = Dt.Rows[i]["Position"].ToString() };
            //    UserInfo.Add(NewUser);
            //}


            GetUsers();

        }


        public void GetUsers()
        {
            Dt = ConnectBase.Select("SELECT * FROM " + ConnectBase.userBase);
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                NewUser = new User() { ID = (int)Dt.Rows[i]["ID"], Login = Dt.Rows[i]["Login"].ToString(), LastName = Dt.Rows[i]["LastName"].ToString(), FirstName = Dt.Rows[i]["FirstName"].ToString(), SurName = Dt.Rows[i]["SurName"].ToString(), GroupName = Dt.Rows[i]["GroupName"].ToString(), Position = Dt.Rows[i]["Position"].ToString() };
                UserInfo.Add(NewUser);
            }

        }



        public RelayCommand bLoadInfo_Click
        {
            get
            {
                return new RelayCommand((o) =>
                {

                    UserInfo.Add(new User()
                    {
                        ID = NewUser.ID,
                        Login = NewUser.Login,
                        LastName = NewUser.LastName,
                        FirstName = NewUser.FirstName,
                        SurName = NewUser.SurName,
                        Email = NewUser.Email,
                        Group = SelectedGroup.Group,
                        GroupName = SelectedGroup.GroupName,
                        WorkColumn = NewUser.WorkColumn,
                        Competition = NewUser.Competition,
                    });

                });
            }
        }
    }
}
