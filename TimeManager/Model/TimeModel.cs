using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;
using TimeManager.ViewModel;

namespace TimeManager.Model
{
    public class TimeModel : BaseViewModel
    {
             
        private int iD;
        public int ID { get { return iD; } set { iD = value; OnPropertyChanged(); } }
        private string name;
        public string Name { get { return name; } set { name = value; OnPropertyChanged(); } }
        private string note = "";
        public string Note { get { return note; } set { note = value; OnPropertyChanged(); } }
        private TimeSpan workTimeSpan = new TimeSpan();
        public TimeSpan WorkTimeSpan { get { return workTimeSpan; } set { workTimeSpan = value; OnPropertyChanged(); } }
        private TimeSpan maxTimeSpan = new TimeSpan();
        public TimeSpan MaxTimeSpan { get { return maxTimeSpan; } set { maxTimeSpan = value; OnPropertyChanged(); } }
        private DateTime startTime = DateTime.Now;
        public DateTime StartTime { get { return startTime; } set { startTime = value; OnPropertyChanged(); } }
        private bool isActive =false;       
        public bool IsActive
        {
            get { return isActive; }
            set
            {
                isActive = value;
                if (value)
                    timer.Start();
                else
                    timer.Stop();
                OnPropertyChanged();
            }
        }
        private bool isSelected = false;
        public bool IsSelected { get { return isSelected; } set { isSelected = value; OnPropertyChanged(); } }
        private bool isEnabled = true;
        public bool IsEnabled { get { return isEnabled; } set { isEnabled = value; OnPropertyChanged(); } }
        private string imagePath;
        public string ImagePath { get { return imagePath; } set { imagePath = value; OnPropertyChanged(); } }
        private SolidColorBrush imageBrush;
        public SolidColorBrush ImageBrush { get { return imageBrush; } set { imageBrush = value; OnPropertyChanged(); } }

        private DispatcherTimer timer = new DispatcherTimer();


        public TimeModel()
        {
            timer.Tick += timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 1);

        }

        public void timer_Tick(object sender, EventArgs e)
        {
            WorkTimeSpan += new TimeSpan(0, 0, 1);
        }


        //private int TimeConvertToInt(TimeSpan t)
        //{
        //    return t.Hours * 60 * 60 + t.Minutes * 60 + t.Seconds;
        //}




    }
}
