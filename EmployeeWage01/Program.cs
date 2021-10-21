using System;

namespace EmployeeWage01
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 2, 10, 20);
            EmpWageBuilderObject Ford = new EmpWageBuilderObject("Ford", 5, 15, 30);
            dMart.ComputeEmpWage();
            Ford.ComputeEmpWage();
            Console.WriteLine(dMart.toString());
            Console.WriteLine(Ford.toString());
        }
    }
}
