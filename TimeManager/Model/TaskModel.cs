using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;
using TimeManager.ViewModel;
using TimeManager.Pages;

namespace TimeManager.Model
{
    public class TaskModel : BaseViewModel
    {
        private string categoryName;
        public string CategoryName { get { return categoryName; } set { categoryName = value; OnPropertyChanged(); } }
        private string taskName;
        public string TaskName { get { return taskName; } set { taskName = value; OnPropertyChanged(); } }
        private string taskBody;
        public string TaskBody { get { return taskBody; } set { taskBody = value; OnPropertyChanged(); } }
        private int iD;
        public int ID { get { return iD; } set { iD = value; OnPropertyChanged(); } }
        private DateTime createTime = DateTime.Now;
        public DateTime CreateTime { get { return createTime; } set { createTime = value; OnPropertyChanged(); } }
        private DateTime createTaskTime = DateTime.Now;
        public DateTime CreateTaskTime { get { return createTaskTime; } set { createTaskTime = value; OnPropertyChanged(); } }

        private DateTime reminderTime = DateTime.Now.AddSeconds(-1);  //DateTime.Now.AddSeconds(-1);
        public DateTime ReminderTime { get {  return reminderTime; } set { reminderTime = value; if (isReminder == true && ChackedHour != "00" && ChackedMinute != "00" && IsReminderMessage == false) reminderTime = new DateTime(reminderTime.Year, reminderTime.Month, reminderTime.Day, Convert.ToInt32(ChackedHour), Convert.ToInt32(ChackedMinute), 0); if (isReminder == true) { chackedHour = reminderTime.Hour.ToString(); chackedMinute = reminderTime.Minute.ToString(); }; OnPropertyChanged(); } }
        // if (IsReminderMessage == true) return reminderTime;
        private List<string> hourList = new List<string>();
        public List<string> HourList { get { hourList = new List<string>(); for (int i = 0; i < 24; i++) { if (i < 10) hourList.Add("0" + i.ToString()); else hourList.Add(i.ToString()); }; return hourList; } set { hourList = value; OnPropertyChanged(); } }
        private List<string> minuteList = new List<string>();
        public List<string> MinuteList { get { minuteList = new List<string>(); for (int i = 0; i < 60; i++) { if (i < 10) minuteList.Add("0" + i.ToString()); else minuteList.Add(i.ToString()); ; }; return minuteList; } set { minuteList = value; OnPropertyChanged(); } }

        private string chackedHour = "00";
        public string ChackedHour { get { if (chackedHour.Length == 1) chackedHour = "0" + chackedHour; return chackedHour; } set { chackedHour = value; if (isReminder == true) reminderTime = new DateTime(reminderTime.Year, reminderTime.Month, reminderTime.Day, Convert.ToInt32(ChackedHour), Convert.ToInt32(ChackedMinute), 0); OnPropertyChanged(); } }
        private string chackedMinute = "00";
        public string ChackedMinute { get { if (chackedMinute.Length == 1) chackedMinute = "0" + chackedMinute; return chackedMinute; } set { chackedMinute = value; if (isReminder == true) reminderTime = new DateTime(reminderTime.Year, reminderTime.Month, reminderTime.Day, Convert.ToInt32(ChackedHour), Convert.ToInt32(ChackedMinute), 0); OnPropertyChanged(); } }
        // if (isReminder == true) chackedMinute = ReminderTime.Minute.ToString();

