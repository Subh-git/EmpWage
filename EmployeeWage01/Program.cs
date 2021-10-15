using System;

namespace EmployeeWage01
{
    class Program
    {
        /// <summary>
        /// The is full time
        /// </summary>
        
        //Declaring constant variables
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;

        //defining the class method ComputeEmpWage()
        public static int ComputeEmpWage()
        {

            //Console.WriteLine("Welcome to the Employee Wage computation program");            
            //Variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int maxHrs = 0;
            int maxDay = 0;

            while (maxHrs < MAX_HRS_IN_MONTH && maxDay < NUM_OF_WORKING_DAYS)  //while loop to check which condition meets first
            {
                maxDay++;

                Random random = new Random(); //Random object creation

                //Computation
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        //Console.WriteLine("Employee is Part time");
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        //Console.WriteLine("Employee is Fulltime");
                        break;
                    default:
                        empHrs = 0;
                        //Console.WriteLine("Employee is Absent");
                        break;


                }
                maxHrs += empHrs; //incrementing employee hours
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Day {0} and hours {1}", maxDay, maxHrs);
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            totalEmpWage += empWage;
            Console.WriteLine("Total Employee Wage : " + totalEmpWage);
            return totalEmpWage;

        }
        static void Main(string[] args)
        {
            ComputeEmpWage();   
        }
    }
}
