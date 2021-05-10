using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP.Entity
{
    public class User:IPrototype
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public float BTCBalance { get; set; }
        public float ETHBalance { get; set; }
        public float BNBBalance { get; set; }
        public float USDTBalance { get; set; }
        public float DOTBalance { get; set; }
        public float ADABalance { get; set; }
        public float XRPBalance { get; set; }
        public float LINKBalance { get; set; }
        public float BCHBalance { get; set; }
        public float XLMBalance { get; set; }
        public float UNIBalance { get; set; }
        public float USDCBalance { get; set; }
        public float DOGEBalance { get; set; }
        public float WBTCBalance { get; set; }
        public float XEMBalance { get; set; }
        public float EOSBalance { get; set; }
        public float HTBalance { get; set; }
        public float ATOMBalance { get; set; }
        public float XMRBalance { get; set; }
        public float TRXBalance { get; set; }
        public float IOTABalance { get; set; }
        public float NEOBalance { get; set; }
        public float VETBalance { get; set; }
        public float TOTAL { get; set; }

        public virtual ICollection<HistoryDeposits> HistoryDeposits { get; set; }
        public virtual ICollection<HistoryWithdraw> HistoryWithdraw { get; set; }
        public bool Status()
        {
            return true;
        }
        public IPrototype Clone(string username, string email, string password)
        {
            return new User
            {
                Username = username,
                Password = password,
                Email = email,
                BTCBalance = BTCBalance,
                ETHBalance = ETHBalance,
                BNBBalance = BNBBalance,
                USDTBalance = USDTBalance,
                DOTBalance = DOTBalance,
                ADABalance = ADABalance,
                XRPBalance = XRPBalance,
                LINKBalance = LINKBalance,
                BCHBalance = BCHBalance,
                XLMBalance = XLMBalance,
                UNIBalance = UNIBalance,
                USDCBalance = USDCBalance,
                DOGEBalance = DOGEBalance,
                WBTCBalance = WBTCBalance,
                XEMBalance = XEMBalance,
                EOSBalance = EOSBalance,
                HTBalance = HTBalance,
                ATOMBalance = ATOMBalance,
                XMRBalance = XMRBalance,
                TRXBalance = TRXBalance,
                IOTABalance = IOTABalance,
                NEOBalance = NEOBalance,
                VETBalance = VETBalance,
                TOTAL=TOTAL
            };
        }
    }
}
