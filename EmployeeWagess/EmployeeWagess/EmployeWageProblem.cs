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
        const int workingDays = 20;
        int dailyWage = 0;
        int empHour = 0;
        int totalWageCount = 0;
        public void EmpWage()
        {
            Random checkAttendance = new Random();
            for (int i = 0; i < workingDays; i++)
            {
                int check = checkAttendance.Next(3);
                switch (check)
                {
                    case 0:
                        empHour = 8;
                        Console.Write("Employee is fully present");
                        break;
                    case 1:
                        empHour = 4;
                        Console.Write("Employee is partly present");
                        break;
                    case 2:
                        empHour = 0;
                        Console.Write("Employee is absent");
                        break;
                }
                dailyWage = wagePerHour * empHour;
                Console.WriteLine(" with daily wage : "+dailyWage);
                totalWageCount += dailyWage;
            }
            Console.WriteLine("Total wage count is : " + totalWageCount);
            Console.ReadKey();
        }
    }
}
