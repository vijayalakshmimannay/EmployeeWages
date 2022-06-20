using System;

namespace totalemployeewages
{
    internal class program
    {
        public static void Main(String[] args)
        {
            totalemployeewages.savetotalwage value = new totalemployeewages.savetotalwage("abc", 20, 500, 60);
            totalemployeewages.savetotalwage program = new totalemployeewages.savetotalwage("reliance", 20, 500, 60);
            value.calculateTotalEmpWage();
            Console.WriteLine(value.ToString());
            program.calculateTotalEmpWage();
            Console.WriteLine(program.ToString());
        }
    }
}