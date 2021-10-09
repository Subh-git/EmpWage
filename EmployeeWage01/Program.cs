using System;

namespace EmployeeWage01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to the Employee Wage computation program");
            //Constants
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            
            //Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random(); //Random object creation

            //Computation
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }

            else if (empCheck == IS_PART_TIME)
            {
                Console.WriteLine("Employee is Part time");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage: " + empWage);
            
        }
    }
}
