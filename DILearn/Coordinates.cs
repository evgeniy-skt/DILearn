namespace DILearn
{
    public class Coordinates
    {
        public float Longitude { get; set; }
        public float Latitude { get; set; }

        public static float RawDistanceTo(Coordinates otherCoords)
        {
            if (otherCoords.Latitude >= 0 && otherCoords.Longitude >= 0)
            {
                if (otherCoords.Latitude < 30 && otherCoords.Longitude < 60)
                {
                    return 3;
                }
            }

            if (otherCoords.Latitude >= 30 && otherCoords.Latitude < 60 && otherCoords.Longitude >= 60 &&
                otherCoords.Longitude > 120)
            {
                return 10;
            }

            return 15;
        }
    }
}