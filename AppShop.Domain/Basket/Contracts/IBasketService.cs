using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppShop.Domain.Basket.Contracts
{
    public interface IBasketService
    {
        Task<int> GetBasketItemCountAsync();

        Task TransferBasketAsync(string anonymousId, string userName);

        Task AddItemToBasket(int basketId, int catalogItemId, decimal price, int quantity);

        Task SetQuantities(int basketId, Dictionary<string, int> quantities);

        Task DeleteBasketAsync(int basketId);
    }
}
