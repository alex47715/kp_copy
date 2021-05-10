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
using System.Windows.Navigation;
using System.Windows.Shapes;
using KP.Entity;

namespace KP.pages.AuthorizationFrames
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        Window mainwin;
        Window auth;
        public Login(Window win,Window authwin)
        {
            InitializeComponent();
            mainwin = win;
            auth = authwin;
        }

        private void Auth(object sender, RoutedEventArgs e)
        {
            if(UserCreator.Auth(Text1.Text, Text2.Text))
            {
                GoodLogin.Visibility = Visibility.Visible;
                mainwin.Effect = null;
                Button obj = (Button)mainwin.FindName("login");
                obj.Visibility = Visibility.Hidden;
                Button obj2 = (Button)mainwin.FindName("Profile");
                obj2.Visibility = Visibility.Visible;
                obj2.Style= (Style)FindResource("BlueLogin");

                auth.Close();
            }
            else
            {
                BadLogin.Visibility = Visibility.Visible;
            }
        }
    }
}
