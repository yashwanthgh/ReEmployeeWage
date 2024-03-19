using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageRemastered
{
    public class MultipleCompany
    {
        public int ComputeEmployeeWage(string companyName, int totalWorkingdays, int totalWorkingHours, int hourlyPay)
        {
            TotalWageInMonth totalWageInMonth = new TotalWageInMonth(companyName, totalWorkingdays,totalWorkingHours,hourlyPay);
            return totalWageInMonth.CalculateTotalWage();
        }
    }
}
