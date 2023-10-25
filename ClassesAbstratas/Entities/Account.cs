using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesAbstratas.Entities
{
    public abstract class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; } = null!;
        public double Balance { get; set; }

        public Account()
        {            
        }

        public Account(int number, string holder, double balance)
        {   
            Number = number;
            Holder = holder;
            Balance = balance;         
        }

        public virtual void Withdraw(double amount) {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount) {
            Balance += amount;
        }
    }
}