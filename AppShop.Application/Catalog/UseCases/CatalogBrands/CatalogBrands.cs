using System.Collections.Generic;
using AppShop.Domain.Catalog.Entities;

namespace AppShop.Application.Catalog.UseCases
{
    public class CatalogBrands
    {
        public bool Success { get; private set; }

        public List<CatalogBrand> Items { get; private set; }

        public CatalogBrands(bool success)
        {
            Success = success;
        }

        public CatalogBrands(bool success, List<CatalogBrand> items) : this(success)
        {
            Items = items;
        }
    }
}
