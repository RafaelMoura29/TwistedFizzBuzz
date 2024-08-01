namespace TwistedFizzBuzz
{
    public static class Extensions
    {
        public static bool IsMultipleOf(this int number, int multiplier)
        {
            return number % multiplier == 0;
        }
    }
}