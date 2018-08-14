using AppShop.Domain.Shared.Entities;

namespace AppShop.Domain.Basket.Entities
{
    public class BasketItem : BaseEntity
    {
        public decimal UnitPrice { get; private set; }

        public int Quantity { get; private set; }

        public int CatalogItemId { get; private set; }

        public BasketItem(int catalogItemId, int quantity, decimal unitPrice)
        {
            CatalogItemId = catalogItemId;

            Quantity = quantity;

            UnitPrice = unitPrice;
        }
    }
}
