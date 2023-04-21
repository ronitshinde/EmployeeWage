using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagess
{
    public class EmployeWageProblem
    {
        public void Random()
        {
            Random num = new Random();
            int numOne = num.Next(2);
            if(numOne==1)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
            Console.ReadKey();
        }
    }
}
