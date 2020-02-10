using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using TimeManager.Model;
using TimeManager.Pages;


namespace TimeManager.ViewModel
{
    public class TimeViewModel : BaseViewModel
    {

        private TimeModel selectedItem = new TimeModel();
        public TimeModel SelectedItem { get { return selectedItem; } set { selectedItem = value; OnPropertyChanged(); } }
        private ObservableCollection<TimeModel> workTimeItems = new ObservableCollection<TimeModel>();
        public ObservableCollection<TimeModel> WorkTimeItems { get { return workTimeItems; } set { workTimeItems = value; OnPropertyChanged(); } }

        public DispatcherTimer timer = new DispatcherTimer();

        ConnectToBase ConnectBase = new ConnectToBase();
        UserViewModel User = new UserViewModel();



        public TimeViewModel()
        {
            TimeModel workTimer = new TimeModel();

            
            WorkTimeItems.Add(new TimeModel() { ID = 1, Name = "Lunch", ImageBrush = new SolidColorBrush(Colors.LimeGreen), ImagePath = "M15.5,21L14,8H16.23L15.1,3.46L16.84,3L18.09,8H22L20.5,21H15.5M5,11H10A3,3 0 0,1 13,14H2A3,3 0 0,1 5,11M13,18A3,3 0 0,1 10,21H5A3,3 0 0,1 2,18H13M3,15H8L9.5,16.5L11,15H12A1,1 0 0,1 13,16A1,1 0 0,1 12,17H3A1,1 0 0,1 2,16A1,1 0 0,1 3,15Z" });
            WorkTimeItems.Add(new TimeModel() { ID = 2, Name = "Break", ImageBrush = new SolidColorBrush(Colors.Brown), ImagePath = "M2,21H20V19H2M20,8H18V5H20M20,3H4V13A4,4 0 0,0 8,17H14A4,4 0 0,0 18,13V10H20A2,2 0 0,0 22,8V5C22,3.89 21.1,3 20,3Z" });
            WorkTimeItems.Add(new TimeModel() { ID = 3, Name = "Meeting", ImageBrush = new SolidColorBrush(Colors.OrangeRed), ImagePath = "M4,15H6A2,2 0 0,1 8,17V19H9V17A2,2 0 0,1 11,15H13A2,2 0 0,1 15,17V19H16V17A2,2 0 0,1 18,15H20A2,2 0 0,1 22,17V19H23V22H1V19H2V17A2,2 0 0,1 4,15M11,7L15,10L11,13V7M4,2H20A2,2 0 0,1 22,4V13.54C21.41,13.19 20.73,13 20,13V4H4V13C3.27,13 2.59,13.19 2,13.54V4A2,2 0 0,1 4,2Z" });
            WorkTimeItems.Add(new TimeModel() { ID = 4, Name = "Study", ImageBrush = new SolidColorBrush(Colors.DarkOrange), ImagePath = "M12,3L1,9L12,15L21,10.09V17H23V9M5,13.18V17.18L12,21L19,17.18V13.18L12,17L5,13.18Z" });
            WorkTimeItems.Add(new TimeModel() { ID = 5, Name = "Exit note", ImageBrush = new SolidColorBrush(Colors.CornflowerBlue), ImagePath = "M12,15H10V13H12V15M18,15H14V13H18V15M8,11H6V9H8V11M18,11H10V9H18V11M20,20H4A2,2 0 0,1 2,18V6A2,2 0 0,1 4,4H20A2,2 0 0,1 22,6V18A2,2 0 0,1 20,20M4,6V18H20V6H4Z" });
            WorkTimeItems.Add(new TimeModel() { ID = 6, Name = "To the doctor", ImageBrush = new SolidColorBrush(Colors.CornflowerBlue), ImagePath = "M18,18.5A1.5,1.5 0 0,0 19.5,17A1.5,1.5 0 0,0 18,15.5A1.5,1.5 0 0,0 16.5,17A1.5,1.5 0 0,0 18,18.5M19.5,9.5H17V12H21.46L19.5,9.5M6,18.5A1.5,1.5 0 0,0 7.5,17A1.5,1.5 0 0,0 6,15.5A1.5,1.5 0 0,0 4.5,17A1.5,1.5 0 0,0 6,18.5M20,8L23,12V17H21A3,3 0 0,1 18,20A3,3 0 0,1 15,17H9A3,3 0 0,1 6,20A3,3 0 0,1 3,17H1V6C1,4.89 1.89,4 3,4H17V8H20M8,6V9H5V11H8V14H10V11H13V9H10V6H8Z" });
            WorkTimeItems.Add(new TimeModel() { ID = 7, Name = "Work time",  ImageBrush = new SolidColorBrush(Colors.DarkOrange), ImagePath = "M12,20A7,7 0 0,1 5,13A7,7 0 0,1 12,6A7,7 0 0,1 19,13A7,7 0 0,1 12,20M19.03,7.39L20.45,5.97C20,5.46 19.55,5 19.04,4.56L17.62,6C16.07,4.74 14.12,4 12,4A9,9 0 0,0 3,13A9,9 0 0,0 12,22C17,22 21,17.97 21,13C21,10.88 20.26,8.93 19.03,7.39M11,14H13V8H11M15,1H9V3H15V1Z" });
            WorkTimeItems.Add(new TimeModel() { ID = 8, Name = "Break time", IsEnabled=false, ImageBrush = new SolidColorBrush(Colors.DarkOrange), ImagePath = "M12,20A7,7 0 0,1 5,13A7,7 0 0,1 12,6A7,7 0 0,1 19,13A7,7 0 0,1 12,20M19.03,7.39L20.45,5.97C20,5.46 19.55,5 19.04,4.56L17.62,6C16.07,4.74 14.12,4 12,4A9,9 0 0,0 3,13A9,9 0 0,0 12,22C17,22 21,17.97 21,13C21,10.88 20.26,8.93 19.03,7.39M11,14H13V8H11M15,1H9V3H15V1Z" });

            //SelectedItem = WorkTimeItems[7];
            //Application.Current.MainWindow.Width = MainTabItems[0].Width;  // Зміна розміру вікна
        }

