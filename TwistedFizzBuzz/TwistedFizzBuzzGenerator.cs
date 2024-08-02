using System.Text;

namespace TwistedFizzBuzz
{
    public static class TwistedFizzBuzzGenerator
    {
        public static List<string> Generate(int number1, int number2)
        {
            return Generate(number1, number2, new TwistedFizzBuzzConfiguration());
        }

        public static List<string> Generate(int number1, int number2, TwistedFizzBuzzConfiguration configuration)
        {
            var start = Math.Min(number1, number2); 
            var end = Math.Max(number1, number2);

            var listSize = end - start + 1;
            var output = new List<string>(listSize);

            for (int currentNumber = start; currentNumber <= end; currentNumber++)
            {
                var token = GetToken(currentNumber, configuration);
                output.Add(token);
            }

            return output;
        }

        private static string GetToken(int number, TwistedFizzBuzzConfiguration configuration)
        {
            var output = new StringBuilder();

            foreach (var multiplier in configuration.Multipliers)
            {
                if (number.IsMultipleOf(multiplier.Value))
                {
                    output.Append(multiplier.Token);
                }
            }

            return output.Length == 0 
                ? number.ToString() 
                : output.ToString();
        }
    }
}