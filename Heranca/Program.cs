// See https://aka.ms/new-console-template for more information

using Heranca.Entities;

Account acc = new(1001, "Fábio", 0.0);
BusinessAccount businessAccount = new(1002, "Manoel", 0.0, 500.0);

// UPCASTING

Account acc1 = businessAccount;
Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
Account acc3 = new SavingsAccount(1004, "Aline", 0.0, 0.01);

//  DONWCASTING

BusinessAccount acc4 = (BusinessAccount)acc2;
acc4.Loan(100);

//BusinessAccount acc5 = (BusinessAccount)acc3;
if (acc3 is BusinessAccount)
{
    //BusinessAccount acc5 = (BusinessAccount)acc3;
    BusinessAccount? acc5 = acc3 as BusinessAccount;
    acc5!.Loan(200.0);
    Console.WriteLine("Loan");
}

if (acc3 is SavingsAccount)
{
    //SavingsAccount acc5 = (SavingsAccount)acc3;
    SavingsAccount? acc5 = acc3 as SavingsAccount;
    acc5!.UpdateBalance();
    Console.WriteLine("Update");
}

Console.ReadKey();
