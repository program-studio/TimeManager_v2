using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using TimeManager.Model;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace TimeManager.ViewModel
{
    public class ChartViewModel:BaseViewModel
    {

        private ObservableCollection<ChartModel> bar = new ObservableCollection<ChartModel>();
        public ObservableCollection<ChartModel> Bar { get { return bar; } set { bar = value; OnPropertyChanged(); } }


        public System.Data.DataTable dt = new System.Data.DataTable();
        public System.Data.DataTable Dt { get { return dt; } set { dt = value; OnPropertyChanged(); } }

        //public UserViewModel usersList = new UserViewModel();
        //public UserViewModel UsersList { get { return usersList; } set { usersList = value; OnPropertyChanged(); } }

        //private UserViewModel selectedUser;
        //public UserViewModel SelectedUser
        //{
        //    get { return selectedUser; }
        //    set
        //    {
        //        //if (SelectedItem != null)
        //        //    SelectedItem.IsActive = false;
        //        selectedUser = value;
        //        //SelectedItem.IsActive = true;
        //        OnPropertyChanged();
        //    }
        //}




        public System.Data.DataTable dtUser = new System.Data.DataTable();
        public System.Data.DataTable DtUser { get { return dtUser; } set { dtUser = value; OnPropertyChanged(); } }
        //private User newUser = new User();
        //public User NewUser { get { return newUser; } set { newUser = value; OnPropertyChanged(); } }

        //private ObservableCollection<User> userInfo = new ObservableCollection<User>();
        //public ObservableCollection<User> UserInfo { get { return userInfo; } set { userInfo = value; OnPropertyChanged(); } }
        //private User selectedUser = new User();
        //public User SelectedUser { get { return selectedUser; } set { selectedUser = value; OnPropertyChanged(); } }
        //private DateTime firstDate = DateTime.Now;
        //public DateTime FirstDate { get { return firstDate; } set { firstDate = value; OnPropertyChanged(); } }
        //private DateTime secondDate = DateTime.Now;
        //public DateTime SecondDate { get { return secondDate; } set { secondDate = value; OnPropertyChanged(); } }

        private ObservableCollection<ChartModel> chartSelectInfo = new ObservableCollection<ChartModel>();
        public ObservableCollection<ChartModel> ChartSelectInfo { get { return chartSelectInfo; } set { chartSelectInfo = value; OnPropertyChanged(); } }
        private ChartModel selectedChartInfo = new ChartModel();
        public ChartModel SelectedChartInfo { get { return selectedChartInfo; } set { selectedChartInfo = value; OnPropertyChanged(); } }

       

        UserViewModel UserViewModel = new UserViewModel();

        //public ObservableCollection<ChartModel> user = new ObservableCollection<ChartModel>();
        //public ObservableCollection<ChartModel> Users { get { return user; } set { user = value; OnPropertyChanged(); } } // Наразі - для відображення в графіку 



        ConnectToBase ConnectBase = new ConnectToBase();

        // LiveCharts
        public LiveCharts.SeriesCollection SeriesCollection { get; set; }
        public Func<ChartPoint, string> PointLabel { get; set; }
        // LiveCharts

        public ChartViewModel()
        {
            Bar.Add(new ChartModel() { Name = "Work time",  Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#019c7c")), WorkTimeSpan = new TimeSpan(6, 30, 0), ImagePath = "M12,20A7,7 0 0,1 5,13A7,7 0 0,1 12,6A7,7 0 0,1 19,13A7,7 0 0,1 12,20M19.03,7.39L20.45,5.97C20,5.46 19.55,5 19.04,4.56L17.62,6C16.07,4.74 14.12,4 12,4A9,9 0 0,0 3,13A9,9 0 0,0 12,22C17,22 21,17.97 21,13C21,10.88 20.26,8.93 19.03,7.39M11,14H13V8H11M15,1H9V3H15V1Z" });
            Bar.Add(new ChartModel() { Name = "Break",  Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#e8ba53")), WorkTimeSpan = new TimeSpan(1, 10, 0), ImagePath = "M2,21H20V19H2M20,8H18V5H20M20,3H4V13A4,4 0 0,0 8,17H14A4,4 0 0,0 18,13V10H20A2,2 0 0,0 22,8V5C22,3.89 21.1,3 20,3Z" });
            Bar.Add(new ChartModel() { Name = "Lunch", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#23c4bf")), WorkTimeSpan = new TimeSpan(0, 45, 0), ImagePath = "M15.5,21L14,8H16.23L15.1,3.46L16.84,3L18.09,8H22L20.5,21H15.5M5,11H10A3,3 0 0,1 13,14H2A3,3 0 0,1 5,11M13,18A3,3 0 0,1 10,21H5A3,3 0 0,1 2,18H13M3,15H8L9.5,16.5L11,15H12A1,1 0 0,1 13,16A1,1 0 0,1 12,17H3A1,1 0 0,1 2,16A1,1 0 0,1 3,15Z" });
            Bar.Add(new ChartModel() { Name = "Meeting",  Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#008eb3")), WorkTimeSpan = new TimeSpan(0, 30, 0), ImagePath = "M4,15H6A2,2 0 0,1 8,17V19H9V17A2,2 0 0,1 11,15H13A2,2 0 0,1 15,17V19H16V17A2,2 0 0,1 18,15H20A2,2 0 0,1 22,17V19H23V22H1V19H2V17A2,2 0 0,1 4,15M11,7L15,10L11,13V7M4,2H20A2,2 0 0,1 22,4V13.54C21.41,13.19 20.73,13 20,13V4H4V13C3.27,13 2.59,13.19 2,13.54V4A2,2 0 0,1 4,2Z" });
            Bar.Add(new ChartModel() { Name = "Study",  Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f4656d")), WorkTimeSpan = new TimeSpan(0, 20, 0), ImagePath = "M12,3L1,9L12,15L21,10.09V17H23V9M5,13.18V17.18L12,21L19,17.18V13.18L12,17L5,13.18Z" });
            Bar.Add(new ChartModel() { Name = "Exit note", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#a7bfd0")), WorkTimeSpan = new TimeSpan(0, 10, 0), ImagePath = "M12,15H10V13H12V15M18,15H14V13H18V15M8,11H6V9H8V11M18,11H10V9H18V11M20,20H4A2,2 0 0,1 2,18V6A2,2 0 0,1 4,4H20A2,2 0 0,1 22,6V18A2,2 0 0,1 20,20M4,6V18H20V6H4Z" });
            Bar.Add(new ChartModel() { Name = "To the doctor",  Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#bb8f5b")), WorkTimeSpan = new TimeSpan(0, 10, 0), ImagePath = "M18,18.5A1.5,1.5 0 0,0 19.5,17A1.5,1.5 0 0,0 18,15.5A1.5,1.5 0 0,0 16.5,17A1.5,1.5 0 0,0 18,18.5M19.5,9.5H17V12H21.46L19.5,9.5M6,18.5A1.5,1.5 0 0,0 7.5,17A1.5,1.5 0 0,0 6,15.5A1.5,1.5 0 0,0 4.5,17A1.5,1.5 0 0,0 6,18.5M20,8L23,12V17H21A3,3 0 0,1 18,20A3,3 0 0,1 15,17H9A3,3 0 0,1 6,20A3,3 0 0,1 3,17H1V6C1,4.89 1.89,4 3,4H17V8H20M8,6V9H5V11H8V14H10V11H13V9H10V6H8Z" });

            //Users.Add(new ChartModel() { Employee = "Мусійовський Андрій", Department = "ДПК", WorkTimeSpan = new TimeSpan(8, 10, 0) }); // Наразі - для відображення в графіку 
            //Users.Add(new ChartModel() { Employee = "Савка Тарас", Department = "ДПК", WorkTimeSpan = new TimeSpan(7, 59, 0) }); // Наразі - для відображення в графіку 

            //SelectedItem = Users[0];

            foreach (var item in UserViewModel.UserInfo)
            {
                ChartSelectInfo.Add(new ChartModel() { SelectedUser = item as User  });
            }
            //SelectedChartInfo = ChartSelectInfo.First(o => o.SelectedUser.Login == Environment.UserName);
            SelectedChartInfo = ChartSelectInfo.First();


            //DtUser = ConnectBase.Select("SELECT * FROM " + ConnectBase.userBase);
            //for (int i = 0; i < DtUser.Rows.Count; i++)
            //{
            //    //NewUser = new User() { ID = (int)DtUser.Rows[i]["ID"], Login = DtUser.Rows[i]["Login"].ToString(), LastName = DtUser.Rows[i]["LastName"].ToString(), FirstName = DtUser.Rows[i]["FirstName"].ToString(), SurName = DtUser.Rows[i]["SurName"].ToString(), GroupName = DtUser.Rows[i]["GroupName"].ToString(), Position = DtUser.Rows[i]["Position"].ToString() };
            //    //UserInfo.Add(NewUser);
            //    UserInfo.Add(new User() { ID = (int)DtUser.Rows[i]["ID"], Login = DtUser.Rows[i]["Login"].ToString(), LastName = DtUser.Rows[i]["LastName"].ToString(), FirstName = DtUser.Rows[i]["FirstName"].ToString(), SurName = DtUser.Rows[i]["SurName"].ToString(), GroupName = DtUser.Rows[i]["GroupName"].ToString(), Position = DtUser.Rows[i]["Position"].ToString() });
            //}



            //ConnectBase.Select();
            Dt = ConnectBase.Select("SELECT UserBase.FirstName, Break_Type, Break_Notes, Start_Time, End_Time FROM " + ConnectBase.timeBase + ", UserBase WHERE TimeBase.User_ID = UserBase.ID"); // comboBoxUsers.Items[1].ToString()
            //Dt = ConnectBase.Select("SELECT * FROM " + ConnectBase.timeBase);

            //GetUsers();
            //UsersList.UserInfo


            // ----- LiveCharts
            PointLabel = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            SeriesCollection = new LiveCharts.SeriesCollection();

            foreach (var item in Bar)
            {
                TimeSpan timespan = new TimeSpan();
                int index = Bar.IndexOf(item);

                SeriesCollection.Add(new PieSeries {Title = Bar[index].Name + " - " + Bar[index].WorkTimeSpan,
                    Values = new ChartValues<ObservableValue> { new ObservableValue(Bar[index].WorkTimeSpan.TotalMinutes) },
                    DataLabels = true, LabelPoint = chartPoint => string.Format(@"{0:hh\:mm\:ss} ({1:P})", timespan = TimeSpan.FromMinutes(chartPoint.Y), chartPoint.Participation), });
            }
            // ----- LiveCharts


            //SeriesCollection = new SeriesCollection
            //{
            //    //new PieSeries { Title = Bar[0].Name, Values = new ChartValues<ObservableValue> { new ObservableValue(Bar[0].WorkTimeSpan.TotalMinutes) }, DataLabels = true},
            //    //new PieSeries { Title = Bar[1].Name, Values = new ChartValues<ObservableValue> { new ObservableValue(Bar[1].WorkTimeSpan.TotalMinutes) }, DataLabels = true},
            //    //new PieSeries { Title = Bar[2].Name, Values = new ChartValues<ObservableValue> { new ObservableValue(Bar[2].WorkTimeSpan.TotalMinutes) }, DataLabels = true},
            //    //new PieSeries { Title = Bar[3].Name, Values = new ChartValues<ObservableValue> { new ObservableValue(Bar[3].WorkTimeSpan.TotalMinutes) }, DataLabels = true},
            //    //new PieSeries { Title = Bar[4].Name, Values = new ChartValues<ObservableValue> { new ObservableValue(Bar[4].WorkTimeSpan.TotalMinutes) }, DataLabels = true},
            //    //new PieSeries { Title = Bar[5].Name, Values = new ChartValues<ObservableValue> { new ObservableValue(Bar[5].WorkTimeSpan.TotalMinutes) }, DataLabels = true},
            //    //new PieSeries { Title = Bar[6].Name, Values = new ChartValues<ObservableValue> { new ObservableValue(Bar[6].WorkTimeSpan.TotalMinutes) }, DataLabels = true}

            //};


        }



        public RelayCommand Excel_Click
        {
            get
            {
                return new RelayCommand((o) =>
                {


                    Microsoft.Office.Interop.Excel.Application excel = null;
                    Microsoft.Office.Interop.Excel.Workbook wb = null;

                    object missing = Type.Missing;
                    Microsoft.Office.Interop.Excel.Worksheet ws = null;
                    Microsoft.Office.Interop.Excel.Range rng = null;

                    try
                    {
                        excel = new Microsoft.Office.Interop.Excel.Application();
                        wb = excel.Workbooks.Add();
                        ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.ActiveSheet;

                        for (int Idx = 0; Idx < Dt.Columns.Count; Idx++)
                        {
                            ws.Range["A1"].Offset[0, Idx].Value = Dt.Columns[Idx].ColumnName;
                        }

                        for (int Idx = 0; Idx < Dt.Rows.Count; Idx++)
                        {  // <small>hey! I did not invent this line of code, 
                           // I found it somewhere on CodeProject.</small> 
                           // <small>It works to add the whole row at once, pretty cool huh?</small>
                            ws.Range["A2"].Offset[Idx].Resize[1, Dt.Columns.Count].Value =
                            Dt.Rows[Idx].ItemArray;
                        }

                        rng = ws.Range[ws.Cells[1, 1], ws.Cells[Dt.Rows.Count, Dt.Columns.Count]];



                        rng.EntireColumn.AutoFit();
                        Microsoft.Office.Interop.Excel.Borders border = rng.Borders;
                        border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                        border.Weight = 2d;

                        excel.Visible = true;
                        wb.Activate();

                    }
                    //catch (COMException ex)
                    //{
                    //    MessageBox.Show("Error accessing Excel: " + ex.ToString());
                    //}
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.ToString());
                    }



                    //Application excel;
                    //Workbook excelworkBook;
                    //Worksheet excelSheet;
                    //Range excelCellrange;

                    //// Start Excel and get Application object.  
                    //excel = new Application();
                    //// for making Excel visible  
                    //excel.Visible = true;
                    //excel.DisplayAlerts = false;
                    //// Creation a new Workbook  
                    //excelworkBook = excel.Workbooks.Add(Type.Missing);
                    //// Workk sheet  
                    //excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkBook.ActiveSheet;
                    //excelSheet.Name = "Test work sheet";

                    ////excelSheet.Cells[1, 1] = "Sample test data";
                    ////excelSheet.Cells[1, 2] = "Date : " + DateTime.Now.ToShortDateString();
                    //// Headers.  
                    //for (int i = 0; i < Dt.Columns.Count; i++)
                    //{
                    //    excelSheet.Cells[1, i + 1] = Dt.Columns[i].ColumnName;
                    //}
                    //// Content. 
                    //for (int i = 0; i < Dt.Rows.Count; i++)
                    //{
                    //    for (int j = 0; j < Dt.Columns.Count; j++)
                    //    {
                    //        excelSheet.Cells[i + 2, j + 1] = Dt.Rows[i][j].ToString();
                    //    }
                    //}

                    //// now we resize the columns  

                    ////excelSheet.Range["A3", "E3"].Style.Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#bb8f5b"));
                    //excelCellrange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[Dt.Rows.Count, Dt.Columns.Count]];



                    //excelCellrange.EntireColumn.AutoFit();
                    //Microsoft.Office.Interop.Excel.Borders border = excelCellrange.Borders;
                    //border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                    //border.Weight = 2d;

                    ////excelCellrange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[Dt.Rows.Count, Dt.Columns.Count]];
                    ////excelCellrange.Font.Color = Color.FromRgb(1,1,1);


                    ////excelCellrange.Range["A3", "E3"].Interior.Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#bb8f5b"));

                    ////excelCellrange.Interior.Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#bb8f5b"));


                    ////excelCellrange.Range[1].Font.Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#bb8f5b"));

                });
            }
        }




        //public void GetUsers()
        //{
        //    DtUser = ConnectBase.Select("SELECT * FROM " + ConnectBase.userBase);
        //    for (int i = 0; i < DtUser.Rows.Count; i++)
        //    {
        //        NewUser = new User() { ID = (int)DtUser.Rows[i]["ID"], Login = DtUser.Rows[i]["Login"].ToString(), LastName = DtUser.Rows[i]["LastName"].ToString(), FirstName = DtUser.Rows[i]["FirstName"].ToString(), SurName = DtUser.Rows[i]["SurName"].ToString(), GroupName = DtUser.Rows[i]["GroupName"].ToString(), Position = DtUser.Rows[i]["Position"].ToString() };
        //        UserInfo.Add(NewUser);
        //    }

        //}




    }



}

