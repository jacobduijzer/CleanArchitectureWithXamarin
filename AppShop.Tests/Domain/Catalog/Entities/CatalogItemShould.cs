using AppShop.Domain.Catalog.Entities;
using AppShop.Tests.Helpers;
using FluentAssertions;
using Xunit;

namespace AppShop.Tests.Domain.Catalog.Entities
{
    public class CatalogItemShould : IClassFixture<CustomTestFixture>
    {
        private readonly CustomTestFixture _fixture;

        public CatalogItemShould(CustomTestFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Construct()
        {
            var catalogItem = new CatalogItem();
            catalogItem.Should()
                       .BeOfType<CatalogItem>();
        }

    }
}
