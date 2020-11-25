using System;

namespace interface_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicCalculator basicCalculator = new BasicCalculator();

            Console.WriteLine(basicCalculator.sum(10, 5));
            Console.WriteLine(basicCalculator.sub(10, 5));
            Console.WriteLine(basicCalculator.multiplication(10, 5));
            Console.WriteLine(basicCalculator.division(10, 5));

            ScientificCalculator scientificCalculator = new ScientificCalculator();

            Console.WriteLine(scientificCalculator.root(81));
            Console.WriteLine(scientificCalculator.square(9));
            Console.WriteLine(scientificCalculator.sub(10, 5));
            Console.WriteLine(scientificCalculator.multiplication(10, 5));


        }
    }
}
