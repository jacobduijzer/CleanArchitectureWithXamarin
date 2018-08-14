using AppShop.Domain.Catalog.Entities;
using AppShop.Tests.Helpers;
using FluentAssertions;
using Xunit;

namespace AppShop.Tests.Domain.Catalog.Entities
{
    public class CatalogBrandShould : IClassFixture<CustomTestFixture>
    {
        private readonly CustomTestFixture _fixture;

        public CatalogBrandShould(CustomTestFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Construct()
        {
            var catalogBrand = new CatalogBrand();
            catalogBrand.Should()
                        .BeOfType<CatalogBrand>();
        }
    }
}
