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

namespace KP.pages.Signal
{
    /// <summary>
    /// Логика взаимодействия для SignalNoAuth.xaml
    /// </summary>
    public partial class SignalNoAuth : Page
    {
        Window main;
        public SignalNoAuth(Window mainwin)
        {
            main = mainwin;
            InitializeComponent();
        }

        private void Join_Click(object sender, RoutedEventArgs e)
        {
            Auth login = new Auth(main);
            BlurEffect objBlur = new BlurEffect();
            objBlur.Radius = 10;
            main.Effect = objBlur;
            login.ShowDialog();
        }
    }
}
