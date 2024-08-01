using System.Runtime.CompilerServices;

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
            var start = number1 < number2 ? number1 : number2; 
            var end = number1 < number2 ? number2 : number1;
            
            var currentNumber = start;
            var listSize = end - start;
            var output = new List<string>(listSize);

            while (currentNumber <= end)
            {
                var token = GetToken(currentNumber, configuration);
                output.Add(token);
                currentNumber++;
            }

            return output;
        }

        private static string GetToken(int number, TwistedFizzBuzzConfiguration configuration)
        {
            var output = "";

            foreach (var multiplier in configuration.Multipliers)
            {
                output += number.IsMultipleOf(multiplier.Value) 
                    ? multiplier.Token
                    : "";
            }

            return output == "" 
                ? number.ToString() 
                : output;
        }
    }
}