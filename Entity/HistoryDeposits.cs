﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP.Entity
{
    public class HistoryDeposits
    {
        [Key]
        public int IdDeposit { get; set; }
        [Key]
        [ForeignKey("User")]
        public int Id { get; set; }
        public string Username { get; set; }
        public float DepositSum { get; set; }
        public User User { get; set; }
    }
}
