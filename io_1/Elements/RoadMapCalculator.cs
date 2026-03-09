namespace io_1.Elements
{
    public class RoadMapCalculator
    {
        public int Calculate(int city_A, int city_B)
        {
            if (city_A == city_B)
            {
                throw new ArgumentException("Cities cannot be the same.");
            }
            return 1;
        }
    }
}
