using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using TimeManager.Model;

namespace TimeManager.ViewModel
{
    public class TimeChartsViewModel : BaseViewModel
    {
        private ObservableCollection<GroupingUser> usersGroup = new ObservableCollection<GroupingUser>();
        public ObservableCollection<GroupingUser> UsersGroup { get { return usersGroup; } set { usersGroup = value; OnPropertyChanged(); } }
        private ObservableCollection<TimeChartBlockModel> charts = new ObservableCollection<TimeChartBlockModel>();
        public ObservableCollection<TimeChartBlockModel> Charts { get { return charts; } set { charts = value; OnPropertyChanged(); } }
        public TimeChartsViewModel()
        {
            //foreach (string el in MainWindow.CurUser.AllUsersInfo.Select(el => el.GroupName).Distinct())
            //{
            //    GroupingUser item = new GroupingUser();
            //    item.Name = el;
            //    foreach (User el2 in MainWindow.CurUser.AllUsersInfo.Where(e => e.GroupName.Equals(el)))
            //        item.Users.Add(el2);
            //    UsersGroup.Add(item);
            //}

        }

        //public RelayCommand bLoadInfo_Click
        //{
        //    get
        //    {
        //        return new RelayCommand((o) =>
        //        {
        //            MessageBox.Show("OK");
        //        });
        //    }
        //}

        public RelayCommand bLoadInfo_Click
        {
            get
            {
                return new RelayCommand((o) =>
                {
                    MessageBox.Show("OK");
                    Charts.Clear();
                    foreach (GroupingUser el in UsersGroup)
                    {
                        foreach (User el2 in el.Users.Where(el3 => el3.IsSelected))
                        {
                            TimeChartBlockModel item = new TimeChartBlockModel();
                            item.SelectedUser = el2;
                            item.UserTimers.Add(new TimeModel()
                            {
                                Name = "Work time",
                                ImageBrush = new SolidColorBrush(Colors.DarkOrange),
                                WorkTimeSpan = new TimeSpan(6, 00, 0),
                                MaxTimeSpan = new TimeSpan(8, 10, 0),
                                ImagePath = "M12,20A7,7 0 0,1 5,13A7,7 0 0,1 12,6A7,7 0 0,1 19,13A7,7 0 0,1 12,20M19.03,7.39L20.45,5.97C20,5.46 19.55,5 19.04,4.56L17.62,6C16.07,4.74 14.12,4 12,4A9,9 0 0,0 3,13A9,9 0 0,0 12,22C17,22 21,17.97 21,13C21,10.88 20.26,8.93 19.03,7.39M11,14H13V8H11M15,1H9V3H15V1Z"
                            });
                            item.UserTimers.Add(new TimeModel()
                            {
                                Name = "Break",
                                ImageBrush = new SolidColorBrush(Colors.Brown),
                                WorkTimeSpan = new TimeSpan(0, 40, 0),
                                MaxTimeSpan = new TimeSpan(8, 10, 0),
                                ImagePath = "M2,21H20V19H2M20,8H18V5H20M20,3H4V13A4,4 0 0,0 8,17H14A4,4 0 0,0 18,13V10H20A2,2 0 0,0 22,8V5C22,3.89 21.1,3 20,3Z"
                            });
                            item.UserTimers.Add(new TimeModel()
                            {
                                Name = "Lunch",
                                ImageBrush = new SolidColorBrush(Colors.LimeGreen),
                                WorkTimeSpan = new TimeSpan(1, 0, 0),
                                MaxTimeSpan = new TimeSpan(8, 10, 0),
                                ImagePath = "M15.5,21L14,8H16.23L15.1,3.46L16.84,3L18.09,8H22L20.5,21H15.5M5,11H10A3,3 0 0,1 13,14H2A3,3 0 0,1 5,11M13,18A3,3 0 0,1 10,21H5A3,3 0 0,1 2,18H13M3,15H8L9.5,16.5L11,15H12A1,1 0 0,1 13,16A1,1 0 0,1 12,17H3A1,1 0 0,1 2,16A1,1 0 0,1 3,15Z"
                            });
                            item.UserTimers.Add(new TimeModel()
                            {
                                Name = "Meeting",
                                ImageBrush = new SolidColorBrush(Colors.OrangeRed),
                                WorkTimeSpan = new TimeSpan(0, 10, 0),
                                MaxTimeSpan = new TimeSpan(8, 10, 0),
                                ImagePath = "M4,15H6A2,2 0 0,1 8,17V19H9V17A2,2 0 0,1 11,15H13A2,2 0 0,1 15,17V19H16V17A2,2 0 0,1 18,15H20A2,2 0 0,1 22,17V19H23V22H1V19H2V17A2,2 0 0,1 4,15M11,7L15,10L11,13V7M4,2H20A2,2 0 0,1 22,4V13.54C21.41,13.19 20.73,13 20,13V4H4V13C3.27,13 2.59,13.19 2,13.54V4A2,2 0 0,1 4,2Z"
                            });
                            item.UserTimers.Add(new TimeModel()
                            {
                                Name = "Study",
                                ImageBrush = new SolidColorBrush(Colors.DarkOrange),
                                WorkTimeSpan = new TimeSpan(0, 10, 0),
                                MaxTimeSpan = new TimeSpan(8, 10, 0),
                                ImagePath = "M12,3L1,9L12,15L21,10.09V17H23V9M5,13.18V17.18L12,21L19,17.18V13.18L12,17L5,13.18Z"
                            });
                            item.UserTimers.Add(new TimeModel()
                            {
                                Name = "Exit note",
                                ImageBrush = new SolidColorBrush(Colors.CornflowerBlue),
                                WorkTimeSpan = new TimeSpan(0, 10, 0),
                                MaxTimeSpan = new TimeSpan(8, 10, 0),
                                ImagePath = "M6,2A2,2 0 0,0 4,4V20A2,2 0 0,0 6,22H18A2,2 0 0,0 20,20V8L14,2H6M6,4H13V9H18V20H6V4M8,12V14H16V12H8M8,16V18H13V16H8Z"
                            });
                            Charts.Add(item);
                        }
                    }
                }, o =>
                {

                    foreach (GroupingUser el in UsersGroup)
                    {
                        foreach (User el2 in el.Users.Where(el3 => el3.IsSelected))
                            return true;
                    }
                    return false;
                });
            }
        }




    }
    public class GroupingUser : BaseViewModel
    {
        public ObservableCollection<User> users = new ObservableCollection<User>();
        public string Name { get; set; }
        public ObservableCollection<User> Users { get { return users; } set { users = value; OnPropertyChanged(); } }
    }
}