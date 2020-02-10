using System;
using System.Collections.Generic;
using System.Linq;
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

namespace TimeManager.Pages
{
    /// <summary>
    /// Interaction logic for TestMessageBox.xaml
    /// </summary>
    public partial class MessageBoxCustom : Window
    {
        public MessageBoxCustom()
        {
            InitializeComponent();
        }

        private void BtmClose_Click(object sender, RoutedEventArgs e)  // закриття форми !
        {
            this.Close();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)  // пересування вікна по робочому столі !!!
        {
            this.DragMove();
        }


        void AddButtons(MessageBoxButton buttons)
        {
            switch (buttons)
            {
                case MessageBoxButton.OK:
                    AddButton("OK", MessageBoxResult.OK);
                    break;
                case MessageBoxButton.OKCancel:
                    AddButton("Ok", MessageBoxResult.OK);
                    AddButton("Delay", MessageBoxResult.Cancel);
                    //AddButton("OK", MessageBoxResult.OK);
                    //AddButton("Cancel", MessageBoxResult.Cancel, isCancel: true);
                    break;
                case MessageBoxButton.YesNo:
                    AddButton("Yes", MessageBoxResult.Yes);
                    AddButton("No", MessageBoxResult.No);
                    break;
                case MessageBoxButton.YesNoCancel:
                    AddButton("Yes", MessageBoxResult.Yes);
                    AddButton("No", MessageBoxResult.No);
                    AddButton("Cancel", MessageBoxResult.Cancel, isCancel: true);
                    break;
                default:
                    throw new ArgumentException("Unknown button value", "buttons");
            }
        }

        void AddButton(string text, MessageBoxResult result, bool isCancel = false)
        {
            var button = new Button() { Content = text, IsCancel = isCancel };
            button.Click += (o, args) => { Result = result; DialogResult = true; };
            ButtonContainer.Children.Add(button);
        }

        MessageBoxResult Result = MessageBoxResult.None;

        public static MessageBoxResult Show(string caption, string message, MessageBoxButton buttons)
        {
            var dialog = new MessageBoxCustom() { Title = caption };
            dialog.MessageContainerTName.Text = message;
            dialog.AddButtons(buttons);
            dialog.ShowDialog();
            return dialog.Result;
        }

        public static MessageBoxResult Show(string caption, string messageTName, string messageTBody, string messageTTime, MessageBoxButton buttons)
        {
            var dialog = new MessageBoxCustom() { Title = caption };
            dialog.MessageContainerTName.Text = messageTName;
            dialog.MessageContainerTBody.Text = messageTBody;
            dialog.MessageContainerTTime.Text = messageTTime;
            dialog.AddButtons(buttons);
            dialog.ShowDialog();
            return dialog.Result;
        }

    }
}
