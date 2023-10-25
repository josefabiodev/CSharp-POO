using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesAbstratas.Entities
{
    public class SavingAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingAccount()
        {
            
        }

        public SavingAccount(int number, string holder, double balance, interestRate)
            : base(number, holder, balance)
        {
            InterestRate = InterestRate;
        } 

        public override void Withdraw(double amount) {
            base.Withdraw(amount);
            Balance -= 2.0;
        }


        public void UpdateBalance() 
        {
            Balance + = Balance * InterestRate;
        }       
    }
}