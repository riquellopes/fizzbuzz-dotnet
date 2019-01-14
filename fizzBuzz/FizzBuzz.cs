using System;
namespace fizzBuzz
{
    public class FizzBuzz
    {
        private int numeric;

        public int Numeric { get => numeric; set => numeric = value; }

        private string Calculate(int divisor, string text)
        {
            if (numeric > 0 && numeric % divisor == 0)
                return text;
            return "";
        }

        public string GetResult()
        {
            string fizzbuzz = String.Concat(Calculate(3, "fizz"), Calculate(5, "buzz"));

            if (fizzbuzz.Length > 0)
                return fizzbuzz;
            return numeric.ToString();
        }
    }
}
