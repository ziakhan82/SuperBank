﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
   public class Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get;  }
        public string Notes { get; }

     //   public int ActualAmount { get; }

        
       

        public Transaction(decimal amount,DateTime date,string notes/*int actualAmount*/)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = notes;
          //  this.ActualAmount = actualAmount;


        }
    }   
}
