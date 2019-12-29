using calculatorService;
using System;

namespace calculatorApp
{
    class Program
    {
        static void Main()
        {
            Calculator calculatorService = new Calculator();

            Console.WriteLine("Enter numbers to add (separate by delimiter : ");
            string input = Console.ReadLine();
            int result = calculatorService.Add(input);
            Console.WriteLine("Total is " + result);
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
            
        }
    }
}
