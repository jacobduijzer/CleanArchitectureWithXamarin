using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AppShop.Domain.Catalog.Entities;
using AppShop.Domain.Shared.Contracts;
using MediatR;

namespace AppShop.Application.Catalog.UseCases
{
    public class CatalogBrandsHandler : IRequestHandler<CatalogBrandsQuery, CatalogBrands>
    {
        private readonly IAsyncRepository<CatalogBrand> _catalogBrandsRepository;

        public CatalogBrandsHandler(IAsyncRepository<CatalogBrand> catalogBrandsRepository)
        {
            _catalogBrandsRepository = catalogBrandsRepository;
        }

        public async Task<CatalogBrands> Handle(CatalogBrandsQuery request, CancellationToken cancellationToken)
        {
            var items = await _catalogBrandsRepository.ListAllAsync()
                                                      .ConfigureAwait(false);

            if (items != null && items.Any())
                return new CatalogBrands(true, items);

            return new CatalogBrands(false);
        }
    }
}
