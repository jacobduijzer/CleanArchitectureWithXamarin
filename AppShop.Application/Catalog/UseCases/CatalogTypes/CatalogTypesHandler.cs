using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AppShop.Domain.Catalog.Entities;
using AppShop.Domain.Shared.Contracts;
using MediatR;

namespace AppShop.Application.Catalog.UseCases
{
    public class CatalogTypesHandler : IRequestHandler<CatalogTypesQuery, CatalogTypes>
    {
        private readonly IAsyncRepository<CatalogType> _catalogTypesRepository;

        public CatalogTypesHandler(IAsyncRepository<CatalogType> catalogTypesRepository)
        {
            _catalogTypesRepository = catalogTypesRepository;
        }

        public async Task<CatalogTypes> Handle(CatalogTypesQuery request, CancellationToken cancellationToken)
        {
            var items = await _catalogTypesRepository.ListAllAsync()
                                                     .ConfigureAwait(false);

            if (items != null && items.Any())
                return new CatalogTypes(true, items);

            return new CatalogTypes(false);
        }
    }
}
