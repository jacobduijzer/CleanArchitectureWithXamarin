using MediatR;

namespace AppShop.Application.Basket.UseCases.ItemCount
{
    public class CountItems : IRequest<CountedItems>
    {
    }
}
