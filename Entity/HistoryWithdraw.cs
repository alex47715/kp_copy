using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP.Entity
{
    public class HistoryWithdraw
    {
        [Key]
        public int IdWithdraw { get; set; }
        [Key]
        [ForeignKey("User")]
        public int Id { get; set; }
        public string Username { get; set; }
        public float WithdrawSum { get; set; }
        public User User { get; set; }
    }
}
