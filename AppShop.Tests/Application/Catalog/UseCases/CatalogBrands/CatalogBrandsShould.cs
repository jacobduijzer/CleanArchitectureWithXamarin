using System;
using AppShop.Application.Catalog.UseCases;
using AppShop.Tests.Helpers;
using FluentAssertions;
using Xunit;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using AppShop.Domain.Catalog.Entities;

namespace AppShop.Tests.Application.Catalog.UseCases
{
    public class CatalogBrandsShould : IClassFixture<CustomTestFixture>
    {
        private readonly CustomTestFixture _fixture;

        public CatalogBrandsShould(CustomTestFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void ConstructWithSuccess()
        {
            var response = new CatalogBrands(true);
            response.Should()
                    .BeOfType<CatalogBrands>();
        }

        [Fact]
        public void ConstructWithSuccessAndItems()
        {
            var response = new CatalogBrands(true, new List<CatalogBrand>());
            response.Should()
                    .BeOfType<CatalogBrands>();

            response.Items
                    .Should()
                    .NotBeNull()
                    .And
                    .BeEmpty();
        }
    }
}
