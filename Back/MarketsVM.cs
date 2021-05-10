using KP.Entity;
using Nancy.Helpers;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KP.Back
{
    public class MarketsVM:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string API_KEY = "1fb562f6-b88a-4884-8fe4-ddfb9019e050";
        private string API_ANSWER = "";
        
        public void OnPropertyChanged([CallerMemberName]string propertyName="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private double _AllPrices;
        private double _PriceBTC;
        private double _PriceETH;
        private double _PriceUSDT;
        private double _PriceBNB;
        private double _PriceDOT;
        private double _PriceADA;
        private double _PriceXRP;
        private double _PriceLTC;
        private double _PriceLINK;
        private double _PriceBCH;
        private double _PriceXLM;
        private double _PriceUSDC;
        private double _PriceUNI;
        private double _PriceDOGE;
        private double _PriceWBTC;
        private double _PriceXEM;
        private double _PriceEOS;
        private double _PriceHT;
        private double _PriceATOM;
        private double _PriceXMR;
        private double _PriceTRX;
        private double _PriceIOTA;
        private double _PriceNEO;
        private double _PriceVET;
        private List<double> Variable = new List<double>();
        public double AllPrices
        {
            get { return _AllPrices;}
            set
            {
                _AllPrices = 0;
                var URL = new UriBuilder("https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest");
                var queryString = HttpUtility.ParseQueryString(string.Empty);
                queryString["start"] = "1";
                queryString["limit"] = "100";
                queryString["convert"] = "USD";

                
                URL.Query = queryString.ToString();

                var client = new WebClient();
                client.Headers.Add("X-CMC_PRO_API_KEY", API_KEY);
                client.Headers.Add("Accepts", "application/json");
                var answer = client.DownloadString(URL.ToString());
                API_ANSWER = answer;
                
                





                OnPropertyChanged();
            }
        }
        public double PriceBTC
        {
            get { return _PriceBTC; }
            set
            {
                _PriceBTC = 0;
                JObject parse = JObject.Parse(API_ANSWER);
                for (int i = 0; i < 100; i++)
                {
                    if ((string)parse["data"][i]["symbol"] == "BTC")
                    {
                        _PriceBTC = (double)parse["data"][i]["quote"]["USD"]["price"];
                    }
                }
                _PriceBTC = Math.Round(_PriceBTC, 2);
                using (UserContext db = new UserContext())
                {
                    Tokens token = db.Tokens.Where(x => x.TokenName == "BTC").Select(x => x).FirstOrDefault();
                    token.Price = (float)_PriceBTC;
                    db.SaveChanges();
                }
                OnPropertyChanged();
            }
        }
        public double PriceETH
        {
            get { return _PriceETH; }
            set
            {
                _PriceETH = 0;
                JObject parse = JObject.Parse(API_ANSWER);
                for (int i = 0; i < 100; i++)
                {
                    if ((string)parse["data"][i]["symbol"] == "ETH")
                    {
                        _PriceETH = (double)parse["data"][i]["quote"]["USD"]["price"];
                    }
                }
                _PriceETH =  Math.Round(_PriceETH, 2);
                using (UserContext db = new UserContext())
                {
                    Tokens token = db.Tokens.Where(x => x.TokenName == "ETH").Select(x => x).FirstOrDefault();
                    token.Price = (float)_PriceETH;
                    db.SaveChanges();
                }
                OnPropertyChanged();
            }
        }
        public double PriceUSDT
        {
            get { return _PriceUSDT; }
            set
            {
                _PriceUSDT = 0;
                JObject parse = JObject.Parse(API_ANSWER);
                for (int i = 0; i < 100; i++)
                {
                    if ((string)parse["data"][i]["symbol"] == "USDT")
                    {
                        _PriceUSDT = (double)parse["data"][i]["quote"]["USD"]["price"];
                    }
                }
                _PriceUSDT = Math.Round(_PriceUSDT, 2);
                using (UserContext db = new UserContext())
                {
                    Tokens token = db.Tokens.Where(x => x.TokenName == "USDT").Select(x => x).FirstOrDefault();
                    token.Price = (float)_PriceUSDT;
                    db.SaveChanges();
                }
                OnPropertyChanged();
            }
        }
        public double PriceBNB
        {
            get { return _PriceBNB; }
            set
            {
                _PriceBNB = 0;
                JObject parse = JObject.Parse(API_ANSWER);
                for (int i = 0; i < 100; i++)
                {
                    if ((string)parse["data"][i]["symbol"] == "BNB")
                    {
                        _PriceBNB = (double)parse["data"][i]["quote"]["USD"]["price"];
                    }
                }
                _PriceBNB = Math.Round(_PriceBNB, 2);
                using (UserContext db = new UserContext())
                {
                    Tokens token = db.Tokens.Where(x => x.TokenName == "BNB").Select(x => x).FirstOrDefault();
                    token.Price = (float)_PriceBNB;
                    db.SaveChanges();
                }
                OnPropertyChanged();
            }
        }
        public double PriceDOT
        {
            get { return _PriceDOT; }
            set
            {
                _PriceDOT = 0;
                JObject parse = JObject.Parse(API_ANSWER);
                for (int i = 0; i < 100; i++)
                {
                    if ((string)parse["data"][i]["symbol"] == "DOT")
                    {
                        _PriceDOT = (double)parse["data"][i]["quote"]["USD"]["price"];
                    }
                }
                _PriceDOT = Math.Round(_PriceDOT, 2);
                using (UserContext db = new UserContext())
                {
                    Tokens token = db.Tokens.Where(x => x.TokenName == "DOT").Select(x => x).FirstOrDefault();
                    token.Price = (float)_PriceDOT;
                    db.SaveChanges();
                }
                OnPropertyChanged();
            }
        }
        public double PriceADA
        {
            get { return _PriceADA; }
            set
            {
                _PriceADA = 0;
                JObject parse = JObject.Parse(API_ANSWER);
                for (int i = 0; i < 100; i++)
                {
                    if ((string)parse["data"][i]["symbol"] == "ADA")
                    {
                        _PriceADA = (double)parse["data"][i]["quote"]["USD"]["price"];
                    }
                }
                _PriceADA = Math.Round(_PriceADA, 4);
                using (UserContext db = new UserContext())
                {
                    Tokens token = db.Tokens.Where(x => x.TokenName == "ADA").Select(x => x).FirstOrDefault();
                    token.Price = (float)_PriceADA;
                    db.SaveChanges();
                }
                OnPropertyChanged();
            }
        }
        public double PriceXRP
        {
            get { return _PriceXRP; }
            set
            {
                _PriceXRP = 0;
                JObject parse = JObject.Parse(API_ANSWER);
                for (int i = 0; i < 100; i++)
                {
                    if ((string)parse["data"][i]["symbol"] == "XRP")
                    {
                        _PriceXRP = (double)parse["data"][i]["quote"]["USD"]["price"];
                    }
                }
                _PriceXRP = Math.Round(_PriceXRP, 4);
                using (UserContext db = new UserContext())
                {
                    Tokens token = db.Tokens.Where(x => x.TokenName == "XRP").Select(x => x).FirstOrDefault();
                    token.Price = (float)_PriceXRP;
                    db.SaveChanges();
                }
                OnPropertyChanged();
            }
        }
        public double PriceLTC
        {
            get { return _PriceLTC; }
            set
            {
                _PriceLTC = 0;
                JObject parse = JObject.Parse(API_ANSWER);
                for (int i = 0; i < 100; i++)
                {
                    if ((string)parse["data"][i]["symbol"] == "LTC")
                    {
                        _PriceLTC = (double)parse["data"][i]["quote"]["USD"]["price"];
                    }
                }
                _PriceLTC = Math.Round(_PriceLTC, 2);
                using (UserContext db = new UserContext())
                {
                    Tokens token = db.Tokens.Where(x => x.TokenName == "LTC").Select(x => x).FirstOrDefault();
                    token.Price = (float)_PriceLTC;
                    db.SaveChanges();
                }
                OnPropertyChanged();
            }
        }
        public double PriceLINK
        {
            get { return _PriceLINK; }
            set
            {
                _PriceLINK = 0;
                JObject parse = JObject.Parse(API_ANSWER);
                for (int i = 0; i < 100; i++)
                {
                    if ((string)parse["data"][i]["symbol"] == "LINK")
                    {
                        _PriceLINK = (double)parse["data"][i]["quote"]["USD"]["price"];
                    }
                }
                _PriceLINK = Math.Round(_PriceLINK, 2);
                using (UserContext db = new UserContext())
                {
                    Tokens token = db.Tokens.Where(x => x.TokenName == "LINK").Select(x => x).FirstOrDefault();
                    token.Price = (float)_PriceLINK;
                    db.SaveChanges();
                }
                OnPropertyChanged();
            }
        }
        public double PriceBCH
        {
            get { return _PriceBCH; }
            set
            {
                _PriceBCH = 0;
                JObject parse = JObject.Parse(API_ANSWER);
                for (int i = 0; i < 100; i++)
                {
                    if ((string)parse["data"][i]["symbol"] == "BCH")
                    {
                        _PriceBCH = (double)parse["data"][i]["quote"]["USD"]["price"];
                    }
                }
                _PriceBCH = Math.Round(_PriceBCH, 2);
                using (UserContext db = new UserContext())
                {
                    Tokens token = db.Tokens.Where(x => x.TokenName == "BCH").Select(x => x).FirstOrDefault();
                    token.Price = (float)_PriceBCH;
                    db.SaveChanges();
                }
                OnPropertyChanged();
            }
        }
        public double PriceXLM
        {
            get { return _PriceXLM; }
            set
            {
                _PriceXLM = 0;
                JObject parse = JObject.Parse(API_ANSWER);
                for (int i = 0; i < 100; i++)
                {
                    if ((string)parse["data"][i]["symbol"] == "XLM")
                    {
                        _PriceXLM = (double)parse["data"][i]["quote"]["USD"]["price"];
                    }
                }
                _PriceXLM = Math.Round(_PriceXLM, 4);
                using (UserContext db = new UserContext())
                {
                    Tokens token = db.Tokens.Where(x => x.TokenName == "XLM").Select(x => x).FirstOrDefault();
                    token.Price = (float)_PriceXLM;
                    db.SaveChanges();
                }
                OnPropertyChanged();
            }
        }
        public double PriceUSDC
        {
            get { return _PriceUSDC; }
            set
            {
                _PriceUSDC = 0;
                JObject parse = JObject.Parse(API_ANSWER);
                for (int i = 0; i < 100; i++)
                {
                    if ((string)parse["data"][i]["symbol"] == "USDC")
                    {
                        _PriceUSDC = (double)parse["data"][i]["quote"]["USD"]["price"];
                    }
                }
                _PriceUSDC = Math.Round(_PriceUSDC, 2);
                using (UserContext db = new UserContext())
                {
                    Tokens token = db.Tokens.Where(x => x.TokenName == "USDC").Select(x => x).FirstOrDefault();
                    token.Price = (float)_PriceUSDC;
                    db.SaveChanges();
                }
                OnPropertyChanged();
            }
        }
        public double PriceUNI
        {
            get { return _PriceUNI; }
            set
            {
                _PriceUNI = 0;
                JObject parse = JObject.Parse(API_ANSWER);
                for (int i = 0; i < 100; i++)
                {
                    if ((string)parse["data"][i]["symbol"] == "UNI")
                    {
                        _PriceUNI = (double)parse["data"][i]["quote"]["USD"]["price"];
                    }
                }
                _PriceUNI = Math.Round(_PriceUNI, 2);
                using (UserContext db = new UserContext())
                {
                    Tokens token = db.Tokens.Where(x => x.TokenName == "UNI").Select(x => x).FirstOrDefault();
                    token.Price = (float)_PriceUNI;
                    db.SaveChanges();
                }
                OnPropertyChanged();
            }
        }
        public double PriceDOGE
        {
            get { return _PriceDOGE; }
            set
            {
                _PriceDOGE = 0;
                JObject parse = JObject.Parse(API_ANSWER);
                for (int i = 0; i < 100; i++)
                {
                    if ((string)parse["data"][i]["symbol"] == "DOGE")
                    {
                        _PriceDOGE = (double)parse["data"][i]["quote"]["USD"]["price"];
                    }
                }
                _PriceDOGE = Math.Round(_PriceDOGE, 5);
                using (UserContext db = new UserContext())
                {
                    Tokens token = db.Tokens.Where(x => x.TokenName == "DOGE").Select(x => x).FirstOrDefault();
                    token.Price = (float)_PriceDOGE;
                    db.SaveChanges();
                }
                OnPropertyChanged();
            }
        }
        public double PriceWBTC
        {
            get { return _PriceWBTC; }
            set
            {
                _PriceWBTC = 0;
                JObject parse = JObject.Parse(API_ANSWER);
                for (int i = 0; i < 100; i++)
                {
                    if ((string)parse["data"][i]["symbol"] == "WBTC")
                    {
                        _PriceWBTC = (double)parse["data"][i]["quote"]["USD"]["price"];
                    }
                }
                _PriceWBTC = Math.Round(_PriceWBTC, 2);
                using (UserContext db = new UserContext())
                {
                    Tokens token = db.Tokens.Where(x => x.TokenName == "WBTC").Select(x => x).FirstOrDefault();
                    token.Price = (float)_PriceWBTC;
                    db.SaveChanges();
                }
                OnPropertyChanged();
            }
        }
        public double PriceXEM
        {
            get { return _PriceXEM; }
            set
            {
                _PriceXEM = 0;
                JObject parse = JObject.Parse(API_ANSWER);
                for (int i = 0; i < 100; i++)
                {
                    if ((string)parse["data"][i]["symbol"] == "XEM")
                    {
                        _PriceXEM = (double)parse["data"][i]["quote"]["USD"]["price"];
                    }
                }
                _PriceXEM = Math.Round(_PriceXEM, 4);
                using (UserContext db = new UserContext())
                {
                    Tokens token = db.Tokens.Where(x => x.TokenName == "XEM").Select(x => x).FirstOrDefault();
                    token.Price = (float)_PriceXEM;
                    db.SaveChanges();
                }
                OnPropertyChanged();
            }
        }
        public double PriceEOS
        {
            get { return _PriceEOS; }
            set
            {
                _PriceEOS = 0;
                JObject parse = JObject.Parse(API_ANSWER);
                for (int i = 0; i < 100; i++)
                {
                    if ((string)parse["data"][i]["symbol"] == "EOS")
                    {
                        _PriceEOS = (double)parse["data"][i]["quote"]["USD"]["price"];
                    }
                }
                _PriceEOS = Math.Round(_PriceEOS, 2);
                using (UserContext db = new UserContext())
                {
                    Tokens token = db.Tokens.Where(x => x.TokenName == "EOS").Select(x => x).FirstOrDefault();
                    token.Price = (float)_PriceEOS;
                    db.SaveChanges();
                }
                OnPropertyChanged();
            }
        }
        public double PriceHT
        {
            get { return _PriceHT; }
            set
            {
                _PriceHT = 0;
                JObject parse = JObject.Parse(API_ANSWER);
                for (int i = 0; i < 100; i++)
                {
                    if ((string)parse["data"][i]["symbol"] == "HT")
                    {
                        _PriceHT = (double)parse["data"][i]["quote"]["USD"]["price"];
                    }
                }
                _PriceHT = Math.Round(_PriceHT, 2);
                using (UserContext db = new UserContext())
                {
                    Tokens token = db.Tokens.Where(x => x.TokenName == "HT").Select(x => x).FirstOrDefault();
                    token.Price = (float)_PriceHT;
                    db.SaveChanges();
                }
                OnPropertyChanged();
            }
        }
        public double PriceATOM
        {
            get { return _PriceATOM; }
            set
            {
                _PriceATOM = 0;
                JObject parse = JObject.Parse(API_ANSWER);
                for (int i = 0; i < 100; i++)
                {
                    if ((string)parse["data"][i]["symbol"] == "ATOM")
                    {
                        _PriceATOM = (double)parse["data"][i]["quote"]["USD"]["price"];
                    }
                }
                _PriceATOM = Math.Round(_PriceATOM, 2);
                using (UserContext db = new UserContext())
                {
                    Tokens token = db.Tokens.Where(x => x.TokenName == "ATOM").Select(x => x).FirstOrDefault();
                    token.Price = (float)_PriceATOM;
                    db.SaveChanges();
                }
                OnPropertyChanged();
            }
        }
        public double PriceXMR
        {
            get { return _PriceXMR; }
            set
            {
                _PriceXMR = 0;
                JObject parse = JObject.Parse(API_ANSWER);
                for (int i = 0; i < 100; i++)
                {
                    if ((string)parse["data"][i]["symbol"] == "XMR")
                    {
                        _PriceXMR = (double)parse["data"][i]["quote"]["USD"]["price"];
                    }
                }
                _PriceXMR = Math.Round(_PriceXMR, 2);
                using (UserContext db = new UserContext())
                {
                    Tokens token = db.Tokens.Where(x => x.TokenName == "XMR").Select(x => x).FirstOrDefault();
                    token.Price = (float)_PriceXMR;
                    db.SaveChanges();
                }
                OnPropertyChanged();
            }
        }
        public double PriceTRX
        {
            get { return _PriceTRX; }
            set
            {
                _PriceTRX = 0;
                JObject parse = JObject.Parse(API_ANSWER);
                for (int i = 0; i < 100; i++)
                {
                    if ((string)parse["data"][i]["symbol"] == "TRX")
                    {
                        _PriceTRX = (double)parse["data"][i]["quote"]["USD"]["price"];
                    }
                }
                _PriceTRX = Math.Round(_PriceTRX, 5);
                using (UserContext db = new UserContext())
                {
                    Tokens token = db.Tokens.Where(x => x.TokenName == "TRX").Select(x => x).FirstOrDefault();
                    token.Price = (float)_PriceTRX;
                    db.SaveChanges();
                }
                OnPropertyChanged();
            }
        }
        public double PriceIOTA
        {
            get { return _PriceIOTA; }
            set
            {
                _PriceIOTA = 0;
                JObject parse = JObject.Parse(API_ANSWER);
                for (int i = 0; i < 100; i++)
                {
                    if ((string)parse["data"][i]["symbol"] == "MIOTA")
                    {
                        _PriceIOTA = (double)parse["data"][i]["quote"]["USD"]["price"];
                    }
                }
                _PriceIOTA = Math.Round(_PriceIOTA, 2);
                using (UserContext db = new UserContext())
                {
                    Tokens token = db.Tokens.Where(x => x.TokenName == "IOTA").Select(x => x).FirstOrDefault();
                    token.Price = (float)_PriceIOTA;
                    db.SaveChanges();
                }
                OnPropertyChanged();
            }
        }
        public double PriceNEO
        {
            get { return _PriceNEO; }
            set
            {
                _PriceNEO = 0;
                JObject parse = JObject.Parse(API_ANSWER);
                for (int i = 0; i < 100; i++)
                {
                    if ((string)parse["data"][i]["symbol"] == "NEO")
                    {
                        _PriceNEO = (double)parse["data"][i]["quote"]["USD"]["price"];
                    }
                }
                _PriceNEO = Math.Round(_PriceNEO, 2);
                using (UserContext db = new UserContext())
                {
                    Tokens token = db.Tokens.Where(x => x.TokenName == "NEO").Select(x => x).FirstOrDefault();
                    token.Price = (float)_PriceNEO;
                    db.SaveChanges();
                }
                OnPropertyChanged();
            }
        }
        public double PriceVET
        {
            get { return _PriceVET; }
            set
            {
                _PriceVET = 0;
                JObject parse = JObject.Parse(API_ANSWER);
                for (int i = 0; i < 100; i++)
                {
                    if ((string)parse["data"][i]["symbol"] == "VET")
                    {
                        _PriceVET = (double)parse["data"][i]["quote"]["USD"]["price"];
                    }
                }
                _PriceVET = Math.Round(_PriceVET, 5);
                using (UserContext db = new UserContext())
                {
                    Tokens token = db.Tokens.Where(x => x.TokenName == "VET").Select(x => x).FirstOrDefault();
                    token.Price = (float)_PriceVET;
                    db.SaveChanges();
                }
                OnPropertyChanged();
            }
        }


        public MarketsVM()
        {
            Task.Factory.StartNew(() =>
            {
                AllPrices++;
                PriceBTC++;
                PriceETH++;
                PriceUSDT++;
                PriceBNB++;
                PriceDOT++;
                PriceADA++;
                PriceXRP++;
                PriceLTC++;
                PriceLINK++;
                PriceBCH++;
                PriceXLM++;
                PriceUSDC++;
                PriceUNI++;
                PriceDOGE++;
                PriceWBTC++;
                PriceXEM++;
                PriceEOS++;
                PriceHT++;
                PriceATOM++;
                PriceXMR++;
                PriceTRX++;
                PriceIOTA++;
                PriceNEO++;
                PriceVET++;
                while (true)
                {
                    Task.Delay(60000).Wait();
                    AllPrices++;
                    PriceBTC++;
                    PriceETH++;
                    PriceUSDT++;
                    PriceBNB++;
                    PriceDOT++;
                    PriceADA++;
                    PriceXRP++;
                    PriceLTC++;
                    PriceLINK++;
                    PriceBCH++;
                    PriceXLM++;
                    PriceUSDC++;
                    PriceUNI++;
                    PriceDOGE++;
                    PriceWBTC++;
                    PriceXEM++;
                    PriceEOS++;
                    PriceHT++;
                    PriceATOM++;
                    PriceXMR++;
                    PriceTRX++;
                    PriceIOTA++;
                    PriceNEO++;
                    PriceVET++;
                }
            });
        }

    }
}
