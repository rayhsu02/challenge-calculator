using System;
using System.Collections;
using System.Text;

namespace calculatorService
{
    public class Calculator
    {
        public int Add(string inputStr)
        {
            bool HasCustomDelimiter = inputStr.Contains("//");
            bool HasMultiCustDelimiter = inputStr.Contains("[");
            bool IsSingleCharDelimiter = HasCustomDelimiter == true && HasMultiCustDelimiter == false;

            if (HasCustomDelimiter)
            {
                inputStr = inputStr.Replace("//", "");
                string[] delimiters = GetDeliomiters(inputStr);
                foreach(string s in delimiters)
                {
                    inputStr = inputStr.Replace(s, ",");
                }
            }
           
            if (IsSingleCharDelimiter)
            {
                char delimiter = inputStr[0];
                inputStr = inputStr.Replace(delimiter, ',');
            }
            //helper function to get delimiters

            inputStr = inputStr.Replace('\n', ',');
            string[] numbers = inputStr.Split(',');
            int total = 0;

            foreach (var num in numbers)
            {
                int i = 0;
                bool result = int.TryParse(num, out i);

                if (i < 0) throw new Exception("negtive number expection");
                if (i > 1000) i = 0;

                total += i;
            }

            return total;
        }

        private string[] GetDeliomiters(string inputStr)
        {
            ArrayList list = new ArrayList();
            Stack stack = new Stack();
            StringBuilder sb = new StringBuilder();

            foreach(char c in inputStr)
            {
                if (c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ']')
                {
                    stack.Pop();
                    list.Add(sb.ToString());
                    sb.Clear();
                }
                else
                {
                    if(stack.Count != 0) sb.Append(c);
                }
            }

            return (string[])list.ToArray(typeof(string));
        }
    }
}
