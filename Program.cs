using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace EmployeeWageRemastered
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage Calculator!");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Daily Wage");
            Console.WriteLine("2. Monthly Wage");
            Console.WriteLine("3. Total Wage in a Month");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    DailyWageCalculator dailyWageCalculator = new DailyWageCalculator();
                    dailyWageCalculator.WageCalculator();
                    break;
                case 2:
                    MonthlyWageCalculator monthlyWageCalculator = new MonthlyWageCalculator();
                    monthlyWageCalculator.WageCalculator();
                    break;
                case 3:
                    TotalWageInMonth totalWageInMonth = new TotalWageInMonth();
                    totalWageInMonth.CalculateTotalWage();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
