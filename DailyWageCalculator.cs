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
            int employeeWage = 0;
            int whichEmployee = random.Next(0, 3);
            switch (whichEmployee)
            {
                case 0:
                    employeeWage = 0;
                    break;
                case 1:
                    employeeWage = 1;
                    employeeWage = FULL_TIME_EMPLOYEE_WORK_HOURS * DAILY_WAGE_PER_HOUR;
                    break;
                case 2:
                    employeeWage = PART_TIME_EMPLOYEE_WORK_HOURS * DAILY_WAGE_PER_HOUR;
                    break;
            }
            Console.WriteLine($"Wage is {employeeWage}");
        }
    }
}
