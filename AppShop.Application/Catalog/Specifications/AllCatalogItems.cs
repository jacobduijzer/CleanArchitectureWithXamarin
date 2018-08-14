using System;
using System.Linq.Expressions;
using AppShop.Domain.Catalog.Entities;
using LinqBuilder;

namespace AppShop.Application.Catalog.Specifications
{
    public class AllCatalogItems : QuerySpecification<CatalogItem>
    {
        public override Expression<Func<CatalogItem, bool>> AsExpression()
        => item => true;
    }
}
