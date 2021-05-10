using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace KP.pages.AuthorizationFrames
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        Window mainwin;
        public Auth(Window win)
        {
            mainwin = win;
            InitializeComponent();
            AuthFrame.Content = new Login(mainwin,this);
        }
        private void Close_Window(object sender, RoutedEventArgs e)
        {
            mainwin.Effect = null;
            AuthWindow.Close();
        }

        private void SignIn_Click(object sender, MouseButtonEventArgs e)
        {
            AuthFrame.Content = new SignIn(mainwin,AuthWindow);
            label1.Foreground = (Brush)(new BrushConverter().ConvertFrom("black"));
            label2.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF6762DC"));
            
        }

        private void Login_Click(object sender, MouseButtonEventArgs e)
        {
            AuthFrame.Content = new Login(mainwin,this);
            label2.Foreground = (Brush)(new BrushConverter().ConvertFrom("black"));
            label1.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF6762DC"));
        }

        private void Facebook_Click(object sender, MouseButtonEventArgs e)
        {
            Process.Start("https://ru-ru.facebook.com/");
        }

        private void Gmail_Click(object sender, MouseButtonEventArgs e)
        {
            Process.Start("https://mail.yandex.by/?uid=599989759#inbox");
        }

        private void Git_Click(object sender, MouseButtonEventArgs e)
        {
            Process.Start("https://github.com/alex47715");
        }
    }
}