        private string priority = "normal";
        public string Priority { get { return priority; } set { priority = value; OnPropertyChanged(); } }
        private List<string> priorityList = new List<string> { "high", "normal", "low" };
        public List<string> PriorityList { get { return priorityList; } set { priorityList = value; OnPropertyChanged(); } }
        private bool canDeleted = true;
        public bool CanDeleted { get { return canDeleted; } set { canDeleted = value; OnPropertyChanged(); } }
        private bool isFavorite = false;
        public bool IsFavorite { get { return isFavorite; } set { isFavorite = value; OnPropertyChanged(); } }
        private bool isReminder = false;
        public bool IsReminder { get { return isReminder; } set { isReminder = value; if (value) timer.Start(); else timer.Stop(); OnPropertyChanged(); } }  // if (isReminder == true) { ChackedHour = ReminderTime.Hour.ToString(); ChackedMinute = ReminderTime.Minute.ToString(); };
        //public bool IsReminder { get { return isReminder; } set { isReminder = value; if (isReminder == true && ChackedHour == "00" && ChackedMinute == "00") { ChackedHour = DateTime.Now.Hour.ToString(); ChackedMinute = DateTime.Now.Minute.ToString(); }; OnPropertyChanged(); } }
        private bool isReminderMessage = false;
        public bool IsReminderMessage { get { return isReminderMessage; } set { isReminderMessage = value; OnPropertyChanged(); } }
        private bool isVisible = false;
        public bool IsVisible { get { return isVisible; } set { isVisible = value; OnPropertyChanged(); } }
        private bool isActive = true;
        public bool IsActive { get { return isActive; } set { isActive = value; OnPropertyChanged(); } }

     




        private ObservableCollection<TaskModel> task = new ObservableCollection<TaskModel>();
        public ObservableCollection<TaskModel> Task { get { return task; } set { task = value; OnPropertyChanged(); } }

        //private Page contentPage;
        //public Page ContentPage { get { return contentPage; } set { contentPage = value; OnPropertyChanged(); } }

        //private Brush brush;
        //public Brush Brush { get { return brush; } set { brush = value; OnPropertyChanged(); } }

        //public DateTime ReminderTime { get {  reminderTime = new DateTime(reminderTime.Year, reminderTime.Month, reminderTime.Day, Convert.ToInt32(ChackedHour), Convert.ToInt32(ChackedMinute), 0); return reminderTime; } set { reminderTime = value; OnPropertyChanged(); } }   // виправити додавання часу !
        //public DateTime ReminderTime { get { return reminderTime.AddHours(ChackedHour).AddMinutes(ChackedMinute); } set { reminderTime = value; OnPropertyChanged(); } }   // виправити додавання часу !

        //public DateTime ReminderTime { get {  return reminderTime; } set { reminderTime = value; OnPropertyChanged(); } } 

        //TimeSpan ts = new TimeSpan(0, 0, 0);
        //private Window reminderWindow;
        //public Window ReminderWindow { get { return reminderWindow; } set { reminderWindow = value; OnPropertyChanged(); } }

        private DispatcherTimer timer = new DispatcherTimer();

        public TaskModel()
        {            
            timer.Tick += timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 1);          
        }


        public void timer_Tick(object sender, EventArgs e)
        {
            if (ReminderTime.Date == DateTime.Now.Date && ReminderTime.Hour == DateTime.Now.Hour && ReminderTime.Minute == DateTime.Now.Minute && ReminderTime.Second == DateTime.Now.Second)
            {
                if (MessageBoxCustom.Show("Reminder", TaskName, TaskBody, ReminderTime.ToString("dd.MM.yyyy (HH:mm:ss)"), MessageBoxButton.OKCancel) == MessageBoxResult.Cancel)
                {
                    IsReminderMessage = true;
                    //ReminderTime = DateTime.Now.AddSeconds(5);
                    ReminderTime = DateTime.Now.AddMinutes(15);
                }
                else
                {
                    IsReminder = false;
                    IsReminderMessage = false;
                }
                

                ////MessageBox.Show(ReminderTime.ToLongTimeString());
                ////TaskModel NewReminder = new TaskModel();
                ////ReminderWindow = new MessageBoxReminder(TaskName, TaskBody, ReminderTime);

                //IsReminderMessage = true;      

                ////ReminderWindow = new MessageBoxReminder();
                //ReminderWindow = new MessageBoxReminder(this);
                //ReminderWindow.Show();

                //if (ReminderWindow.ShowDialog() == true)
                //{
                //    MessageBox.Show("Авторизация пройдена");
                //}

                //IsReminder = false;
            }
        }






    }
}
