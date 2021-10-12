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
     

        //defining the class method ComputeEmpWage()
        //taking multiple parameterd inputs from the user in main method
        public static int ComputeEmpWage(string companyName, int empRatePerHour, int maxWorkingDays,  int maxWorkingHours)
        {

            //Console.WriteLine("Welcome to the Employee Wage computation program");            
            //Variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int maxHrs = 0;
            int maxDay = 0;

            while (maxHrs < maxWorkingHours && maxDay < maxWorkingDays)  //while loop to check which condition meets first
            {
                maxDay++;

                Random random = new Random(); //Random object creation

                //Computation
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                maxHrs += empHrs;                                   //incrementing employee hours
                empWage = empHrs * empRatePerHour;
                totalEmpWage += empWage;
            }
            Console.WriteLine("The total emp wage for the company {0} is - {1}", companyName, totalEmpWage);
            return totalEmpWage;

        }
        static void Main(string[] args)
        {
            ComputeEmpWage("CapeGemini",25,15,30);
            ComputeEmpWage("Amazon", 40, 25, 37);
            ComputeEmpWage("Ford", 35, 20, 40);
        }
    }
}
