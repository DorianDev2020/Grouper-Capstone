﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication.Models
{
    public class Wallet
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int WalletId { get; set; }
        public int Balance { get; set; }

        [ForeignKey("Payment")]
        public int PaymentId { get; set; }
        public Payment payment { get; set; }

        [ForeignKey("Memory")]
        public int MemoryId { get; set; }
        public Memory memory { get; set; }

        [ForeignKey("Transactions")]
        public int TransactionsId { get; set; }
        public Transactions transactions { get; set; }
    }
}

