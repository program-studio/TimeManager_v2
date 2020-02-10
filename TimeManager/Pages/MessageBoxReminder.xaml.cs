using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TimeManager.Model;
using TimeManager.ViewModel;

namespace TimeManager.Pages
{
    /// <summary>
    /// Interaction logic for MessageBoxReminder.xaml
    /// </summary>
    public partial class MessageBoxReminder : Window, INotifyPropertyChanged
    {

        public MessageBoxReminder()
        {
            InitializeComponent();

        }

        private TaskModel reminderItem;
        public TaskModel ReminderItem { get { return reminderItem; } set { reminderItem = value; OnPropertyChanged(); } }

        private bool isOk = false;
        public bool IsOk { get { return isOk; } set { isOk = value; OnPropertyChanged(); } }
 

        public MessageBoxReminder(TaskModel m)
        {
            //InitializeComponent();
            ReminderItem = m;

            DataContext = ReminderItem;
        }


        ////public MessageBoxReminder(string TaskName, string TaskBody, DateTime ReminderTime)
        ////{          
        ////    TaskNameTb.Text = TaskName;
        ////    TaskBodyTb.Text = TaskBody;
        ////    TaskRemindetTimeTb.Text = ReminderTime.ToShortTimeString() + " (" + ReminderTime.ToShortDateString() + ")";
        ////}

        private void BtmClose_Click(object sender, RoutedEventArgs e)  // закриття форми !
        {
            this.Close();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)  // пересування вікна по робочому столі !!!
        {
            this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(myModel.ReminderTime.ToLongTimeString());
            ReminderItem.ReminderTime = DateTime.Now.AddSeconds(3);
            IsOk = true;
            this.Close();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }



       



    }
}
