using AppShop.Application.Catalog.UseCases;
using AppShop.Tests.Helpers;
using FluentAssertions;
using Xunit;

namespace AppShop.Tests.Application.Catalog.UseCases
{
    public class CatalogBrandsHandlerShould : IClassFixture<CustomTestFixture>
    {
        private readonly CustomTestFixture _fixture;

        public CatalogBrandsHandlerShould(CustomTestFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Construct()
        {
            var useCase = new CatalogBrandsHandler(_fixture.MockCatalogBrandsRepository.Object);
            useCase.Should()
                   .BeOfType<CatalogBrandsHandler>();
        }

    }
}
