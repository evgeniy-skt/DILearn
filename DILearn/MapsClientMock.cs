using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace DILearn
{
    public class MapsClientMock : IMapsClient
    {
        public Task<Coordinates> GetAddressCoordinates(string address)
        {
            var coordinatesPool = new List<Coordinates>
            {
                new() {Longitude = 10, Latitude = 12},
                new() {Longitude = 0, Latitude = 29},
                new() {Longitude = 180, Latitude = 90},
                new() {Longitude = 0, Latitude = 0},
                new() {Longitude = 17, Latitude = 62},
                new() {Longitude = 1, Latitude = 90},
                new() {Longitude = 180, Latitude = 1},
                new() {Longitude = 117, Latitude = 62}
            };
            return Task.FromResult(address == "Первомайская ул., 85, Сыктывкар, Респ. Коми, 167000"
                ? coordinatesPool[0]
                : coordinatesPool[1]);
        }
    }
}