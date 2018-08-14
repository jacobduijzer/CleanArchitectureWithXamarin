using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppShop.Domain.Shared.Contracts;
using LinqBuilder.Core;
using LinqBuilder;

namespace AppShop.Infrastructure.Basket.Repositories
{
    public class FakeBasketRepository : IAsyncRepository<Domain.Basket.Entities.Basket>
    {
        private readonly List<Domain.Basket.Entities.Basket> _baskets;

        public FakeBasketRepository()
        {
            _baskets = new List<Domain.Basket.Entities.Basket>();
        }

        public async Task<Domain.Basket.Entities.Basket> AddAsync(Domain.Basket.Entities.Basket entity)
        {
            //TODO!!!
            entity.Id = 1;

            _baskets.Add(entity);

            return await Task.FromResult(entity).ConfigureAwait(false);
        }

        public async Task DeleteAsync(Domain.Basket.Entities.Basket entity)
        => await Task.FromResult(_baskets.Remove(entity)).ConfigureAwait(false);

        public async Task<Domain.Basket.Entities.Basket> GetByIdAsync(int id)
        => await Task.FromResult(_baskets.FirstOrDefault(x => x.Id == id)).ConfigureAwait(false);

        public Task<List<Domain.Basket.Entities.Basket>> ListAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Domain.Basket.Entities.Basket>> ListAsync(ISpecification<Domain.Basket.Entities.Basket> spec)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Domain.Basket.Entities.Basket entity)
        {
            var index = _baskets.IndexOf(_baskets.FirstOrDefault(x => x.Id == entity.Id));

            if (index > -1)
                _baskets[index] = entity;
            else
                _baskets.Add(entity);


            await Task.FromResult(true);
        }
    }
}
