using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeewages
{
    class employeeispresentornot
    { 
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 0;
            int empHrs = 0;
            int EMP_RATE_PER_HRS = 20;
            int empWage = 0;
            public void presentorabsent()
            {

                Random random = new Random();
                //computation
                int empCheck = random.Next(0, 3);
                if (empCheck == IS_FULL_TIME)
                {
                    Console.WriteLine("Employee is present");
                }
                else
                {
                    Console.WriteLine("Employee is absent");
                }

            }
        public void dailyWage()
        {
            Random rand = new Random();
            int empCheck = rand.Next(0, 3);
            if (empCheck == 1)
            {
                Console.WriteLine("Employee is present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HRS;
            Console.WriteLine("Daily employee wage " + empWage + "\n");

        }

        public void addPartTimeWage()
        {

            Random rand = new Random();
            int empCheck = rand.Next(0, 3);

            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present full time");
                empHrs = 8;
            }
            else if (empCheck == IS_PART_TIME)
            {
                Console.WriteLine("Employee is present part time");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HRS;
            Console.WriteLine("Daily employee wage " + empWage + "\n");
        }
        public void EmpWageUsingSwitch()
        {
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
            empWage = empHrs * EMP_RATE_PER_HRS;
            Console.WriteLine("Daily employee wage " + empWage + "\n");
        }
    }
}




