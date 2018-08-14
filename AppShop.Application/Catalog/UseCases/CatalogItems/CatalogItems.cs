using System.Collections.Generic;
using AppShop.Domain.Catalog.Entities;

namespace AppShop.Application.Catalog.UseCases
{
    public class CatalogItems
    {
        public bool Success { get; private set; }

        public List<CatalogItem> Items { get; private set; }

        public CatalogItems(bool success)
        {
            Success = success;
        }

        public CatalogItems(bool success, List<CatalogItem> items) : this(success)
        {
            Items = items;
        }
    }
}
