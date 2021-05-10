using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Логика взаимодействия для SignIn.xaml
    /// </summary>
    public partial class SignIn : Page
    {
        Window mainwin;
        Window auth;
        public SignIn(Window _main,Window _auth)
        {
            mainwin = _main;
            auth = _auth;
            InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool result = UserCreator.CreateUser(Text1.Text, Text3.Text, Text2.Text);
            UserCreator.Deposit("kil1", 100);
            UserCreator.Withdraw("kil", 20);
            if (result)
            {
                GoodLogin.Visibility = Visibility.Visible;
                mainwin.Effect = null;
                Button obj = (Button)mainwin.FindName("login");
                obj.Visibility = Visibility.Hidden;
                Button obj2 =(Button)mainwin.FindName("Profile");
                obj2.Visibility = Visibility.Visible;
                obj2.Content = Text1.Text;
                
                auth.Close();

            }
            else
            {
                BadLogin.Visibility = Visibility.Visible;
            }
               
        }
    }
}
