using System.Threading.Tasks;

namespace DILearn
{
    public interface IMapsClient
    {
        Task<Coordinates> GetAddressCoordinates(string address);
    }
}