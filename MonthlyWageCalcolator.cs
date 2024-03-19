using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageRemastered
{
    public class MonthlyWageCalcolator
    {
        const int TOTAL_WORKING_DAYS = 20;
        const int TOTAL_DAILY_WAGE_PART_TIME_EMPLOYEE = 80;
        const int TOTAL_DAILY_WAGE_FULL_TIME_EMPLOYEE = 160;
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;

        readonly Random random = new ();
        
        public void WageCalculator()
        {
            int employeeWage = 0;
            int whichEmployee = random.Next(0, 3);
            switch (whichEmployee)
            {
                case 0:
                    employeeWage = 0;
                    break;
                case IS_FULL_TIME:
                    employeeWage = TOTAL_DAILY_WAGE_FULL_TIME_EMPLOYEE * TOTAL_WORKING_DAYS;
                    break;
                case IS_PART_TIME:
                    employeeWage = TOTAL_DAILY_WAGE_PART_TIME_EMPLOYEE * TOTAL_WORKING_DAYS;
                    break;
            }
            Console.WriteLine($"Monthly wage of an Employee is {employeeWage}");
        }
    }
}
