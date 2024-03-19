using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageRemastered
{
    public class TotalWageInMonth
    {
        const int TOTAL_NUMBER_OF_HOURS = 80;
        const int TOTAL_NUMBER_OF_DAYS = 20;
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        const int DAILY_WAGE_PER_HOUR = 20;
        readonly Random random = new ();
        public void CalculateTotalWage()
        {
            int hours = 0, totalHours = 0, totalDays = 0;    
            while(totalHours <= TOTAL_NUMBER_OF_HOURS && totalDays <= TOTAL_NUMBER_OF_DAYS)
            {
                totalDays++;
                int whichEmployee = random.Next(1, 3);
                switch (whichEmployee)
                {
                    case IS_FULL_TIME:
                        hours = 8;
                        break;
                    case IS_PART_TIME:
                        hours = 4; 
                        break;
                }
                totalHours += hours;
            }
            int totalEmployeeWage = totalHours * DAILY_WAGE_PER_HOUR;
            Console.WriteLine($"Employees total pay is {totalEmployeeWage}");
        }
    }
}
