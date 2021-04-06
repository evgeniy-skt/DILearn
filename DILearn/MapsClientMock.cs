using System.Threading.Tasks;

namespace DILearn
{
    public class MapsClientMock : IMapsClient
    {
        public Task<Coordinates> GetAddressCoordinates(string address)
        {
            return Task.FromResult(new Coordinates {Longitude = 10, Latitude = 12});
        }
    }
}