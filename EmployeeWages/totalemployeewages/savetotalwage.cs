using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace totalemployeewages
{
    internal class savetotalwage
    {
        int IS_FULL_TIME = 1;
        int IS_PART_TIME = 0;
        int empHrs = 0;
        int empWage = 0;
        int totalEmpHrs = 0;
        int totalWorkingDays = 0;

        string companyname;
        int EMP_RATE_PER_HRS, NUM_OF_WORKING_DAYS, MAX_HRS_IN_MONTH, totalEmpWage;
        public savetotalwage(string companyname, int eMP_RATE_PER_HRS, int nUM_OF_WORKING_DAYS, int mAX_HRS_IN_MONTH)
        {
            this.companyname = companyname;
            this.EMP_RATE_PER_HRS = eMP_RATE_PER_HRS;
            this.NUM_OF_WORKING_DAYS = nUM_OF_WORKING_DAYS;
            this.MAX_HRS_IN_MONTH = mAX_HRS_IN_MONTH;

        }
        public void calculateTotalEmpWage()
        {
            while (totalEmpHrs <= this.MAX_HRS_IN_MONTH && totalWorkingDays < this.NUM_OF_WORKING_DAYS)
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
            int totalEmpWage = totalEmpHrs * this.EMP_RATE_PER_HRS;
            Console.WriteLine("Total employee wage of firm -{0} for {1} hrs in {2} days is {3} ", companyname, EMP_RATE_PER_HRS, MAX_HRS_IN_MONTH, NUM_OF_WORKING_DAYS);

        }

        public void tostring()
        {
            Console.WriteLine("Total employee wage of firm -{0} for {1} hrs in {2} days is {3} ", this.companyname, this.EMP_RATE_PER_HRS, this.MAX_HRS_IN_MONTH, this.NUM_OF_WORKING_DAYS);
        }

    }
}
