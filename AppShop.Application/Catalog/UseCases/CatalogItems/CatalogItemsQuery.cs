using AppShop.Domain.Catalog.Entities;
using LinqBuilder.Core;
using MediatR;

namespace AppShop.Application.Catalog.UseCases
{
    public class CatalogItemsQuery : IRequest<CatalogItems>
    {
        public ISpecification<CatalogItem> Specification { get; private set; }

        private CatalogItemsQuery(ISpecification<CatalogItem> specification)
        {
            Specification = specification;
        }

        public static CatalogItemsQuery WithSpecification(ISpecification<CatalogItem> specification)
        => new CatalogItemsQuery(specification);
    }
}
