using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AppShop.Domain.Catalog.Entities;
using AppShop.Domain.Shared.Contracts;
using LinqBuilder.Core;

namespace AppShop.Infrastructure.Catalog.Repositories
{
    public class FakeCatalogBrandRepository : IAsyncRepository<CatalogBrand>
    {
        private readonly List<CatalogBrand> _brands;

        public FakeCatalogBrandRepository() => _brands = MockData.MockDataHelper.CatalogBrands;    

        public Task<CatalogBrand> AddAsync(CatalogBrand entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(CatalogBrand entity)
        {
            throw new NotImplementedException();
        }

        public Task<CatalogBrand> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CatalogBrand>> ListAllAsync() 
        => await Task.FromResult(_brands).ConfigureAwait(false);

        public Task<List<CatalogBrand>> ListAsync(ISpecification<CatalogBrand> spec)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(CatalogBrand entity)
        {
            throw new NotImplementedException();
        }
    }
}
