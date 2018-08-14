using AppShop.Domain.Catalog.Entities;
using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace XamarinApp.Core.Models
{
    public class PresentableCatalogItem : MvxNotifyPropertyChanged
    {
        public CatalogItem CatalogItem { get; private set; }

        public IMvxAsyncCommand<CatalogItem> SelectProductCommand { get; private set; }

        public PresentableCatalogItem(CatalogItem catalogItem, IMvxAsyncCommand<CatalogItem> selectProductCommand)
        {
            CatalogItem = catalogItem;
            SelectProductCommand = selectProductCommand;
        }
    }
}
