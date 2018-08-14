using System;
using MediatR;

namespace AppShop.Application.Catalog.UseCases
{
    public class CatalogBrandsQuery : IRequest<CatalogBrands>
    {
        public CatalogBrandsQuery()
        {
        }
    }
}
