using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AppShop.Domain.Basket.Contracts;
using AppShop.Domain.Catalog.Entities;
using AppShop.Domain.Shared.Contracts;
using System.Linq;

namespace AppShop.Domain.Basket.Services
{
    public class BasketService : IBasketService
    {
        private readonly IAsyncRepository<Entities.Basket> _basketRepository;

        private readonly IAsyncRepository<CatalogItem> _itemRepository;

        public BasketService(IAsyncRepository<Entities.Basket> basketRepository, IAsyncRepository<CatalogItem> itemRepository)
        {
            _basketRepository = basketRepository;
            _itemRepository = itemRepository;
        }

        public async Task AddItemToBasket(int basketId, int catalogItemId, decimal price, int quantity)
        {
            var basket = await _basketRepository.GetByIdAsync(basketId)
                                                .ConfigureAwait(false);

            // TODO: basketId
            if (basket == null)
                basket = new Entities.Basket { Id = 1 };

            basket.AddItem(catalogItemId, price, quantity);

            await _basketRepository.UpdateAsync(basket)
                                   .ConfigureAwait(false);
        }

        public async Task DeleteBasketAsync(int basketId)
        {
            var basket = await _basketRepository.GetByIdAsync(basketId)
                                                .ConfigureAwait(false);

            await _basketRepository.DeleteAsync(basket)
                                   .ConfigureAwait(false);
        }

        public async Task<int> GetBasketItemCountAsync()
        {
            var basket = await _basketRepository.GetByIdAsync(1)
                                                .ConfigureAwait(false);

            return basket.Items.Sum(x => x.Quantity);
        }

        public Task SetQuantities(int basketId, Dictionary<string, int> quantities)
        {
            throw new NotImplementedException();
        }

        public Task TransferBasketAsync(string anonymousId, string userName)
        {
            throw new NotImplementedException();
        }
    }
}
