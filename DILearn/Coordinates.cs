using System;
using System.Threading.Tasks;

namespace DILearn
{
    public class Coordinates
    {
        public float Longitude { get; set; }
        public float Latitude { get; set; }

        public static float RawDistanceTo(Coordinates otherCoords)
        {
            return 3;
        }
    }
}