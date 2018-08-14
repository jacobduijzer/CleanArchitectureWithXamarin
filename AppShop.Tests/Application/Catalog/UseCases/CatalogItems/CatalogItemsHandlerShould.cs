using AppShop.Application.Catalog.UseCases;
using AppShop.Tests.Helpers;
using FluentAssertions;
using Xunit;

namespace AppShop.Tests.Application.Catalog.UseCases
{
    public class CatalogItemsHandlerShould : IClassFixture<CustomTestFixture>
    {
        private readonly CustomTestFixture _fixture;

        public CatalogItemsHandlerShould(CustomTestFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Construct()
        {
            var useCase = new CatalogItemsHandler(_fixture.MockCatalogItemsRepository.Object);
            useCase.Should()
                   .BeOfType<CatalogItemsHandler>();
        }

    }
}
