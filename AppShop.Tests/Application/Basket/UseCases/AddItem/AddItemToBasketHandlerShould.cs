using AppShop.Application.Basket.UseCases.AddItem;
using AppShop.Tests.Helpers;
using FluentAssertions;
using Xunit;

namespace AppShop.Tests.Application.Basket.UseCases
{
    public class AddItemToBasketHandlerShould : IClassFixture<CustomTestFixture>
    {
        private readonly CustomTestFixture _fixture;

        public AddItemToBasketHandlerShould(CustomTestFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Construct()
        {
            var handler = new AddItemToBasketHandler(_fixture.MockBasketService.Object);
            handler.Should()
                   .BeOfType<AddItemToBasketHandler>();
        }
    }
}
