using algorithm_assignment.test;
using static System.Console;

namespace algorithm_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FunctionalTest.InsertOptionA();
            WriteLine();
            FunctionalTest.InsertOptionB();
            WriteLine();

            FunctionalTest.SearchOptionA();
            WriteLine();
            FunctionalTest.SearchOptionB();
            WriteLine();

            FunctionalTest.DeleteOptionA();
            WriteLine();
            FunctionalTest.DeleteOptionB();
            WriteLine();

            EfficiencyTest.InsertOptionA();
            WriteLine();
            EfficiencyTest.InsertOptionB();
            WriteLine();

            EfficiencyTest.SearchOptionA();
            WriteLine();
            EfficiencyTest.SearchOptionB();
            WriteLine();

            EfficiencyTest.DeleteOptionA();
            WriteLine();
            EfficiencyTest.DeleteOptionB();
            WriteLine();

        }

    }
}