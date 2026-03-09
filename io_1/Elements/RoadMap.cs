using System.Collections;

namespace io_1.Elements
{
    public class RoadMap
    {
        public Hashtable GetRoadMap { get; private set; }
        public RoadMap()
        {
            GetRoadMap = [];
            GetRoadMap.Add(("Warszawa", "Kraków"), 300);
            GetRoadMap.Add(("Warszawa", "Łódź"), 150);
            GetRoadMap.Add(("Gdańsk", "Sopot"), 100);
            GetRoadMap.Add(("Gdynia", "Gdańsk"), 100);
        }
    }
}
