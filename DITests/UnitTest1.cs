using System.Threading.Tasks;
using DILearn;
using Xunit;

namespace DITests
{
    public class UnitTest1
    {
        private static IMapsClient _mapsClient;
        private static DeliveryService _deliveryService;

        public UnitTest1()
        {
            _mapsClient = new MapsClientMock();
        }

        [Fact]
        public async Task ShouldReturnNear()
        {
            _deliveryService = new DeliveryService(_mapsClient);

            var estimation = DeliveryService.EstimateDistance("Первомайская ул., 85, Сыктывкар, Респ. Коми, 167000",
                "ул. Куратова, 53, Сыктывкар, Респ. Коми, 167982");
            Assert.Equal(DistanceEstimation.Near, estimation.Result);
        }
    }
}