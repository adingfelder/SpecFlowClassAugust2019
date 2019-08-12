using System;
using System.Collections.Generic;

namespace MyNewCalculator
{
    public class Calculator
    {
        public List<int> numbers = new List<int>();
        public int total;
        public Calculator()
        {
            Console.WriteLine("doing GivenIHaveEnteredIntoTheCalculator");
            total = 0;
        }
        public int Add()
        {
            foreach (int number in numbers)
            {
                total = total + number;
            }
            return total;
        }

        public int Subtract()
        {
            // cant support multiple numbers yet
            if (numbers.Count > 2)
            {
                throw new Exception("Too Many Numbers to subtract");
            }
            int one = numbers[0];
            int two = numbers[1];
            total =  one - two;
            return total;
        }

        public int Divide()
        {
            // cant support multiple numbers yet
            if (numbers.Count > 2)
            {
                throw new Exception("Too Many Numbers to subtract");
            }
            // cant divide by zero
            if (numbers[1] == 0)
            {
                throw new Exception("Cant divide by zero");
            }
            int one = numbers[0];
            int two = numbers[1];
            total = one / two;
            return total;

        }
    }
}

