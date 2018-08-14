using AppShop.Application.Basket.UseCases.ItemCount;
using AppShop.Tests.Helpers;
using FluentAssertions;
using Xunit;

namespace AppShop.Tests.Application.Basket.UseCases.ItemCount
{
    public class CountedItemsShould : IClassFixture<CustomTestFixture>
    {
        private readonly CustomTestFixture _fixture;

        public CountedItemsShould(CustomTestFixture fixture)
        {
            _fixture = fixture;
        }

        public void ConstructWithCount()
        {
            var response = new CountedItems(5);
            response.Should()
                    .BeOfType<CountedItems>();

            response.Count
                    .Should()
                    .Be(5);
        }

    }
}
