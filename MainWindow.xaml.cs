using KP.Entity;
using KP.pages.AuthorizationFrames;
using KP.pages.Signal;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace KP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            login.Style = (Style)FindResource("BlueLogin");
            media.Source = new Uri(@"C:\Labs\OOP2\KP\KP\png\bold-preloader.gif");
            FrameContent.Content = new Page1(mainwin);
            Loading();

        }
        DispatcherTimer timer = new DispatcherTimer();
        private void timer_tick(object sender, EventArgs e)
        {
            timer.Stop();
            mainwin.WindowState = WindowState.Maximized;
            bordermain.CornerRadius = new CornerRadius(20);
            mainwin.Width = 1460;
            bordermain.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));

            mainwin.Height = 800;
            mainwin.MinWidth = 1460;
            mainwin.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            mediarectamgle.Visibility = Visibility.Hidden;
            media.Visibility = Visibility.Hidden;
            firstcol.Visibility = Visibility.Visible;
            secondcol.Visibility = Visibility.Visible;
        }
        void Loading()
        {
            timer.Tick += timer_tick;
            timer.Interval = new TimeSpan(0, 0, 5);
            timer.Start();
        }

        private void Trading_Click(object sender, RoutedEventArgs e)
        {
            FrameContent.Content = new Trading();
            login.Style = (Style)FindResource("BlueLogin");

        }

        private void Main_Click(object sender, MouseButtonEventArgs e)
        {
            FrameContent.Content = new Page1(mainwin);

            login.Style = (Style)FindResource("BlueLogin");
        }

        private void Markets_Click(object sender, RoutedEventArgs e)
        {
            FrameContent.Content = new Markets();
            
            login.Style = (Style)FindResource("BlueLogin");
        }

        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (mainwin.WindowState == WindowState.Maximized)
            {
                mainwin.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                mainwin.WindowState = WindowState.Normal;
                mainwin.Height = 800;
                mainwin.Width = 1460;
            }
            this.DragMove();
        }

        private void Close_Window(object sender, RoutedEventArgs e)
        {
            mainwin.Close();
        }

        private void MinMax_Window(object sender, RoutedEventArgs e)
        {
            if (mainwin.WindowState == WindowState.Maximized)
            {
                mainwin.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                mainwin.WindowState = WindowState.Normal;
                mainwin.Height = 800;
                mainwin.Width = 1460;
            }
            else
                mainwin.WindowState = WindowState.Maximized;


        }

        private void Main_Page(object sender, MouseButtonEventArgs e)
        {
            FrameContent.Content = new Page1(mainwin);
            login.Style = (Style)FindResource("BlueLogin");
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Auth login = new Auth(mainwin);
            BlurEffect objBlur = new BlurEffect();
            objBlur.Radius = 10;
            mainwin.Effect = objBlur;
            login.ShowDialog();
            

        }

        private void Signal_Click(object sender, RoutedEventArgs e)
        {
            if (UserCreator.AuthStatus())
            {
                FrameContent.Content = new Trading();
            }
            else
            {
                FrameContent.Content = new SignalNoAuth(mainwin);
                login.Style = (Style)FindResource("PinkLogin");
            }
            
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            FrameContent.Content = new Trading();
        }
    }
}
