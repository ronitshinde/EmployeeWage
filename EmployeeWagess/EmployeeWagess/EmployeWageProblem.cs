using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagess
{
    public class EmployeWageProblem
    {
        const int wagePerHour = 20;
        const int fullDayHour = 8;
        int dailyWage = 0;
        public void EmpWage()
        {
            Random checkAttendance  = new Random();
            int check = checkAttendance.Next(2);
            if (check == 1)
            {
                dailyWage = wagePerHour * fullDayHour;
                Console.WriteLine("Employee is present");
                Console.WriteLine("Daily Wage is : " +dailyWage);
            }
            else
                Console.WriteLine("Employee is absent");
            Console.ReadKey();
        }
    }
}
