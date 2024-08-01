using TwistedFizzBuzz;

var config = new TwistedFizzBuzzConfiguration(
    new List<MultiplierConfiguration>
    {
        new MultiplierConfiguration(5, "Fizz"),
        new MultiplierConfiguration(9, "Buzz"),
        new MultiplierConfiguration(27, "Bar"),
    });

var tokens = TwistedFizzBuzzGenerator.Generate(-20, 127, config);

foreach (var token in tokens)
{
    Console.WriteLine(token);
}