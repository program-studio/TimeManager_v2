using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeManager.ViewModel;

namespace TimeManager.Model
{
    public class TimeChartBlockModel : BaseViewModel
    {
        public ObservableCollection<TimeModel> userTimers = new ObservableCollection<TimeModel>();
        public User SelectedUser { get; set; }
        public ObservableCollection<TimeModel> UserTimers { get { return userTimers; } set { userTimers = value; OnPropertyChanged(); } }
    }
}
