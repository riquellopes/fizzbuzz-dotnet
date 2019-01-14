using System;
namespace fizzBuzz
{
    public class FizzBuzz
    {
        private int numeric;

        public int Numeric { get => numeric; set => numeric = value; }

        public string GetResult()
        {
            if(numeric > 0 && numeric % 3 == 0)
            {
                return "fizz";
            }

            if (numeric > 0 && numeric % 5 == 0)
            {
                return "buzz";
            }

            return numeric.ToString();
        }
    }
}
