using System;
using AppShop.Application.Catalog.UseCases;
using AppShop.Tests.Helpers;
using FluentAssertions;
using Xunit;

namespace AppShop.Tests.Application.Catalog.UseCases
{
    public class CatalogTypesHandlerShould : IClassFixture<CustomTestFixture>
    {
        private readonly CustomTestFixture _fixture;

        public CatalogTypesHandlerShould(CustomTestFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Construct()
        {
            var useCase = new CatalogTypesHandler(_fixture.MockCatalogTypesRepository.Object);
            useCase.Should()
                   .BeOfType<CatalogTypesHandler>();
        }

    }
}
