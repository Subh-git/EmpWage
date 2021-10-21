using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage01
{
    public class EmpWageBuilderArray
    {
        //constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilderArray()                                //declaring the array size and all
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }

        //method to insert into the array
        public void addCompanyEmpWage(string companyName, int maxWorkingDay, int maxWorkingHrs, int empRate) 
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(companyName, maxWorkingDay, maxWorkingHrs, empRate);
            numOfCompany++;
        }
        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.ComputeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }

        private int ComputeEmpWage(CompanyEmpWage Company)
        {
            int empWage = 0;
            int totalWorkingDay = 0;
            int totalWorkingHrs = 0;
            int empHr = 0;

            //while loop programming construct
            while (totalWorkingDay < Company.maxWorkingDay && totalWorkingHrs <= Company.maxWorkingHrs)
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
                empWage = Company.empRate * empHr;
                //formula for calculating total emloyee wage
                Company.totalEmpWage = Company.totalEmpWage + empWage;
                //incrementation
                totalWorkingDay++;
                totalWorkingHrs = totalWorkingHrs + empHr;

            }

            Console.WriteLine("Total Working Days: {0}, Total Working Hrs: {1}", totalWorkingDay, totalWorkingHrs);
            return Company.totalEmpWage;

        }
    }
}
    public class CompanyEmpWage
    {
        //variables
        public int empRate;
        public int maxWorkingDay;
        public int maxWorkingHrs;
        public int totalEmpWage;
        public string companyName;

        //Constructor declaration
        public CompanyEmpWage(string companyName, int maxWorkingDay, int maxWorkingHrs, int empRate)
        {
            this.companyName = companyName;
            this.maxWorkingDay = maxWorkingDay;
            this.maxWorkingHrs = maxWorkingHrs;
            this.empRate = empRate;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "Total Employee Wage For " + this.companyName + " " + "is " + this.totalEmpWage;
        }
    }
