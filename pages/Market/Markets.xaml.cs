using KP.Back;
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

namespace KP
{
    /// <summary>
    /// Логика взаимодействия для Markets.xaml
    /// </summary>
    public partial class Markets : Page
    {
        public Markets()
        {
            InitializeComponent();
            DataContext = new MarketsVM();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }

        private void Bitcoin_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void ETH_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void BNB_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void DOT_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void USDT_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void ADA_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void XRP_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void LTC_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void LINK_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void BCH_Click(object sender, MouseButtonEventArgs e)
        {

        }

        
        private void XLM_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void UNI_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void USDC_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void DOGE_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void WBTC_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void AAVE_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void Navigate_Trading(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Trading());
        }
    }
}
