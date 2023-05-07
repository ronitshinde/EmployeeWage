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
        int workingDays;
        int totalHours = 0;
        int dailyWage = 0;
        int empHour = 0;
        int totalWageCount = 0;
        int totalWorkingDays = 0;
        public void EmpWage(int workingDays)
        {
            this.workingDays = workingDays;
            Random checkAttendance = new Random();
            while (totalHours <= 100 && workingDays <= 20)
            {
                if (totalHours == 100)
                    break;
                int check = checkAttendance.Next(3);
                switch (check)
                {
                    case 0:
                        empHour = 8;
                        break;
                    case 1:
                        empHour = 4;
                        break;
                    case 2:
                        empHour = 0;
                        break;
                }
                dailyWage = wagePerHour * empHour;
                Console.WriteLine("Employee hours for Day " + workingDays + " is : " + empHour + " with wage : " + dailyWage);
                totalWageCount += dailyWage;
                totalHours += empHour;
                totalWorkingDays = workingDays;
                workingDays++;
            }
            Console.WriteLine("Total wage count is : " + totalWageCount);
            Console.WriteLine("Total hours count is : " + totalHours);
            Console.WriteLine("Total working days is : " + totalWorkingDays);
            Console.ReadKey();
        }
    }
}
