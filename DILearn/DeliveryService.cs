using System.Threading.Tasks;

namespace DILearn
{
    public class DeliveryService
    {
        private static IMapsClient _mapsClient;

        public DeliveryService(IMapsClient mapsClient)
        {
            _mapsClient = mapsClient;
        }

        // "Прикинуть" расстояние между адресом пиццерии и клиента
        public static async Task<DistanceEstimation> EstimateDistance(string pizzeriaAddress,
            string customerAddress)
        {
            var pizzeriaCoordinates = await _mapsClient.GetAddressCoordinates(pizzeriaAddress);
            var customerCoordinates = await _mapsClient.GetAddressCoordinates(customerAddress);
            return Coordinates.RawDistanceTo(customerCoordinates) switch
            {
                // Меньше 3 км - рядом
                <= 3 => DistanceEstimation.Near,
                // от 3 до 10 км - далековато
                <= 10 => DistanceEstimation.SomewhatFar,
                // больше 10 км - очень далеко
                _ => DistanceEstimation.VeryFar
            };
        }
    }
}