        //private void timer_Tick(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        SelectedItem.WorkTimeSpan += new TimeSpan(0, 0, 1);
        //        int timeScal = 900000; //15minute
        //        if (SelectedItem == WorkTimeItems[0])
        //            SelectedItem = WorkTimeItems[1];
        //        else
        //        {
        //            if (SelectedItem == WorkTimeItems[1])
        //                SelectedItem = WorkTimeItems[0];
        //        }
        //        WorkTimeItems[0].WorkTimeSpan += new TimeSpan(0, 0, 1);
        //    }
        //    catch (Exception) { timer.Stop(); }
        //}

        private void Resize()
        {
            Application.Current.MainWindow.Height = 500;
        }



        public RelayCommand StartTimer_Click
        {
            get
            {
                return new RelayCommand((o) =>
                {
                    if (WorkTimeItems[6].WorkTimeSpan == new TimeSpan(0, 0, 0))
                    {
                        ConnectBase.Insert(User.CurrentUser.ID, WorkTimeItems[6].Name, "(Work is ongoing..)", DateTime.Now.ToString(), DateTime.Now.AddSeconds(1).ToString(), "1");
                    }
                    else
                    {
                        ConnectBase.Updates(User.CurrentUser.ID, SelectedItem.StartTime.ToString() , DateTime.Now.ToString(), SelectedItem.Name, SelectedItem.Note, "0");
                    }

                    WorkTimeItems[6].IsActive = true;
                    WorkTimeItems[6].IsEnabled = false;
                    SelectedItem.IsActive = false;
                    SelectedItem.IsEnabled = true;

                    foreach (var item in WorkTimeItems)
                    {
                        if (item.Name != "Work time")
                        {
                            item.IsEnabled = true;                            
                        }
                    }                    
                    WorkTimeItems[6].IsEnabled = false;

                    SelectedItem = new TimeModel();

                    //if(WorkTimeItems[6].WorkTimeSpan == null)
                    //ConnectBase.Insert(User.CurrentUser.ID, WorkTimeItems[6].Name, "(Робота триває..)", DateTime.Now.ToString(), DateTime.Now.AddSeconds(1).ToString(), "1");


                }/*, (o) => SelectedItem.IsActive != true*/);
            }
        }


