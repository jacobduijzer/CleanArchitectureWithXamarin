using System.Collections.Generic;
using AppShop.Application.Catalog.UseCases;
using AppShop.Domain.Catalog.Entities;
using AppShop.Tests.Helpers;
using FluentAssertions;
using Xunit;

namespace AppShop.Tests.Application.Catalog.UseCases
{
    public class CatalogItemsShould : IClassFixture<CustomTestFixture>
    {
        private readonly CustomTestFixture _fixture;

        public CatalogItemsShould(CustomTestFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void ConstructWithSuccess()
        {
            var response = new CatalogItems(true);
            response.Should()
                    .BeOfType<CatalogItems>();
        }

        [Fact]
        public void ConstructWithSuccessAndItems()
        {
            var response = new CatalogItems(true, new List<CatalogItem>());
            response.Should()
                    .BeOfType<CatalogItems>();

            response.Items
                    .Should()
                    .NotBeNull()
                    .And
                    .BeEmpty();
        }

    }
}
