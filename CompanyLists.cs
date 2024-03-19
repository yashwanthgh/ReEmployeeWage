using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageRemastered
{ 
    internal class CompanyLists
    {
        static MultipleCompany[] companyLists = new MultipleCompany[5];
        static int index = 0;   

        public void AddCompanies(MultipleCompany company)
        {
            companyLists[index++] = company;
        }
    }
}
