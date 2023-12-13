using System;
using System.Collections.Generic;
using Principal.Entities;
using System.Globalization;

namespace Principal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
             int ntp = int.Parse(Console.ReadLine());

            List<TaxPayer> taxList = new List<TaxPayer>();
             for (int i = 1; i <= ntp; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                
                Console.Write("Individual or company (i/c)? ");
                 char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                 string name = Console.ReadLine();

                Console.Write("Anual income: ");
                 double ain = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                     double healthExp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxList.Add(new Individual(name, ain, healthExp));
                }
                else
                {
                    Console.Write("Number of employees: ");
                     int ne = int.Parse(Console.ReadLine());
                    taxList.Add(new Company(name, ain, ne));
                }
             }
            double sum = 0.0;

            Console.WriteLine();
            Console.WriteLine("TAXES PAIDS:");
             foreach (TaxPayer tp in taxList)
             {
                double tax = tp.Tax();
                Console.WriteLine(tp.Name + ": $" + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
             }
            Console.WriteLine();
            Console.WriteLine("Total Taxs: $" + sum.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
