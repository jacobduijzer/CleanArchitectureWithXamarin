using System;
using AppShop.Application.Catalog.UseCases;
using AppShop.Tests.Helpers;
using FluentAssertions;
using Xunit;
using AppShop.Domain.Catalog.Entities;
using AppShop.Application.Catalog.Specifications;

namespace AppShop.Tests.Application.Catalog.UseCases
{
    public class CatalogItemsQueryShould : IClassFixture<CustomTestFixture>
    {
        private readonly CustomTestFixture _fixture;

        public CatalogItemsQueryShould(CustomTestFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Construct()
        {
            var specification = CatalogItemsFilter.Builder.WithTypeId(1).WithBrandId(1).Build();

            var query = CatalogItemsQuery.WithSpecification(specification);

            query.Should()
                 .BeOfType<CatalogItemsQuery>();
        }


    }
}
