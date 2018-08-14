using System.Threading;
using System.Threading.Tasks;
using AppShop.Domain.Basket.Contracts;
using MediatR;

namespace AppShop.Application.Basket.UseCases.ItemCount
{
    public class CountItemsInBasketHandler : IRequestHandler<CountItems, CountedItems>
    {
        private readonly IBasketService _basketService;

        public CountItemsInBasketHandler(IBasketService basketService)
        {
            _basketService = basketService;
        }

        public async Task<CountedItems> Handle(CountItems request, CancellationToken cancellationToken)
        {
            var count = await _basketService.GetBasketItemCountAsync()
                               .ConfigureAwait(false);

            return new CountedItems(count);
        }
    }
}
