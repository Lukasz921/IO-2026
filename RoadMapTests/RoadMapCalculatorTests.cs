using io_1.Elements;

namespace RoadMapTests
{
    public class RoadMapCalculatorTests
    {
        [Fact]
        public void Calculate_Len_ReturnsCorrectLen()
        {
            RoadMapCalculator roadmapcalculator = new();
            RoadMap roadmap = new();
            var result = roadmapcalculator.Calculate_Length("Warszawa", "Kraków", roadmap);
            Assert.Equal(300, result);
        }
        [Fact]
        public void Calculate_Len_SameCities_ThrowsException()
        {
            RoadMapCalculator roadmapcalculator = new();
            RoadMap roadmap = new();
            var ex = Assert.Throws<ArgumentException>(() => 
                roadmapcalculator.Calculate_Length("Warszawa", "Warszawa", roadmap));
            Assert.Equal("Cities cannot be the same.", ex.Message);
        }
        [Fact]
        public void Calculate_Len_NonExistingCity_ThrowsException()
        {
            RoadMapCalculator roadmapcalculator = new();
            RoadMap roadmap = new();
            var ex = Assert.Throws<ArgumentException>(() =>
                roadmapcalculator.Calculate_Length("Warszawa", "Andrzej", roadmap));
            Assert.Equal("There is no such connection in roadmap.", ex.Message);
        }
        [Fact] 
        public void Calculate_Cost_ReturnsCorrectCost()
        {
            RoadMapCalculator roadmapcalculator = new();
            RoadMap roadmap = new();
            var result = roadmapcalculator.Calculate_Cost("Warszawa", "Kraków", roadmap, 2);
            Assert.Equal(600, result);
        }
    }
}