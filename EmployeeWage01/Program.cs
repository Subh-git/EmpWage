﻿using System;

namespace EmployeeWage01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to the Employee Wage computation program");
            //Constants
            int IS_FULL_TIME = 1;
            Random random = new Random();

            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            

        }
    }
}