        public RelayCommand PauseButton_Click
        {
            get
            {
                return new RelayCommand((o) =>
                {
                    
                    foreach (var item in WorkTimeItems.Where(x => x.Name != "Work time"))
                    {
                        if (item.IsSelected == true)
                        {
                            //MessageBox.Show(item.PButton.Content.ToString());
                            item.IsSelected = !item.IsSelected;
                            item.IsEnabled = false;
                            //WorkTimeItems[6].IsEnabled = false;
                            //break;
                        }
                        else{ item.IsEnabled = true; /*WorkTimeItems[6].IsEnabled = false; */}
                    }           
                });
            }
        }

        public RelayCommand PauseTimer_Click
        {
            get
            {
                return new RelayCommand((o) =>
                {

                 if (WorkTimeItems.Count(x => x.IsEnabled == false) > 1)
                    { 
                    WorkTimeItems[6].IsActive = true;                    
                   
                    if (WorkTimeItems[6].IsActive == true)
                    {                    
                        WorkTimeItems[6].IsEnabled = true;
                        WorkTimeItems[6].IsActive = false;

                        SelectedItem.IsEnabled = true;
                        
                   
                        SelectedItem = WorkTimeItems.Where(x => x.IsEnabled == false).First();
                        SelectedItem.IsActive = true;
                    }
                    else
                    {                      
                        SelectedItem.IsActive = false;
                        WorkTimeItems[6].IsActive = true;
                 
                        SelectedItem.IsEnabled = false;              
                    }
                    foreach (var item in WorkTimeItems)
                    {
                        if (item.Name != "Work time" || item.Name != "Break time")
                            item.IsEnabled = false;
                    }
                    WorkTimeItems[6].IsEnabled = true;
                    SelectedItem.StartTime = DateTime.Now;
                    
                    ConnectBase.Insert(User.CurrentUser.ID, SelectedItem.Name, SelectedItem.Note+ "(The break is ongoing..)", SelectedItem.StartTime.ToString(), SelectedItem.StartTime.AddSeconds(1).ToString(), "1");

                    }
                    //ConnectBase.Updates(User.CurrentUser.ID, WorkTimeItems[6].StartTime.ToString(), SelectedItem.StartTime.ToString(), WorkTimeItems[6].Name, "(Робота триває..)", "1");
                }/*, (o) => SelectedItem.IsActive != true*/ );
            }
        }



        public RelayCommand UpdateCloseProgram_Click
        {
            get
            {
                return new RelayCommand((o) =>
                {
                    ConnectBase.Updates(User.CurrentUser.ID, WorkTimeItems[6].StartTime.ToString(), DateTime.Now.ToString(), WorkTimeItems[6].Name, "", "0");
                    //SelectedItem = WorkTimeItems.Where(x => x.IsActive == true).First();
                    ConnectBase.Updates(User.CurrentUser.ID, WorkTimeItems[0].StartTime.ToString(), DateTime.Now.ToString(), WorkTimeItems[0].Name, WorkTimeItems[0].Note, "0");
                    ConnectBase.Updates(User.CurrentUser.ID, WorkTimeItems[1].StartTime.ToString(), DateTime.Now.ToString(), WorkTimeItems[1].Name, WorkTimeItems[1].Note, "0");
                    ConnectBase.Updates(User.CurrentUser.ID, WorkTimeItems[2].StartTime.ToString(), DateTime.Now.ToString(), WorkTimeItems[2].Name, WorkTimeItems[2].Note, "0");
                    ConnectBase.Updates(User.CurrentUser.ID, WorkTimeItems[3].StartTime.ToString(), DateTime.Now.ToString(), WorkTimeItems[3].Name, WorkTimeItems[3].Note, "0");
                    ConnectBase.Updates(User.CurrentUser.ID, WorkTimeItems[4].StartTime.ToString(), DateTime.Now.ToString(), WorkTimeItems[4].Name, WorkTimeItems[4].Note, "0");
                    ConnectBase.Updates(User.CurrentUser.ID, WorkTimeItems[5].StartTime.ToString(), DateTime.Now.ToString(), WorkTimeItems[5].Name, WorkTimeItems[5].Note, "0");

                });
            }
        }

