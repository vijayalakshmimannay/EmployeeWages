using System;
namespace employeewages
{
    public class program
    {
        public static void Main(string[] args)
        {
            totalemployeewages.ispresentt value = new totalemployeewages.ispresent();
            value.presentorabsent();
            value.dailyWage();
            value.addPartTimeWage();
            value.EmpWageUsingSwitch();
            value.calculateMonthlyWage();
            value.calculateTotalEmpWage();
            value.WageForMonth();
        }
    }
}