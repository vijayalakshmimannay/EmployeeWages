using System;
namespace employeewages
{
    public class program
    {
        public static void Main(string[] args)
        {
            employeeispresentornot employeeispresentornot = new employeeispresentornot();
            employeeispresentornot.presentorabsent();
            employeeispresentornot.dailyWage();
        }
    }
}