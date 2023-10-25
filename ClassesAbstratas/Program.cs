using System.Collection.Generic;
// Classes abstratas -> são classes que não podem ser instanciadas

List<Account> list = new List<Account>();

list.Add(new SavingAccount(1001, "Alex", 500.0, 0.01));
list.Add(new BusinessAccount(1002, "Alguém", 500.0, 400.0));
list.Add(new SavingAccount(1003, "Bob", 500.0, 0.01));
list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

double soma = 0.0;

foreach(Account acc in list)
{
    sum += acc.Balance;
}

Console.WriteLine("Tortal balance"+sum.ToString("F2"));

foreach(Account acc in list)
{
    acc.Withdraw(10.0);
}

foreach (Account acc in list)
{
    Console.WriteLine($"Updated balance for account {acc.Number} : {acc.Balance.ToString("F2")}");
}