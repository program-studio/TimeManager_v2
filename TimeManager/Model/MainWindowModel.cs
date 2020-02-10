using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TimeManager.ViewModel;

namespace TimeManager.Model
{
    public class MainWindowModel : BaseViewModel
    {
        private string header;
        public string Header { get { return header; } set { header = value; OnPropertyChanged(); } }

        private Page contentPage; 
        public Page ContentPage { get { return contentPage; } set { contentPage = value; OnPropertyChanged(); } }

        private int width;
        public int Width { get { return width; } set { width = value; OnPropertyChanged(); } }

        private int height;
        public int Height { get { return height; } set { height = value; OnPropertyChanged(); } }

        public bool isChecked = true;
        public bool IsChecked { get { return isChecked; } set { isChecked = value; OnPropertyChanged(); } }

        private ResizeMode resizeMode;
        public ResizeMode ResizeMode { get { return resizeMode; } set { resizeMode = value; OnPropertyChanged(); } }

    }
}
