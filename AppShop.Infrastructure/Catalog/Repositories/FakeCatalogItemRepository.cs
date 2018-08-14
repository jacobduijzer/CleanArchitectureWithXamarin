using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppShop.Domain.Catalog.Entities;
using AppShop.Domain.Shared.Contracts;
using AppShop.MockData;
using LinqBuilder.Core;

namespace AppShop.Infrastructure.Catalog.Repositories
{
    public class FakeCatalogItemRepository : IAsyncRepository<CatalogItem>
    {
        private readonly List<CatalogItem> _items;

        public FakeCatalogItemRepository()
        {
            _items = MockDataHelper.CatalogItems;
        }

        public async Task<CatalogItem> AddAsync(CatalogItem entity)
        {
            _items.Add(entity);
            return await Task.FromResult(entity).ConfigureAwait(false);
        }

        public async Task DeleteAsync(CatalogItem entity)
        => await Task.FromResult(_items.Remove(entity)).ConfigureAwait(false);

        public async Task<CatalogItem> GetByIdAsync(int id)
        => await Task.FromResult(_items.FirstOrDefault(x => x.Id == id)).ConfigureAwait(false);

        public async Task<List<CatalogItem>> ListAllAsync() => await Task.FromResult(_items);

        public async Task<List<CatalogItem>> ListAsync(ISpecification<CatalogItem> spec) 
        => await Task.FromResult(_items.ExeSpec(spec).ToList()).ConfigureAwait(false);

        public async Task UpdateAsync(CatalogItem entity)
        {
            throw new NotImplementedException();
        }
    }
}
