using System;
using AppShop.Domain.Basket.Entities;
using AppShop.Domain.Catalog.Entities;
using AppShop.Domain.Shared.Contracts;
using Moq;
using AppShop.Domain.Basket.Contracts;

namespace AppShop.Tests.Helpers
{
    public class CustomTestFixture : IDisposable
    {
        internal readonly Mock<IAsyncRepository<CatalogBrand>> MockCatalogBrandsRepository;
        internal readonly Mock<IAsyncRepository<CatalogItem>> MockCatalogItemsRepository;
        internal readonly Mock<IAsyncRepository<CatalogType>> MockCatalogTypesRepository;

        internal readonly Mock<IAsyncRepository<Basket>> MockBasketRepository;

        internal readonly Mock<IBasketService> MockBasketService;

        public CustomTestFixture()
        {
            MockCatalogBrandsRepository = new Mock<IAsyncRepository<CatalogBrand>>();
            MockCatalogItemsRepository = new Mock<IAsyncRepository<CatalogItem>>();
            MockCatalogTypesRepository = new Mock<IAsyncRepository<CatalogType>>();

            MockBasketRepository = new Mock<IAsyncRepository<Basket>>();

            MockBasketService = new Mock<IBasketService>();
        }

        public void Dispose()
        {
            
        }
    }
}
