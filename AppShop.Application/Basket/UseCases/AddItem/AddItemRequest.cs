using MediatR;

namespace AppShop.Application.Basket.UseCases.AddItem
{
    public class AddItemRequest : IRequest
    {
        public int CatalogItemId { get; internal set; }

        public decimal ItemPrice { get; internal set; }

        public int Quantity { get; internal set; }


        public AddItemRequest(int catalogItemId, decimal price, int quantity = 1)
        {
            CatalogItemId = catalogItemId;
            ItemPrice = price;
            Quantity = quantity;
        }
    }
}
