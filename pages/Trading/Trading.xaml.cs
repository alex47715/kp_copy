using KP.Entity;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace KP
{
    /// <summary>
    /// Логика взаимодействия для Trading.xaml
    /// </summary>
    public partial class Trading : Page
    {
        public Trading()
        {
            InitializeComponent();
        }
        private void Main_Navigate(object sender, RoutedEventArgs e)

        {
            NavigationService.Navigate(new Page1());
        }
        private void Markets_Navigate(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Markets());
        }

        

        private void combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (combo.SelectedIndex)
            {
                case 0:
                    Arrow1.Fill = new SolidColorBrush(Color.FromRgb(255, 181, 21));
                    CryptoText.Text = "BTC";
                    CryptoName1.Text = "BTC";
                    FirstLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\BTC.svg");
                    break;
                case 1:
                    Arrow1.Fill = new SolidColorBrush(Color.FromRgb(62, 39, 155));
                    CryptoText.Text = "ETH";
                    CryptoName1.Text = "ETH";
                    FirstLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\ETH.svg");
                    break;
                case 2:
                    Arrow1.Fill = new SolidColorBrush(Color.FromRgb(255, 181, 21));
                    CryptoText.Text = "BNB";
                    CryptoName1.Text = "BNB";
                    FirstLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\BNB.svg");
                    break;
                case 3:
                    Arrow1.Fill = new SolidColorBrush(Color.FromRgb(69, 196, 173));
                    CryptoText.Text = "USDT";
                    CryptoName1.Text = "USDT";
                    FirstLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\USDT.svg");
                    break;
                case 4:
                    Arrow1.Fill = new SolidColorBrush(Color.FromRgb(131, 0, 200));
                    CryptoText.Text = "DOT";
                    CryptoName1.Text = "DOT";
                    FirstLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\DOT.svg");
                    break;
                case 5:
                    Arrow1.Fill = new SolidColorBrush(Color.FromRgb(62, 39, 155));
                    CryptoText.Text = "ADA";
                    CryptoName1.Text = "ADA";
                    FirstLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\ADA.svg");
                    break;
                case 6:
                    Arrow1.Fill = new SolidColorBrush(Color.FromRgb(0, 183, 239));
                    CryptoText.Text = "XRP";
                    CryptoName1.Text = "XRP";
                    FirstLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\XRP.svg");
                    break;
                case 7:
                    Arrow1.Fill = new SolidColorBrush(Color.FromRgb(0, 183, 239));
                    CryptoText.Text = "LINK";
                    CryptoName1.Text = "LINK";
                    FirstLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\LINK.svg");
                    break;
                case 8:
                    Arrow1.Fill = new SolidColorBrush(Color.FromRgb(69, 196, 173));
                    CryptoText.Text = "BCH";
                    CryptoName1.Text = "BCH";
                    FirstLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\BCH.svg");
                    break;
                case 9:
                    Arrow1.Fill = new SolidColorBrush(Color.FromRgb(177, 170, 169));
                    CryptoText.Text = "XLM";
                    CryptoName1.Text = "XLM";
                    FirstLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\XLM.svg");
                    break;
                case 10:
                    Arrow1.Fill = new SolidColorBrush(Color.FromRgb(245, 55, 229));
                    CryptoText.Text = "UNI";
                    CryptoName1.Text = "UNI";
                    FirstLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\UNI.svg");
                    break;
                case 11:
                    Arrow1.Fill = new SolidColorBrush(Color.FromRgb(0, 183, 239));
                    CryptoText.Text = "USDC";
                    CryptoName1.Text = "USDC";
                    FirstLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\USDC.svg");
                    break;
                case 12:
                    Arrow1.Fill = new SolidColorBrush(Color.FromRgb(255, 181, 21));
                    CryptoText.Text = "DOGE";
                    CryptoName1.Text = "DOGE";
                    FirstLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\DOGE.svg");
                    break;
                case 13:
                    Arrow1.Fill = new SolidColorBrush(Color.FromRgb(255, 181, 21));
                    CryptoText.Text = "WBTC";
                    CryptoName1.Text = "WBTC";
                    FirstLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\WDTC.svg");
                    break;
                case 14:
                    Arrow1.Fill = new SolidColorBrush(Color.FromRgb(49, 250, 229));
                    CryptoText.Text = "XEM";
                    CryptoName1.Text = "XEM";
                    FirstLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\XEM.svg");
                    break;
                case 15:
                    Arrow1.Fill = new SolidColorBrush(Color.FromRgb(103, 80, 126));
                    CryptoText.Text = "EOS";
                    CryptoName1.Text = "EOS";
                    FirstLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\EOS.svg");
                    break;
                case 16:
                    Arrow1.Fill = new SolidColorBrush(Color.FromRgb(103, 220, 255));
                    CryptoText.Text = "HT";
                    CryptoName1.Text = "HT";
                    FirstLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\HT.svg");
                    break;
                case 17:
                    Arrow1.Fill = new SolidColorBrush(Color.FromRgb(103, 80, 126));
                    CryptoText.Text = "ATOM";
                    CryptoName1.Text = "ATOM";
                    FirstLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\ATOM.svg");
                    break;
                case 18:
                    Arrow1.Fill = new SolidColorBrush(Color.FromRgb(242, 116, 43));
                    CryptoText.Text = "XMR";
                    CryptoName1.Text = "XMR";
                    FirstLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\XMR.svg");
                    break;
                case 19:
                    Arrow1.Fill = new SolidColorBrush(Color.FromRgb(242, 71, 43));
                    FirstLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\TRX.svg");
                    CryptoName1.Text = "TRX";
                    CryptoText.Text = "TRX";
                    break;
                case 20:
                    Arrow1.Fill = new SolidColorBrush(Color.FromRgb(127, 125, 135));
                    CryptoText.Text = "IOTA";
                    CryptoName1.Text = "IOTA";
                    FirstLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\IOTA.svg");
                    break;
                case 21:
                    Arrow1.Fill = new SolidColorBrush(Color.FromRgb(125, 124, 133));
                    CryptoText.Text = "NEO";
                    CryptoName1.Text = "NEO";
                    FirstLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\NEO.svg");
                    break;
                case 22:
                    Arrow1.Fill = new SolidColorBrush(Color.FromRgb(49, 250, 229));
                    CryptoText.Text = "VET";
                    CryptoName1.Text = "VET";
                    FirstLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\VET.svg");
                    break;
                

            }
                
        }
        private void combo_SelectionChanged2(object sender, SelectionChangedEventArgs e)
        {
            switch (combo2.SelectedIndex)
            {
                case 0:
                    Arrow2.Fill = new SolidColorBrush(Color.FromRgb(255, 181, 21));
                    CryptoText2.Text = "BTC";
                    CryptoName2.Text = "BTC";
                    SecondLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\BTC.svg");
                    break;
                case 1:
                    Arrow2.Fill = new SolidColorBrush(Color.FromRgb(62, 39, 155));
                    CryptoText2.Text = "ETH";
                    CryptoName2.Text = "ETH";
                    SecondLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\ETH.svg");
                    break;
                case 2:
                    Arrow2.Fill = new SolidColorBrush(Color.FromRgb(255, 181, 21));
                    CryptoText2.Text = "BNB";
                    CryptoName2.Text = "BNB";
                    SecondLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\BNB.svg");
                    break;
                case 3:
                    Arrow2.Fill = new SolidColorBrush(Color.FromRgb(69, 196, 173));
                    CryptoText2.Text = "USDT";
                    CryptoName2.Text = "USDT";
                    SecondLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\USDT.svg");
                    break;
                case 4:
                    Arrow2.Fill = new SolidColorBrush(Color.FromRgb(131, 0, 200));
                    CryptoText2.Text = "DOT";
                    CryptoName2.Text = "DOT";
                    SecondLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\DOT.svg");
                    break;
                case 5:
                    Arrow2.Fill = new SolidColorBrush(Color.FromRgb(62, 39, 155));
                    CryptoText2.Text = "ADA";
                    CryptoName2.Text = "ADA";
                    SecondLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\ADA.svg");
                    break;
                case 6:
                    Arrow2.Fill = new SolidColorBrush(Color.FromRgb(0, 183, 239));
                    CryptoText2.Text = "XRP";
                    CryptoName2.Text = "XRP";
                    SecondLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\XRP.svg");
                    break;
                case 7:
                    Arrow2.Fill = new SolidColorBrush(Color.FromRgb(0, 183, 239));
                    CryptoText2.Text = "LINK";
                    CryptoName2.Text = "LINK";
                    SecondLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\LINK.svg");
                    break;
                case 8:
                    Arrow2.Fill = new SolidColorBrush(Color.FromRgb(69, 196, 173));
                    CryptoText2.Text = "BCH";
                    CryptoName2.Text = "BCH";
                    SecondLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\BCH.svg");
                    break;
                case 9:
                    Arrow2.Fill = new SolidColorBrush(Color.FromRgb(177, 170, 169));
                    CryptoText2.Text = "XLM";
                    CryptoName2.Text = "XLM";
                    SecondLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\XLM.svg");
                    break;
                case 10:
                    Arrow2.Fill = new SolidColorBrush(Color.FromRgb(245, 55, 229));
                    CryptoText2.Text = "UNI";
                    CryptoName2.Text = "UNI";
                    SecondLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\UNI.svg");
                    break;
                case 11:
                    Arrow2.Fill = new SolidColorBrush(Color.FromRgb(0, 183, 239));
                    CryptoText2.Text = "USDC";
                    CryptoName2.Text = "USDC";
                    SecondLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\USDC.svg");
                    break;
                case 12:
                    Arrow2.Fill = new SolidColorBrush(Color.FromRgb(255, 181, 21));
                    CryptoText2.Text = "DOGE";
                    CryptoName2.Text = "DOGE";
                    SecondLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\DOGE.svg");
                    break;
                case 13:
                    Arrow2.Fill = new SolidColorBrush(Color.FromRgb(255, 181, 21));
                    CryptoText2.Text = "WBTC";
                    CryptoName2.Text = "WBTC";
                    SecondLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\WBTC.svg");
                    break;
                case 14:
                    Arrow2.Fill = new SolidColorBrush(Color.FromRgb(49, 250, 229));
                    CryptoText2.Text = "XEM";
                    CryptoName2.Text = "XEM";
                    SecondLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\XEM.svg");
                    break;
                case 15:
                    Arrow2.Fill = new SolidColorBrush(Color.FromRgb(103, 80, 126));
                    CryptoText2.Text = "EOS";
                    CryptoName2.Text = "EOS";
                    SecondLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\EOS.svg");
                    break;
                case 16:
                    Arrow2.Fill = new SolidColorBrush(Color.FromRgb(103, 220, 255));
                    CryptoText2.Text = "HT";
                    CryptoName2.Text = "HT";
                    SecondLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\HT.svg");
                    break;
                case 17:
                    Arrow2.Fill = new SolidColorBrush(Color.FromRgb(103, 80, 126));
                    CryptoText2.Text = "ATOM";
                    CryptoName2.Text = "ATOM";
                    SecondLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\ATOM.svg");
                    break;
                case 18:
                    Arrow2.Fill = new SolidColorBrush(Color.FromRgb(242, 116, 43));
                    CryptoText2.Text = "XMR";
                    CryptoName2.Text = "XMR";
                    SecondLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\XMR.svg");
                    break;
                case 19:
                    Arrow2.Fill = new SolidColorBrush(Color.FromRgb(242, 71, 43));
                    CryptoText2.Text = "TRX";
                    CryptoName2.Text = "TRX";
                    SecondLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\TRX.svg");
                    break;
                case 20:
                    Arrow2.Fill = new SolidColorBrush(Color.FromRgb(127, 125, 135));
                    CryptoText2.Text = "IOTA";
                    CryptoName2.Text = "IOTA";
                    SecondLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\IOTA.svg");
                    break;
                case 21:
                    Arrow2.Fill = new SolidColorBrush(Color.FromRgb(125, 124, 133));
                    CryptoText2.Text = "NEO";
                    CryptoName2.Text = "NEO";
                    SecondLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\NEO.svg");
                    break;
                case 22:
                    Arrow2.Fill = new SolidColorBrush(Color.FromRgb(49, 250, 229));
                    CryptoText2.Text = "VET";
                    CryptoName2.Text = "VET";
                    SecondLogo.Source = new Uri(@"C:\Labs\OOP2\KP\KP\IconsMarket\VET.svg");
                    break;


            }
        }

        private void Focus_TextBox1(object sender, DependencyPropertyChangedEventArgs e)
        {
            //if (TextCounttoken.Text == "" && !TextCounttoken.IsKeyboardFocused)
            //{
            //    TextCounttoken.Text = "0.00";
            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TextCounttoken.Text == "0.00"|| TextCounttoken.Text == "" || TextCounttoken.Text.Contains("-") || TextCounttoken.Text.Contains("!"))
            {
                MessageBox.Show("Error!");
                return;
            }
            string result = TextCounttoken.Text.ToString().Replace('.', ',');
            UserCreator.Trade("kil", CryptoText.Text, CryptoText2.Text, float.Parse(result));

        }

        private async void Converter(object sender, RoutedEventArgs e)
        {
            if (TextCounttoken.Text == "0.00"|| TextCounttoken.Text == "" || TextCounttoken.Text.Contains("-") || TextCounttoken.Text.Contains("!"))
            {
                MessageBox.Show("Error!");
                return;
            }
            string result = TextCounttoken.Text.ToString().Replace('.', ',');
            
            TextCounttoken1.Text = await UserCreator.ConverterResult("kil", CryptoText.Text, CryptoText2.Text, float.Parse(result));
            USDTFirst.Text = await UserCreator.USDAsyncPrice(CryptoText.Text, float.Parse(result));
        }

        private void Remove_Focus(object sender, MouseButtonEventArgs e)
        {
            if (Keyboard.FocusedElement is TextBox felem)
                if (sender != felem)
                {
                    Keyboard.ClearFocus();
                    Converter(null, null);
                }
        }
    }
}
