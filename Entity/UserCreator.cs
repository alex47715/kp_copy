using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KP.Entity
{
    public static class UserCreator
    {
        public static bool Status=false;
        public static bool CreateUser(string username,string email,string password)
        {
            try
            {
                using (UserContext db = new UserContext())
                {
                    //создаем прототип
                    IPrototype figure = new User
                    {
                        BTCBalance = 0,
                        ETHBalance = 0,
                        BNBBalance = 0,
                        USDTBalance = 0,
                        DOTBalance = 0,
                        ADABalance = 0,
                        XRPBalance = 0,
                        LINKBalance = 0,
                        BCHBalance = 0,
                        XLMBalance = 0,
                        UNIBalance = 0,
                        USDCBalance = 0,
                        DOGEBalance = 0,
                        WBTCBalance = 0,
                        XEMBalance = 0,
                        EOSBalance = 0,
                        HTBalance = 0,
                        ATOMBalance = 0,
                        XMRBalance = 0,
                        TRXBalance = 0,
                        IOTABalance = 0,
                        NEOBalance = 0,
                        VETBalance = 0
                    };
                    string md5 = GetHash(password);
                    IPrototype clonedFigure = figure.Clone(username, email, md5);
                    // добавляем пользователя в бд
                    db.Users.Add((User)clonedFigure);
                    db.SaveChanges();
                    Status = true;
                    return clonedFigure.Status();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }
        public static bool Auth(string username,string password)
        {
            try
            {
                using (UserContext db = new UserContext())
                {
                    try
                    {
                        var IdUser = db.Users.Where(x => x.Username == username).Select(x => x.Id).First();
                        User user = db.Users.Find(IdUser);
                        if (user.Password == GetHash(password))
                        {
                            Status = true;
                            return true;
                        }
                        else
                            return false;
                        

                    }
                    catch(Exception e)
                    {
                        return false;
                    }
                    

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public static string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }
        public static bool AuthStatus()
        {
            return Status;
        }
        public static User FindUserByName(string name)
        {
            try
            {
                using (UserContext db = new UserContext())
                {
                    var IdUser = db.Users.Where(x => x.Username == name).Select(x => x.Id).First();
                    return db.Users.Find(IdUser);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return new User();
            }
            
        }
        public static User FindUserByMail(string mail)
        {
            try
            {
                using (UserContext db = new UserContext())
                {
                    var IdUser = db.Users.Where(x => x.Email == mail).Select(x => x.Id).First();
                    return db.Users.Find(IdUser);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            return new User();
        }
        public static void InfoAboutUser(string name)
        {
            try
            {
                using (UserContext db = new UserContext())
                {
                    var IdUser = db.Users.Where(x => x.Username == name).Select(x => x.Id).First();
                    User user = db.Users.Find(IdUser);
                    Console.WriteLine($"{user.Id}\nUsername:{user.Username}\nEmail:{user.Email}\n" +
                        $"Password:{user.Password}\nBTCBalance:{user.BTCBalance}\nETHBalance:{user.ETHBalance}\n" +
                        $"BNBBalance:{user.BNBBalance}\nUSDTBalance:{user.USDTBalance}\n" +
                        $"DOTBalance:{user.DOTBalance}\nADABalance:{user.ADABalance}\n" +
                        $"XRPBalance:{user.XRPBalance}\nLINKBalance:{user.LINKBalance}\n" +
                        $"BCHBalance:{user.BCHBalance}\nXLMBalance:{user.XLMBalance}\n" +
                        $"UNIBalance:{user.UNIBalance}\nUSDCBalance:{user.USDCBalance}\n" +
                        $"DOGEBalance:{user.DOGEBalance}\nWBTCBalance:{user.WBTCBalance}\n" +
                        $"XEMBalance:{user.XEMBalance}\nEOSBalance:{user.EOSBalance}\n" +
                        $"HTBalance:{user.HTBalance}\nATOMBalance:{user.ATOMBalance}\n" +
                        $"XMRBalance:{user.XMRBalance}\nTRXBalance:{user.TRXBalance}\n" +
                        $"IOTABalance:{user.IOTABalance}\nNEOBalance:{user.NEOBalance}\n" +
                        $"VETBalance:{user.VETBalance}\nTotal:{user.TOTAL}$");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        public static void ChangeUsername(string name)
        {
            try
            {
                using (UserContext db = new UserContext())
                {
                    User user = FindUserByName(name);
                    user.Username = name;
                    db.SaveChanges();
                    Console.WriteLine("Username был изменен.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        public static void ChangeMail(string mail)
        {

            try
            {
                using (UserContext db = new UserContext())
                {
                    User user = FindUserByMail(mail);
                    user.Email = mail;
                    db.SaveChanges();
                    Console.WriteLine("Email был изменен.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
                
            
        }
        public static void ChangePassword(string name,string pass)
        {
            try
            {
                using (UserContext db = new UserContext())
                {
                    User user = FindUserByName(name);
                    user.Password = pass;
                    db.SaveChanges();
                    Console.WriteLine("Password был изменен.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void DeleteUser(string name)
        {
            try
            {
                using (UserContext db = new UserContext())
                {
                    User user = FindUserByName(name);
                    db.Users.Remove(user);
                    db.SaveChanges();
                    Console.WriteLine($"{user.Username} был заблокирован!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void Deposit(string name,float addbalance)
        {
            try
            {
                using (UserContext db = new UserContext())
                {
                    User user = db.Users.Where(x => x.Username == name).Select(x => x).FirstOrDefault();
                    user.USDTBalance += addbalance;
                    db.SaveChanges();
                    HistoryDeposits history = new HistoryDeposits { DepositSum = addbalance, Username = name,Id = db.Users.Where(x => x.Username == name).Select(x => x.Id).FirstOrDefault()};
                    db.HistoryDeposits.Add(history);
                    db.SaveChanges();
                    Console.WriteLine($"Баланс был успешно пополнен!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void Withdraw(string name, float addbalance)
        {
            try
            {
                using (UserContext db = new UserContext())
                {
                    User user = db.Users.Where(x => x.Username == name).Select(x => x).FirstOrDefault();
                    user.USDTBalance -= addbalance;
                    db.SaveChanges();
                    HistoryWithdraw history = new HistoryWithdraw { WithdrawSum = addbalance, Username = name, Id = db.Users.Where(x => x.Username == name).Select(x => x.Id).FirstOrDefault() };
                    db.HistoryWithdraw.Add(history);
                    db.SaveChanges();
                    Console.WriteLine($"Вывод произошел успешно!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void Trade(string name, string firstToken, string secondToken, float Sum)
        {
            try
            {
                using (UserContext db = new UserContext())
                {
                    
                    var BalanceFirstToken = db.Database.SqlQuery<float>($"SELECT {firstToken}Balance FROM Users where Username='{name}'").ToArray();
                    var BalanceSecondToken = db.Database.SqlQuery<float>($"SELECT {secondToken}Balance FROM Users where Username='{name}'").ToArray();
                    float PriceFirstToken = db.Tokens.Where(x => x.TokenName == firstToken).Select(x => x.Price).FirstOrDefault();
                    float PriceSecondToken = db.Tokens.Where(x => x.TokenName == secondToken).Select(x => x.Price).FirstOrDefault();
                    float resultsum = 0;
                    if (BalanceFirstToken[0] < Sum)
                    {
                        MessageBox.Show($"Invalid Balance!!!Max sum for trade:{BalanceFirstToken[0]}");
                    }
                    else
                    {
                        resultsum = ((Sum * PriceFirstToken) / PriceSecondToken);
                        float total1 = resultsum + BalanceSecondToken[0];
                        float total2 = BalanceFirstToken[0]-Sum;
                        object p = db.Database.ExecuteSqlCommand($"UPDATE Users SET {secondToken}Balance={total1.ToString().Replace(',','.')} WHERE Username='{name}'");
                        object b = db.Database.ExecuteSqlCommand($"UPDATE Users SET {firstToken}Balance={total2.ToString().Replace(',','.')} WHERE Username='{name}'");

                        MessageBox.Show($"Success!You will get {resultsum} on your wallet.");
                    }

                    db.SaveChanges();
                    //HistoryWithdraw history = new HistoryWithdraw { WithdrawSum = addbalance, Username = name, Id = db.Users.Where(x => x.Username == name).Select(x => x.Id).FirstOrDefault() };
                    //db.HistoryWithdraw.Add(history);
                    //db.SaveChanges();
                    Console.WriteLine($"Вывод произошел успешно!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static string Converter(string name, string firstToken, string secondToken, float Sum)
        {
            
                try
                {
                if (Sum == 0.0)
                {
                    return "Add Sum!";
                }
                    using (UserContext db = new UserContext())
                    {
                       
                        var BalanceFirstToken = db.Database.SqlQuery<float>($"SELECT {firstToken}Balance FROM Users where Username='{name}'").ToArray();
                        var BalanceSecondToken = db.Database.SqlQuery<float>($"SELECT {secondToken}Balance FROM Users where Username='{name}'").ToArray();
                        float PriceFirstToken = db.Tokens.Where(x => x.TokenName == firstToken).Select(x => x.Price).FirstOrDefault();
                        float PriceSecondToken = db.Tokens.Where(x => x.TokenName == secondToken).Select(x => x.Price).FirstOrDefault();
                        float resultsum = 0;
                        if (BalanceFirstToken[0] < Sum)
                        {
                            return "Error!";
                            //MessageBox.Show($"Invalid Balance!!!Max sum for trade:{BalanceFirstToken[0]}");
                        }
                        else
                        {
                            resultsum = ((Sum * PriceFirstToken) / PriceSecondToken);
                            return resultsum.ToString();
                            //float total1 = resultsum + BalanceSecondToken[0];
                            //float total2 = BalanceFirstToken[0] - Sum;
                            //object p = db.Database.ExecuteSqlCommand($"UPDATE Users SET {secondToken}Balance={total1.ToString().Replace(',', '.')} WHERE Username='{name}'");
                            //object b = db.Database.ExecuteSqlCommand($"UPDATE Users SET {firstToken}Balance={total2.ToString().Replace(',', '.')} WHERE Username='{name}'");

                            //MessageBox.Show($"Success!You will get {resultsum} on your wallet.");
                        }

                        //db.SaveChanges();
                        //HistoryWithdraw history = new HistoryWithdraw { WithdrawSum = addbalance, Username = name, Id = db.Users.Where(x => x.Username == name).Select(x => x.Id).FirstOrDefault() };
                        //db.HistoryWithdraw.Add(history);
                        //db.SaveChanges();
                        //Console.WriteLine($"Вывод произошел успешно!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
           
           
        }
        public static async Task<string> ConverterResult(string name, string firstToken, string secondToken, float Sum)
        {
            return await Task.Run(() => Converter(name,firstToken,secondToken,Sum));
        }
        public static string USDPriceToken(string firstToken, float Sum)
        {

            try
            {
                if (Sum == (float)0.0)
                {
                    return "Add Sum!";
                }
                using (UserContext db = new UserContext())
                {
                    float PriceFirstToken = db.Tokens.Where(x => x.TokenName == firstToken).Select(x => x.Price).FirstOrDefault();
                    float resultsum = 0;
                    resultsum = (Sum * PriceFirstToken);
                    return resultsum.ToString();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public static async Task<string> USDAsyncPrice(string firstToken, float Sum)
        {
            return await Task.Run(() => USDPriceToken(firstToken, Sum));
        }

    }
}
