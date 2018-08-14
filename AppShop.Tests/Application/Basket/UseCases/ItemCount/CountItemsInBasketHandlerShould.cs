using System;
using AppShop.Application.Basket.UseCases.ItemCount;
using AppShop.Tests.Helpers;
using FluentAssertions;
using Xunit;

namespace AppShop.Tests.Application.Basket.UseCases
{
    public class CountItemsInBasketHandlerShould : IClassFixture<CustomTestFixture>
    {
        private readonly CustomTestFixture _fixture;

        public CountItemsInBasketHandlerShould(CustomTestFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Construct()
        {
            var useCase = new CountItemsInBasketHandler(_fixture.MockBasketService.Object);
            useCase.Should()
                   .BeOfType<CountItemsInBasketHandler>();
        }
    }
}