using System;
using System.Collections.Generic;
using Aula132.Entities;
using System.Globalization;

namespace Aula132
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> list = new List<Employee>();

            Console.Write("Enter the nummber of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("OutSource (y/n)? ");

                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name : ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    Console.Write("Addtional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");

            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString("F2,", CultureInfo.InvariantCulture));
            }

            Console.ReadKey();
        }
    }
}
 