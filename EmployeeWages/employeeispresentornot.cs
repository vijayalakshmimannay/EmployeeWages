using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeewages
{
    class employeeispresentornot
    {
        public void presentorabsent()
        {
            //constants
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 0;
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
    }
}
