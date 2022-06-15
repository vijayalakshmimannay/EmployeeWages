using System;
namespace employeewages
{
    public class program
    {
        public static void Main(string[] args)
        {
             totalemployeewages.ispresent value = new totalemployeewages.ispresent();
            value.presentorabsent();
            value.dailyWage();
            value.addPartTimeWage();
            value.EmpWageUsingSwitch();
            value.calculateMonthlyWage();
        }
    }
}
