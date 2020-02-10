using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TimeManager.Model;
using TimeManager.Pages;

namespace TimeManager.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {

        private ObservableCollection<MainWindowModel> mainTabItems = new ObservableCollection<MainWindowModel>();
        public ObservableCollection<MainWindowModel> MainTabItems { get { return mainTabItems; } set { mainTabItems = value;  OnPropertyChanged(); } }

        private Page curPageView;
        public Page CurPageView { get { return curPageView; } set { curPageView = value; OnPropertyChanged(); } }

        private TaskViewModel taskVM = new TaskViewModel();
        public TaskViewModel TaskVM { get { return taskVM; } set { taskVM = value;  OnPropertyChanged(); } }



        public MainWindowViewModel()
        {


            MainTabItems.Add(new MainWindowModel() { Header = "TimeManager", ContentPage = new MainPage(), Width = 500, Height=620, ResizeMode = ResizeMode.NoResize });
            MainTabItems.Add(new MainWindowModel() { Header = "TimeChart", ContentPage = new ChartPage(), Width = 1000, Height = 700 });
            MainTabItems.Add(new MainWindowModel() { Header = "Tasks", ContentPage = new TaskPage(), Width = 1000, Height = 700 }); // TaskVM
            MainTabItems[0].IsChecked = false;
            CurPageView = MainTabItems[0].ContentPage;
            MainTabItems[2].ContentPage.DataContext = TaskVM; // !!!!!!!!!!!!


            Application.Current.MainWindow.Width = MainTabItems[0].Width;  // Зміна розміру вікна

        }



        public RelayCommand CurMainPage_Click
        {
            get
            {
                return new RelayCommand((o) =>
                {
                    MainTabItems[0].IsChecked = false;
                    MainTabItems[1].IsChecked = true;
                    MainTabItems[2].IsChecked = true;
                    //MainTabItems[1].Width = (int)Application.Current.MainWindow.Width;
                    //MainTabItems[2].Width = (int)Application.Current.MainWindow.Width;
                    //MainTabItems[1].Height = (int)Application.Current.MainWindow.Height;
                    //MainTabItems[2].Height = (int)Application.Current.MainWindow.Height;


                    CurPageView = MainTabItems[0].ContentPage;
                    //Application.Current.MainWindow.MinWidth = MainTabItems[0].Width;
                    Application.Current.MainWindow.Width = MainTabItems[0].Width;
                    Application.Current.MainWindow.Height = MainTabItems[0].Height;
                    //Application.Current.MainWindow.ResizeMode = ResizeMode.NoResize;
                });
            }
        }

        public RelayCommand CurChartPage_Click
        {
            get
            {
                return new RelayCommand((o) =>
                {
                    MainTabItems[0].IsChecked = true;
                    MainTabItems[1].IsChecked = false;
                    MainTabItems[2].IsChecked = true;
                    //MainTabItems[1].Width = (int)Application.Current.MainWindow.Width;
                    //MainTabItems[1].Height = (int)Application.Current.MainWindow.Height;
                    //MainTabItems[1].Width = MainTabItems[2].Width;
                    //MainTabItems[1].Height = MainTabItems[2].Height;

                    CurPageView = MainTabItems[1].ContentPage;
                    //CurPageView.Width = 1000;
                    //Application.Current.MainWindow.MinWidth = 1000;
                    //Application.Current.MainWindow.MinHeight = 600;
                    Application.Current.MainWindow.Width = MainTabItems[1].Width;
                    Application.Current.MainWindow.Height = MainTabItems[1].Height;
                    //Application.Current.MainWindow.ResizeMode = ResizeMode.CanResize;
                });
            }
        }

        public RelayCommand CurTaskPage_Click
        {
            get
            {
                return new RelayCommand((o) =>
                {
                    MainTabItems[0].IsChecked = true;
                    MainTabItems[1].IsChecked = true;
                    MainTabItems[2].IsChecked = false;
                    //MainTabItems[2].Width = MainTabItems[1].Width;
                    //MainTabItems[2].Height = MainTabItems[1].Height;

                    CurPageView = MainTabItems[2].ContentPage;
                    ////CurPageView.Width = 1000;
                    //Application.Current.MainWindow.MinWidth = 1000;
                    //Application.Current.MainWindow.MinHeight = 600;
                    Application.Current.MainWindow.Width = MainTabItems[2].Width;
                    Application.Current.MainWindow.Height = MainTabItems[2].Height;
                    //Application.Current.MainWindow.ResizeMode = ResizeMode.CanResize;
                });
            }
        }

        public RelayCommand ReminderVisible_Click
        {
            get
            {
                return new RelayCommand((o) =>
                {                   
                    TaskVM.IsVisible = !TaskVM.IsVisible;
                });
            }
        }





    }
}
