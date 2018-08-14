using System.Collections.Generic;
using AppShop.Domain.Catalog.Entities;

namespace AppShop.Application.Catalog.UseCases
{
    public class CatalogTypes
    {
        public bool Success { get; private set; }

        public List<CatalogType> Items { get; private set; }

        public CatalogTypes(bool success)
        {
            Success = success;
        }

        public CatalogTypes(bool success, List<CatalogType> items) : this(success)
        {
            Items = items;
        }
    }
}
