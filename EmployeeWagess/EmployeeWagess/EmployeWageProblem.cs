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
            switch (check)
            {
                case 0:
                    empHour = 8;
                    Console.WriteLine("Employee is fully present");
                    break;
                case 1:
                    empHour = 4;
                    Console.WriteLine("Employee is partly present");
                    break;
                case 2:
                    empHour = 0;
                    Console.WriteLine("Employee is absent");
                    break;
            }
            dailyWage = wagePerHour * empHour;
            Console.WriteLine("Daily wage is : " + dailyWage);
            Console.ReadKey();
        }
    }
}
