using TwistedFizzBuzz;

namespace TwistedFizzBuzzTests
{
    [TestClass]
    public class TwistedFizzBuzzGeneratorTests
    {
        [TestMethod]
        public void TestGenerateSequentialNumbers()
        {
            var configuration = new TwistedFizzBuzzConfiguration
            {
                Multipliers = new List<MultiplierConfiguration>
                {
                    new MultiplierConfiguration(3, "Fizz"),
                    new MultiplierConfiguration(5, "Buzz")
                }
            };

            var result = TwistedFizzBuzzGenerator.Generate(1, 15, configuration);

            var expected = new List<string>
            {
                "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"
            };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestGenerateNonSequentialNumbers()
        {
            var configuration = new TwistedFizzBuzzConfiguration
            {
                Multipliers = new List<MultiplierConfiguration>
                {
                    new MultiplierConfiguration(3, "Fizz"),
                    new MultiplierConfiguration(5, "Buzz")
                }
            };

            var result = TwistedFizzBuzzGenerator.Generate(-5, 6, configuration);

            var expected = new List<string>
            {
                "Buzz", "-4", "Fizz", "-2", "-1", "FizzBuzz", "1", "2", "Fizz", "4", "Buzz", "Fizz"
            };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestGenerateWithNegativeRange()
        {
            var configuration = new TwistedFizzBuzzConfiguration
            {
                Multipliers = new List<MultiplierConfiguration>
                {
                    new MultiplierConfiguration(5, "Fizz"),
                    new MultiplierConfiguration(9, "Buzz"),
                    new MultiplierConfiguration(27, "Bar")
                }
            };

            var result = TwistedFizzBuzzGenerator.Generate(-20, 30, configuration);
            
            var expected = new List<string>
            {
                "Fizz", "-19", "Buzz", "-17", "-16", "Fizz", "-14", "-13", "-12", "-11",
                "Fizz", "Buzz", "-8", "-7", "-6", "Fizz", "-4", "-3", "-2", "-1",
                "FizzBuzzBar", "1", "2", "3", "4", "Fizz", "6", "7", "8", "Buzz",
                "Fizz", "11", "12", "13", "14", "Fizz", "16", "17", "Buzz", "19",
                "Fizz", "21", "22", "23", "24", "Fizz", "26", "BuzzBar", "28", "29", "Fizz"
            };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestGenerateWithCustomConfiguration()
        {
            var configuration = new TwistedFizzBuzzConfiguration
            {
                Multipliers = new List<MultiplierConfiguration>
                {
                    new MultiplierConfiguration(7, "Poem"),
                    new MultiplierConfiguration(17, "Writer"),
                    new MultiplierConfiguration(3, "College")
                }
            };

            var result = TwistedFizzBuzzGenerator.Generate(350, 360, configuration);

            var expected = new List<string>
            {
                "Poem", "College", "352", "353", "College", "355", "356", "PoemWriterCollege", "358", "359",
                "College"
            };

            CollectionAssert.AreEqual(expected, result);
        }
    }
}