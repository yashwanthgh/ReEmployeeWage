using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageRemastered
{
    public class Attendance
    {

        Random random = new Random();   
        public void PresentAbsent()
        {
            int attendane = random.Next(0, 2);
            if(attendane == 0)
            {
                Console.WriteLine("Employee Absent");
            } else
            {
                Console.WriteLine("Employee Present");
            }
        }
    }
}
