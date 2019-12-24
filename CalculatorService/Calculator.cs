using System;

namespace calculatorService
{
    public class Calculator
    {
        public int Add(string inputStr)
        {
            string delimiter  = "\n";
            inputStr = inputStr.Replace('\n', ',');
            string[] numbers = inputStr.Split(',');
            int total = 0;

            foreach (var num in numbers)
            {
                int i = 0;
                bool result = int.TryParse(num, out i);
                total += i;
            }

            return total;
        }
    }
}
