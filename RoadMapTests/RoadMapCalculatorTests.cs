using io_1.Elements;

namespace RoadMapTests
{
    public class RoadMapCalculatorTests
    {
        [Fact]
        public void Calculate_Standard_ReturnsCorrectCost()
        {
            RoadMapCalculator roadmapcalculator = new();
            var result = roadmapcalculator.Calculate(1, 2);
            Assert.Equal(1, result);
        }
    }
}