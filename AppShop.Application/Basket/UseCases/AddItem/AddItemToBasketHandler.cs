using System.Threading;
using System.Threading.Tasks;
using AppShop.Domain.Basket.Contracts;
using MediatR;

namespace AppShop.Application.Basket.UseCases.AddItem
{
    public class AddItemToBasketHandler : AsyncRequestHandler<AddItemRequest>
    {
        private readonly IBasketService _basketService;

        public AddItemToBasketHandler(IBasketService basketService)
        {
            _basketService = basketService;
        }

        protected override async Task Handle(AddItemRequest request, CancellationToken cancellationToken)
        {
            await _basketService.AddItemToBasket(1, request.CatalogItemId, request.ItemPrice, request.Quantity)
                                .ConfigureAwait(false);
        }
    }
}