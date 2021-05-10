using KP.pages.AuthorizationFrames;
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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KP
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        Window mainwin;
        public Page1(Window window)
        {
            mainwin = window;
            InitializeComponent();
        }
        public Page1()
        {
            
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Markets());
        }

        private void Click_SignIn(object sender, RoutedEventArgs e)
        {
            Auth login = new Auth(mainwin);
            BlurEffect objBlur = new BlurEffect();
            objBlur.Radius = 10;
            mainwin.Effect = objBlur;
            login.AuthFrame.Content = new SignIn(mainwin,login);
            login.label1.Foreground = (Brush)(new BrushConverter().ConvertFrom("black"));
            login.label2.Foreground = (Brush)(new BrushConverter().ConvertFrom("#FF6762DC"));
            login.ShowDialog();
            
        }
    }
}
