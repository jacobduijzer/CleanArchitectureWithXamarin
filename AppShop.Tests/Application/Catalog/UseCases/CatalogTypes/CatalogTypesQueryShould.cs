using AppShop.Application.Catalog.UseCases;
using AppShop.Tests.Helpers;
using FluentAssertions;
using Xunit;

namespace AppShop.Tests.Application.Catalog.UseCases
{
    public class CatalogTypesQueryShould : IClassFixture<CustomTestFixture>
    {
        private readonly CustomTestFixture _fixture;

        public CatalogTypesQueryShould(CustomTestFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Construct()
        {
            var query = new CatalogTypesQuery();
            query.Should()
                 .BeOfType<CatalogTypesQuery>();
        }

    }
}
