using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using TimeManager.ViewModel;
using LiveCharts;
using LiveCharts.Wpf;
using System.Data;
using TimeManager.Model;

namespace TimeManager.Model
{
    public class ChartModel : BaseViewModel
    {
        private string name;
        public string Name { get { return name; } set { name = value; OnPropertyChanged(); } }

        private int data;
        public int Data { get { return data =(int)workTimeSpan.TotalMinutes; } set { data = value; OnPropertyChanged(); } }

        private SolidColorBrush color;
        public SolidColorBrush Color { get { return color; } set { color = value; OnPropertyChanged(); } }

        private string imagePath;
        public string ImagePath { get { return imagePath; } set { imagePath = value; OnPropertyChanged(); } }

        private string procent;   // ???
        public string Procent
        {
            get { return procent = (this.Data / 4).ToString() + "%"; ; }
            set
            {

                //procent = (this.Data - 100).ToString() + "%";
                procent = value;
                OnPropertyChanged();
            }
        }

        private TimeSpan workTimeSpan = new TimeSpan();
        public TimeSpan WorkTimeSpan { get { return workTimeSpan; } set { workTimeSpan = value; OnPropertyChanged(); } }

        //private DateTime firstDate = DateTime.Now;
        //public DateTime FirstDate { get { return firstDate; } set { firstDate = value; OnPropertyChanged(); } }
        //private DateTime secondDate = DateTime.Now;
        //public DateTime SecondDate { get { return secondDate; } set { secondDate = value; OnPropertyChanged(); } }

        //private string department;
        //public string Department { get { return department; } set { department = value; OnPropertyChanged(); } }
        //private string employee;
        //public string Employee { get { return employee; } set { employee = value; OnPropertyChanged(); } }

        private User selectedUser = new User();
        public User SelectedUser { get { return selectedUser; } set { selectedUser = value; OnPropertyChanged(); } }
        private DateTime firstDate = DateTime.Now;
        public DateTime FirstDate { get { return firstDate; } set { firstDate = value; OnPropertyChanged(); } }
        private DateTime secondDate = DateTime.Now;
        public DateTime SecondDate { get { return secondDate; } set { secondDate = value; OnPropertyChanged(); } }
        private bool isSelected =false;
        public bool IsSelected { get { return isSelected; } set { isSelected = value; OnPropertyChanged(); } }
        private string test;
        public string Test { get { test = String.Format(SelectedUser.Login + FirstDate + SecondDate); return test; } set { test = value; OnPropertyChanged(); } }

    }



    //public class Employee : BaseViewModel
    //{
    //    private string _strEmployeeName = string.Empty;
    //    public string EmployeeName
    //    {
    //        get
    //        {
    //            return _strEmployeeName;
    //        }
    //        set
    //        {
    //            _strEmployeeName = value;
    //            OnPropertyChanged();
    //        }
    //    }

    //    public Employee(string employeename)
    //    {
    //        EmployeeName = employeename;
    //    }
    //}

    //public class Position : BaseViewModel
    //{
    //    private ObservableCollection<Employee> employees;

    //    public Position(string positionname)
    //    {
    //        PositionName = positionname;
    //        employees = new ObservableCollection<Employee>()
    //        {
    //            new Employee("Мусійовський Андрій"),
    //            new Employee("Савка Тарас"),
    //            new Employee("Employee3")
    //        };
    //    }

    //    public ObservableCollection<Employee> Employees
    //    {
    //        get
    //        {
    //            return employees;
    //        }
    //        set
    //        {
    //            employees = value;
    //            OnPropertyChanged();
    //        }
    //    }

    //    public string PositionName
    //    {
    //        get;
    //        set;
    //    }
    //}

    //public class Department : BaseViewModel
    //{
    //    private ObservableCollection<Position> positions;

    //    public Department(string depname)
    //    {
    //        DepartmentName = depname;
    //        positions = new ObservableCollection<Position>()
    //        {
    //            new Position("Аналітики ДРС"),
    //            new Position("Юристи ДРС")
    //        };
    //    }
    //    public ObservableCollection<Position> Positions
    //    {
    //        get
    //        {
    //            return positions;
    //        }
    //        set
    //        {
    //            positions = value;
    //            OnPropertyChanged();
    //        }
    //    }
    //    public string DepartmentName
    //    {
    //        get;
    //        set;
    //    }
    //}




}
