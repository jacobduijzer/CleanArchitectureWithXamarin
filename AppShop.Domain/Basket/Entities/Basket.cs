using System.Collections.Generic;
using System.Linq;
using AppShop.Domain.Shared.Contracts;
using AppShop.Domain.Shared.Entities;

namespace AppShop.Domain.Basket.Entities
{
    public class Basket : BaseEntity, IAggregateRoot
    {
        public string BuyerId { get; set; }

        private readonly List<BasketItem> _items = new List<BasketItem>();

        public IReadOnlyCollection<BasketItem> Items => _items.AsReadOnly();

        public void AddItem(int catalogItemId, decimal unitPrice, int quantity = 1)
        {
            if (!Items.Any(i => i.CatalogItemId == catalogItemId))
            {
                _items.Add(new BasketItem(catalogItemId, quantity, unitPrice));
                return;
            }

            var existingItem = _items.FirstOrDefault(i => i.CatalogItemId == catalogItemId);
            var index = _items.IndexOf(existingItem);

            _items[index] = new BasketItem(existingItem.CatalogItemId, existingItem.Quantity + 1, existingItem.UnitPrice);
        }
    }
}
