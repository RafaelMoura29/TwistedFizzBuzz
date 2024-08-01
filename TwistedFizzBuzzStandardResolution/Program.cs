using TwistedFizzBuzz;

var tokens = TwistedFizzBuzzGenerator.Generate(1, 100);

foreach (var token in tokens)
{
    Console.WriteLine(token);
}
