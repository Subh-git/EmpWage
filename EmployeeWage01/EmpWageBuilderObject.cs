using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage01
{
    public class EmpWageBuilderObject
    {
        //constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        //variables
        private int empRate;
        private int maxWorkingDay;
        private int maxWorkingHrs;
        private int totalEmpWage;
        private string companyName;

        //Constructor
        public EmpWageBuilderObject(string companyName, int maxWorkingDay, int maxWorkingHrs, int empRate)
        {
            this.companyName = companyName;
            this.maxWorkingDay = maxWorkingDay;
            this.maxWorkingHrs = maxWorkingHrs;
            this.empRate = empRate;
        }
        //instance method 
        public void ComputeEmpWage()
        {
            //local variable
            int empWage = 0;
            int totalWorkingDay = 0;
            int totalWorkingHrs = 0;
            int empHr = 0;

            //while loop programming construct
            while (totalWorkingDay < maxWorkingDay && totalWorkingHrs <= maxWorkingHrs)
            {
                //used predefined Random class
                Random attendance = new Random();
                int empInput = attendance.Next(0, 3);

                switch (empInput)
                {
                    case IS_FULL_TIME:
                        empHr = 8;
                        break;


                    case IS_PART_TIME:
                        empHr = 4;
                        break;

                    default:
                        empHr = 0;
                        break;
                }

                // Formula for calculating employe wage
                empWage = empRate * empHr;
                //formula for calculating total emloyee wage
                totalEmpWage = totalEmpWage + empWage;
                //incrementation
                totalWorkingDay++;
                totalWorkingHrs = totalWorkingHrs + empHr;

            }
            Console.WriteLine("Total Working Days: {0}, Total Working Hrs: {1}", totalWorkingDay, totalWorkingHrs);

        }
        public string toString()
        {
            return "Total Employee Wage For " + companyName + " " + "is " + totalEmpWage;
        }
    }
}
