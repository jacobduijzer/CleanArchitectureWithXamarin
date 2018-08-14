using System;
using System.Linq.Expressions;
using AppShop.Domain.Catalog.Entities;
using LinqBuilder;

namespace AppShop.Application.Catalog.Specifications
{
    public class CatalogItemsByBrand : QuerySpecification<CatalogItem>
    {
        private readonly int _id;

        public CatalogItemsByBrand(int id)
        {
            _id = id;
        }

        public override Expression<Func<CatalogItem, bool>> AsExpression()
        => item => item.CatalogBrandId == _id;

        public static CatalogItemsByBrand WithBrandId(int id) => new CatalogItemsByBrand(id);
    }
}
