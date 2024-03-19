using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageRemastered
{
    public class DailyWageCalculator
    {
        const int DAILY_WAGE_PER_HOUR = 20;
        const int PART_TIME_EMPLOYEE_WORK_HOURS = 4;
        const int FULL_TIME_EMPLOYEE_WORK_HOURS = 8;
        readonly Random random = new();
        public void WageCalculator()
        {
            int employeeWage;
            int whichEmployee = random.Next(0, 2);
            if(whichEmployee == 0)
            {
                employeeWage = DAILY_WAGE_PER_HOUR * FULL_TIME_EMPLOYEE_WORK_HOURS;
            } else
            {
                employeeWage = DAILY_WAGE_PER_HOUR * PART_TIME_EMPLOYEE_WORK_HOURS;
                Console.WriteLine($"Wage is {employeeWage}");
            }
            Console.WriteLine($"Wage is {employeeWage}");
        }
    }
}
