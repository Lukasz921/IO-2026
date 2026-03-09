using io_1.Elements;

namespace RoadMapTests
{
    public class RoadMapCalculatorTests
    {
        [Fact]
        public void Calculate_Standard_ReturnsCorrectCost()
        {
            RoadMapCalculator roadmapcalculator = new();
            RoadMap roadmap = new();
            var result = roadmapcalculator.Calculate("Warszawa", "Kraków", roadmap);
            Assert.Equal(300, result);
        }
        [Fact]
        public void Calculate_Standard_ThrowsException()
        {
            RoadMapCalculator roadmapcalculator = new();
            RoadMap roadmap = new();
            var ex = Assert.Throws<ArgumentException>(() => 
                roadmapcalculator.Calculate("Warszawa", "Warszawa", roadmap));
            Assert.Equal("Cities cannot be the same.", ex.Message);
        }
        [Fact]
        public void Calculate_NonExistingCity_ThrowsException()
        {
            RoadMapCalculator roadmapcalculator = new();
            RoadMap roadmap = new();
            var ex = Assert.Throws<ArgumentException>(() =>
                roadmapcalculator.Calculate("Warszawa", "Andrzej", roadmap));
            Assert.Equal("There is no such connection in roadmap.", ex.Message);
        }
    }
}