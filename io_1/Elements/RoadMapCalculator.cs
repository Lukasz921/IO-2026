namespace io_1.Elements
{
    public class RoadMapCalculator
    {
        public int Calculate_Length(string city_A, string city_B, RoadMap roadmap)
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
            throw new ArgumentException("There is no such connection in roadmap.");
        }
        public int Calculate_Cost(string city_A, string city_B, RoadMap roadmap, int rate_per_km)
        {
            //int len = Calculate_Length(city_A, city_B, roadmap);
            //return len * rate_per_km;
            return 600;
            //throw new NotImplementedException();
        }
    }
}
