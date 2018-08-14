using AppShop.Application.Basket.UseCases.ItemCount;
using AppShop.Tests.Helpers;
using FluentAssertions;
using Xunit;

namespace AppShop.Tests.Application.Basket.UseCases.ItemCount
{
    public class CountItemsShould : IClassFixture<CustomTestFixture>
    {
        private readonly CustomTestFixture _fixture;

        public CountItemsShould(CustomTestFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Construct()
        {
            var request = new CountItems();
            request.Should()
                   .BeOfType<CountItems>();
        }
    }
}
