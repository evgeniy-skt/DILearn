using System;
using System.Threading.Tasks;

namespace DILearn
{
    public class GoogleMapsClient : IMapsClient
    {
        public Task<Coordinates> GetAddressCoordinates(string address)
        {
            // А тут у нас поднимается HttpClient, ему прокидывается токен, и мы идём в гугл карты
            // Само собой за деньги
            throw new NotImplementedException();
        }
        
    }
}