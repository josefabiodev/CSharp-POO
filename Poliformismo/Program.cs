using System.Collection.Generic;
using Polimorfismo.Entities;
using System.Globalization;

// Pilares da POO

/*
    Encapsulamento
    Herança
    Polimorfismo
*/

List<Employee> list = new List<Employee>();

Console.WriteLine("Enter the number of employee: ");
int n = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= n; i++) 
{
    Console.WriteLine($"Employee #{i} data: ");
    Console.Write("Outsourced (y/n)? ");
    char ch = char.Parse(Console.ReadLine()!);
    Console.Write("Name: ");
    string name = Console.ReadLine()!;
    Console.Write("Hours: ");
    int hours = int.Parse(Console.ReadLine()!);
    Console.Write("Value per hours: ");
    double valuePerhour = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

    if (ch == 'y') 
    {
        Console.Write("Additional charge: ");
        double additionalCharge = double.Parse(Console.ReadLine()!);
        list.Add(new OutsourcedEmployee(name, hours, valuePerhour, additionalCharge));
    }
    else
    {
        list.Add(new Employee(name, hours, valuePerhour));
    }

    Console.WriteLine();
    Console.WriteLine("PAYMENTS:")

    foreach (Em´loyee emp in list)
    {
        Console.WriteLine($"{emp.Name} $ {emp.Payment().ToString, CultureInfo.InvariantCulture}");
    }

}