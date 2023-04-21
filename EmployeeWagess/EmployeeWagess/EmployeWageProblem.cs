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
        int dailyWage = 0;
        int empHour = 0;
        public void EmpWage()
        {
            Random checkAttendance = new Random();
            int check = checkAttendance.Next(3);
            if (check == 0)
            {
                empHour = 8;
                Console.WriteLine("Employee is fully present");
            }
            else if (check == 1)
            {
                empHour = 4;
                Console.WriteLine("Employee is partly present");
            }
            else
            {
                empHour = 0;
                Console.WriteLine("Employee is absent");
            }
            dailyWage = wagePerHour * empHour;
            Console.WriteLine("Daily Wage is : " + dailyWage);
            Console.ReadKey();
        }
    }
}
