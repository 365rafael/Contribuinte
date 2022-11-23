using Contribuinte.Entities;
using System.Globalization;

List<TaxPayer> list = new List<TaxPayer>();

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Tax payer #{i} data:");
    Console.Write("Individual or company (i/c)? ");
    char option = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Anual income: ");
    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if (option == 'i')
    {
        Console.Write("Health expenditures: ");
        double healtExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new Individual(healtExpenditures, name, anualIncome));
    }
    else
    {
        Console.Write("Number of employees: ");
        int numberOfEmployees = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new Company(numberOfEmployees, name, anualIncome));
    }
}

Console.WriteLine();
Console.WriteLine("TAXES PAID:");
foreach (TaxPayer taxPayer in list)
{
    Console.WriteLine(taxPayer.Name + ": $" + taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture));
}

double sum = 0.0;
Console.WriteLine();
foreach (TaxPayer tp in list)
{
    double tx = tp.Tax();
    sum += tx;
}

Console.WriteLine();
Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));