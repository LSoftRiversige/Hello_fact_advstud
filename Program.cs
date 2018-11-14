using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_fact_advstud
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define parameters to calculate the factorial of
            //Call fact() method to calculate
            int r = Fact(args);
            Console.WriteLine($"The factorial = {r}");
            Console.WriteLine("Press Enter");
            Console.ReadLine();

            Console.WriteLine("Type int values to calculate factorial, separate with comma:");
            string input = Console.ReadLine();
            string[] digits=input.Split(',');

            r = Fact(digits);

            Console.WriteLine($"The factorial of {input} = {r}");
            

            r = FactTern(digits);

            Console.WriteLine($"The factorial (with FactTern) of {input} = {r}");
            Console.WriteLine("Press Enter");
            Console.ReadLine();

        }

        private static int Fact(string[] args)
        {
            int Result = 1;
            foreach (string i in args)
            {
                Result *= Convert.ToInt32(i);
            }
            return Result;
        }

        //Create fact() method  with parameter to calculate factorial
        //Use ternary operator

        private static int FactTern(string[] args)
        {
            int Result = 1;
            foreach (string i in args)
            {
                int num = Convert.ToInt32(i);
                Result *= num>0 ? num : 1;
            }
            return Result;
        }

    }

    

}
