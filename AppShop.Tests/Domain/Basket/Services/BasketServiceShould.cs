using AppShop.Domain.Basket.Services;
using AppShop.Tests.Helpers;
using FluentAssertions;
using Xunit;

namespace AppShop.Tests.Domain.Basket.Services
{
    public class BasketServiceShould : IClassFixture<CustomTestFixture>
    {
        private readonly CustomTestFixture _fixture;

        public BasketServiceShould(CustomTestFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Construct()
        {
            var service = new BasketService(_fixture.MockBasketRepository.Object, 
                                            _fixture.MockCatalogItemsRepository.Object);
            service.Should()
                   .BeOfType<BasketService>();
        }
    }
}
