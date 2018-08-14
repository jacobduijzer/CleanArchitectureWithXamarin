using System.Linq;
using AppShop.Domain.Catalog.Entities;
using AppShop.Tests.Helpers;
using FluentAssertions;
using Xunit;

namespace AppShop.Tests.Domain.Basket.Entities
{
    public class BasketShould : IClassFixture<CustomTestFixture>
    {
        private readonly CustomTestFixture _fixture;

        private readonly CatalogItem _fakeProduct;

        public BasketShould(CustomTestFixture fixture)
        {
            _fixture = fixture;

            _fakeProduct = MockData.MockDataHelper.CatalogItems.FirstOrDefault();
        }

        [Fact]
        public void Construct()
        {
            var basket = new AppShop.Domain.Basket.Entities.Basket();
            basket.Should()
                  .BeOfType<AppShop.Domain.Basket.Entities.Basket>();
        }

        [Fact]
        public void AddItem()
        {
            var basket = new AppShop.Domain.Basket.Entities.Basket();

            basket.Items
                  .Should()
                  .NotBeNull()
                  .And
                  .BeEmpty();

            basket.AddItem(_fakeProduct.Id, _fakeProduct.Price);

            basket.Items
                  .Should()
                  .NotBeNullOrEmpty()
                  .And
                  .HaveCount(1);
        }

        [Fact]
        public void UpdateAmountWhenAddingSameItem()
        {
            var basket = new AppShop.Domain.Basket.Entities.Basket();

            basket.Items
                  .Should()
                  .NotBeNull()
                  .And
                  .BeEmpty();
            
            basket.AddItem(_fakeProduct.Id, _fakeProduct.Price);
            basket.AddItem(_fakeProduct.Id, _fakeProduct.Price);

            basket.Items
                  .Should()
                  .NotBeNullOrEmpty()
                  .And
                  .HaveCount(1);

            basket.Items
                  .FirstOrDefault()
                  .Quantity
                  .Should()
                  .Be(2);

            basket.Items
                  .FirstOrDefault()
                  .UnitPrice
                  .Should()
                  .Be(_fakeProduct.Price);
        }
    }
}
