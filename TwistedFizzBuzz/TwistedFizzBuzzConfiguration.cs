namespace TwistedFizzBuzz
{
    public class TwistedFizzBuzzConfiguration
    { 
        public TwistedFizzBuzzConfiguration() { }

        public TwistedFizzBuzzConfiguration(List<MultiplierConfiguration> multipliers)
        {
            Multipliers = multipliers;
        }

        public List<MultiplierConfiguration> Multipliers { get; set; }
            = new List<MultiplierConfiguration>
            {
                new MultiplierConfiguration(3, "Fizz"),
                new MultiplierConfiguration(5, "Buzz")
            };
    }

    public class MultiplierConfiguration
    {
        public MultiplierConfiguration(int value, string token)
        {
            Value = value;
            Token = token;
        }

        public int Value { get; set; }
        public string Token { get; set; }
    }
}