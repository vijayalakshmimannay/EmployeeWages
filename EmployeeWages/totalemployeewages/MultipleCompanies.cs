using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace totalemployeewages
{
    internal class MultipleCompanies
    {
        int IS_FULL_TIME = 1;
        int IS_PART_TIME = 0;
        int empHrs = 0;
        int empWage = 0;
        int totalEmpWage = 0;
        int totalEmpHrs = 0;
        int totalWorkingDays = 0;

        public void calculateTotalEmpWage(string companyname, int MAX_HRS_IN_MONTH, int NUM_OF_WORKING_DAYS, int EMP_RATE_PER_HRS)
        {
            while (totalEmpHrs < MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random rand = new Random();
                int empCheck = rand.Next(0, 3);
                switch (empCheck)
                {
                    case 1:
                        Console.WriteLine("Employee is present full time");
                        empHrs = 8;
                        break;

                    case 2:
                        Console.WriteLine("Employee is present part time");
                        empHrs = 4;
                        break;

                    default:
                        Console.WriteLine("Employee is absent");
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days " + totalWorkingDays + " " + "Employee Hours " + totalEmpHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HRS;
            Console.WriteLine("Total employee wage of firm -{0} for {1} hrs in {2} days is {3} ", companyname, EMP_RATE_PER_HRS, MAX_HRS_IN_MONTH, NUM_OF_WORKING_DAYS);


        }

    }
}
