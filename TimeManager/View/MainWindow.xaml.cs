using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TimeManager.Model;
using TimeManager.ViewModel;

namespace TimeManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static User curUser = new User();
        public static User CurUser { get { return curUser; } set { curUser = value; } }

        public MainWindow()
        {
          

            InitializeComponent();

            //panel1.MouseLeftButtonDown += new MouseButtonEventHandler(Window_MouseLeftButtonDown);  // пересування вікна по робочому столі ---
            Closing += MainWindow_Closing;

            Uri iconUri = new Uri("pack://application:,,,/time.ico", UriKind.RelativeOrAbsolute);  // іконка програми
            this.Icon = BitmapFrame.Create(iconUri);
        }
        

        private void BtmClose_Click(object sender, RoutedEventArgs e)  // закриття форми !
        {
            this.Close();
        }
        private void BtmMinimize_Click(object sender, RoutedEventArgs e)  // згортання в трейа !
    {
            this.WindowState = WindowState.Minimized;
            //if (WindowState == WindowState.Minimized)
            //    this.Hide();
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)  // пересування вікна по робочому столі !!!
        {
            this.DragMove();
        }

        void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TimeViewModel tvm = new TimeViewModel();
            //tvm.UpdateCloseProgram();            
            tvm.UpdateCloseProgram_Click.Execute(tvm.SelectedItem);

        }









    }


}
