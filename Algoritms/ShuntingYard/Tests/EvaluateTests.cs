using NUnit.Framework;
using FluentAssertions;
using ShuntingYard;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EvaluateTest()
        {
            ShuntingYardClass sy = new ShuntingYardClass();
            Evaluator calculator = new Evaluator();
            calculator.Evaluate(sy.ShuntingYardAlgorithm("418560 / ( 34 * 25 - 196 ) * 708 - 500347 / 983 + 8989898")).Should().Be(9442509);
            calculator.Evaluate(sy.ShuntingYardAlgorithm("20 * 20 / ( 10 - ( 4.777 * 7.666 + 6 ) + 5 * ( 43.32 * 8.5 ) )")).Should().Be(0.2211802765907797);
            calculator.Evaluate(sy.ShuntingYardAlgorithm("( 1338 + 58487 ) + 123 / 244 * 38 + ( 1028 - 609 )")).Should().Be(60263.1557377049180328);
            calculator.Evaluate(sy.ShuntingYardAlgorithm("2 * ( 2 + 2 )")).Should().Be(8);
            calculator.Evaluate(sy.ShuntingYardAlgorithm("2 / 2 * ( 100 + 40 ) / ( 2 ^ 2 + 4 )")).Should().Be(17.5);
        }
    }
}