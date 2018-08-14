using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppShop.Application.Basket.UseCases.AddItem;
using AppShop.Application.Basket.UseCases.ItemCount;
using AppShop.Application.Catalog.Specifications;
using AppShop.Application.Catalog.UseCases;
using AppShop.Domain.Catalog.Entities;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using XamarinApp.Core.Models;

namespace XamarinApp.Core.ViewModels
{
    public class StartViewModel : BaseViewModel
    {
        public StartViewModel()
        {
        }

        public override Task Initialize()
        {
            MvxNotifyTask.Create(GetCatalogDataAsync);

            return base.Initialize();
        }

        public IMvxAsyncCommand ApplyFiltersCommand => new MvxAsyncCommand(GetCatalogItemsAsync);

        public IMvxAsyncCommand<CatalogItem> AddCatalogItemToBasketCommand
        => new MvxAsyncCommand<CatalogItem>((CatalogItem catalogItem) => DoAddCatalogItemToBasketAsync(catalogItem));

        #region Properties

        private List<CatalogBrand> _brands = new List<CatalogBrand>();
        public List<CatalogBrand> Brands
        {
            get => _brands;
            private set => SetProperty(ref _brands, value);
        }

        private List<CatalogType> _types = new List<CatalogType>();
        public List<CatalogType> Types
        {
            get => _types;
            private set => SetProperty(ref _types, value);
        }

        private List<PresentableCatalogItem> _catalogItems;
        public List<PresentableCatalogItem> CatalogItems
        {
            get => _catalogItems;
            private set => SetProperty(ref _catalogItems, value);
        }

        private CatalogBrand _selectedBrand;
        public CatalogBrand SelectedBrand
        {
            get => _selectedBrand;
            set => SetProperty(ref _selectedBrand, value);
        }

        private CatalogType _selectedType;
        public CatalogType SelectedType
        {
            get => _selectedType;
            set => SetProperty(ref _selectedType, value);
        }

        private int _badgeCount;
        public int BadgeCount
        {
            get => _badgeCount;
            private set => SetProperty(ref _badgeCount, value);
        }

        #endregion

        #region Getting Data

        private async Task GetCatalogDataAsync()
        {
            await GetCatalogBrandsAsync().ConfigureAwait(false);
            await GetCatalogTypesAsync().ConfigureAwait(false);
            await GetCatalogItemsAsync().ConfigureAwait(false);
        }

        private async Task GetCatalogBrandsAsync()
        {
            Brands.Add(new CatalogBrand { Id = 0, Brand = "All" });

            var brandItems = await Mediator.Send(new CatalogBrandsQuery())
                                           .ConfigureAwait(false);

            if (brandItems.Success)
                Brands.AddRange(brandItems.Items);

            SelectedBrand = Brands.First();
        }

        private async Task GetCatalogTypesAsync()
        {
            Types.Add(new CatalogType { Id = 0, Type = "All" });

            var typeItems = await Mediator.Send(new CatalogTypesQuery())
                                           .ConfigureAwait(false);

            if (typeItems.Success)
                Types.AddRange(typeItems.Items);

            SelectedType = Types.First();
        }

        private async Task GetCatalogItemsAsync()
        {
            var specification = CatalogItemsFilter.Builder
                                                  .WithTypeId(SelectedType.Id)
                                                  .WithBrandId(SelectedBrand.Id)
                                                  .Build();

            var catalogItems = await Mediator.Send(CatalogItemsQuery.WithSpecification(specification))
                                             .ConfigureAwait(false);

            if (catalogItems.Success && catalogItems.Items != null && catalogItems.Items.Any())
                CatalogItems = catalogItems.Items
                                           .Select(x => new PresentableCatalogItem(x, AddCatalogItemToBasketCommand))
                                           .ToList();
            else
                CatalogItems = new List<PresentableCatalogItem>();
        }

        private async Task DoAddCatalogItemToBasketAsync(CatalogItem catalogItem)
        {
            await Mediator.Send(new AddItemRequest(catalogItem.Id, catalogItem.Price))
                         .ConfigureAwait(false);

            var itemsInBasket = await Mediator.Send(new CountItems())
                                              .ConfigureAwait(false);

            BadgeCount = itemsInBasket.Count;
        }

        #endregion
    }
}