        public void UpdateCloseProgram()
        {
            ConnectBase.Updates(User.CurrentUser.ID, WorkTimeItems[6].StartTime.ToString(), DateTime.Now.ToString(), WorkTimeItems[6].Name, "", "0");
            //SelectedItem = WorkTimeItems.Where(x => x.IsActive == true).First();
            ConnectBase.Updates(User.CurrentUser.ID, SelectedItem.StartTime.ToString(), DateTime.Now.ToString(), SelectedItem.Name, SelectedItem.Note, "0");
        }









        public RelayCommand Test2
        {
            get
            {
                return new RelayCommand((o) =>
                {
                    foreach (var item in WorkTimeItems)
                    {
                        if (item.IsSelected == true)
                        {
                            MessageBox.Show(item.Name);
                            item.IsSelected = !item.IsSelected;
                            break;
                        }
                    }



                });
            }
        }




        //public RelayCommand CurMainPage_Click
        //{
        //    get
        //    {
        //        return new RelayCommand((o) =>
        //        {
        //            MainTabItems[0].IsChecked = false;
        //            MainTabItems[1].IsChecked = true;
        //            MainTabItems[2].IsChecked = true;

        //            CurPageView = MainTabItems[0].ContentPage;
        //            Application.Current.MainWindow.Width = MainTabItems[0].Width;                    
        //        });
        //    }
        //}
        //public RelayCommand CurChartPage_Click
        //{
        //    get
        //    {
        //        return new RelayCommand((o) =>
        //        {
        //            MainTabItems[0].IsChecked = true;
        //            MainTabItems[1].IsChecked = false;
        //            MainTabItems[2].IsChecked = true;

        //            CurPageView = MainTabItems[1].ContentPage;
        //            Application.Current.MainWindow.Width = MainTabItems[1].Width;
        //        });
        //    }
        //}
        //public RelayCommand CurTaskPage_Click
        //{
        //    get
        //    {
        //        return new RelayCommand((o) =>
        //        {
        //            MainTabItems[0].IsChecked = true;
        //            MainTabItems[1].IsChecked = true;
        //            MainTabItems[2].IsChecked = false;

        //            CurPageView = MainTabItems[2].ContentPage;
        //            Application.Current.MainWindow.Width = MainTabItems[2].Width;
        //        });
        //    }
        //}

        ////public RelayCommand CurMainPage_Click
        ////{
        ////    get
        ////    {
        ////        return new RelayCommand((o) =>
        ////        {
        ////            //IsChecked = !IsChecked;
        ////            MainTabItems[0].IsChecked = !MainTabItems[0].IsChecked;
        ////            if (MainTabItems[0].IsChecked == true)
        ////            {
        ////                //CurPageView = MainTabItems[0].ContentPage;
        ////                //Application.Current.MainWindow.Width = MainTabItems[0].Width;
        ////                CurPageView = MainTabItems[0].ContentPage;
        ////                Application.Current.MainWindow.Width = MainTabItems[0].Width;
        ////            }
        ////            else
        ////            {
        ////                CurPageView = MainTabItems[0].ContentPage;
        ////                Application.Current.MainWindow.Width = MainTabItems[0].Width;
        ////            }
        ////        });
        ////    }
        ////}



    }
}
