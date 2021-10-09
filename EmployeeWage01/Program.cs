using System;

namespace EmployeeWage01
{
    class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to the Employee Wage computation program");            
            //Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random(); //Random object creation

            //Computation
            int empCheck = random.Next(0, 3);
           switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    Console.WriteLine("Employee is Part time");
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    Console.WriteLine("Employee is Fulltime");
                    break;
                default:
                    empHrs = 0;
                    Console.WriteLine("Employee is Absent");
                    break;


            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage: " + empWage);
            
        }
    }
}
