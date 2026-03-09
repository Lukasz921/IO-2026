namespace io_1.Elements
{
    public class RoadMapCalculator
    {
        public int Calculate(string city_A, string city_B, RoadMap roadmap)
        {
            if (city_A == city_B)
            {
                throw new ArgumentException("Cities cannot be the same.");
            }
            if (roadmap.GetRoadMap.ContainsKey((city_A, city_B)))
            {
                return (int)roadmap.GetRoadMap[(city_A, city_B)];
            }
            else if (roadmap.GetRoadMap.ContainsKey((city_B, city_A)))
            {
                return (int)roadmap.GetRoadMap[(city_B, city_A)];
            }
            return 0;
            throw new ArgumentException("There is no such connection in roadmap.");
        }
    }
}
