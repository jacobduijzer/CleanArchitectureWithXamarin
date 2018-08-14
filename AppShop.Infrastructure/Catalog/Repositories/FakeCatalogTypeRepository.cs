using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AppShop.Domain.Catalog.Entities;
using AppShop.Domain.Shared.Contracts;
using LinqBuilder.Core;

namespace AppShop.Infrastructure.Catalog.Repositories
{
    public class FakeCatalogTypeRepository : IAsyncRepository<CatalogType>
    {
        private readonly List<CatalogType> _items;

        public FakeCatalogTypeRepository() => _items = MockData.MockDataHelper.CatalogTypes;

        public Task<CatalogType> AddAsync(CatalogType entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(CatalogType entity)
        {
            throw new NotImplementedException();
        }

        public Task<CatalogType> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CatalogType>> ListAllAsync() => await Task.FromResult(_items).ConfigureAwait(false);

        public Task<List<CatalogType>> ListAsync(ISpecification<CatalogType> spec)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(CatalogType entity)
        {
            throw new NotImplementedException();
        }
    }
}
