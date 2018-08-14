using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AppShop.Domain.Catalog.Entities;
using AppShop.Domain.Shared.Contracts;
using MediatR;

namespace AppShop.Application.Catalog.UseCases
{
    public class CatalogItemsHandler : IRequestHandler<CatalogItemsQuery, CatalogItems>
    {
        private readonly IAsyncRepository<CatalogItem> _catalogItemRepository;

        public CatalogItemsHandler(IAsyncRepository<CatalogItem> catalogItemRepository)
        {
            _catalogItemRepository = catalogItemRepository;
        }

        public async Task<CatalogItems> Handle(CatalogItemsQuery request, CancellationToken cancellationToken)
        {
            var items = await _catalogItemRepository.ListAsync(request.Specification)
                                                    .ConfigureAwait(false);
            
            if (items != null && items.Any())
                return new CatalogItems(true, items);

            return new CatalogItems(false);
        }
    }
}
