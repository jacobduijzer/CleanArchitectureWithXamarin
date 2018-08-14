using System.Collections.Generic;
using AppShop.Application.Catalog.UseCases;
using AppShop.Domain.Catalog.Entities;
using AppShop.Tests.Helpers;
using FluentAssertions;
using Xunit;

namespace AppShop.Tests.Application.Catalog.UseCases
{
    public class CatalogTypesShould : IClassFixture<CustomTestFixture>
    {
        private readonly CustomTestFixture _fixture;

        public CatalogTypesShould(CustomTestFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void ConstructWithSuccess()
        {
            var response = new CatalogTypes(true);
            response.Should()
                    .BeOfType<CatalogTypes>();

            response.Success
                    .Should()
                    .BeTrue();
        }

        [Fact]
        public void ConstructWithSuccessAndItems()
        {
            var response = new CatalogTypes(true, new List<CatalogType>());
            response.Should()
                    .BeOfType<CatalogTypes>();

            response.Success
                    .Should()
                    .BeTrue();

            response.Items
                    .Should()
                    .NotBeNull()
                    .And
                    .BeEmpty();
        }
    }
}
