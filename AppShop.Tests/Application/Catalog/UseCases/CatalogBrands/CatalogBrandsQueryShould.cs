using AppShop.Application.Catalog.UseCases;
using AppShop.Tests.Helpers;
using FluentAssertions;
using Xunit;

namespace AppShop.Tests.Application.Catalog.UseCases
{
    public class CatalogBrandsQueryShould : IClassFixture<CustomTestFixture>
    {
        private readonly CustomTestFixture _fixture;

        public CatalogBrandsQueryShould(CustomTestFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Construct()
        {
            var query = new CatalogBrandsQuery();
            query.Should()
                 .BeOfType<CatalogBrandsQuery>();
        }
    }
}
