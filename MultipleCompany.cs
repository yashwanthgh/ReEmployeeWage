using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageRemastered
{
    public class MultipleCompany
    {
        private string CompanyName;
        private int HourlyPay;
        private int TotalWorkingDays;
        private int TotalWorkingHours;

        public int ComputeEmployeeWage(string companyName, int totalWorkingdays, int totalWorkingHours, int hourlyPay)
        {
            this.CompanyName = companyName;
            this.TotalWorkingDays = totalWorkingdays;
            this.TotalWorkingHours = totalWorkingHours;
            this.HourlyPay = hourlyPay;

            TotalWageInMonth totalWageInMonth = new TotalWageInMonth(companyName, totalWorkingdays,totalWorkingHours,hourlyPay);
            return totalWageInMonth.CalculateTotalWage();
        }
    }
}
