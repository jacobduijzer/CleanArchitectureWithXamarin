using System;
using AppShop.Domain.Basket.Contracts;
using AppShop.Domain.Basket.Entities;
using AppShop.Domain.Basket.Services;
using AppShop.Domain.Catalog.Entities;
using AppShop.Domain.Shared.Contracts;
using AppShop.Infrastructure.Basket.Repositories;
using AppShop.Infrastructure.Catalog.Repositories;
using MediatR;
using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.Localization;
using MvvmCross.ViewModels;
using XamarinApp.Core.Helpers;
using XamarinApp.Core.ViewModels;

namespace XamarinApp.Core
{
    public class CoreApp : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            Mvx.IoCProvider.RegisterSingleton<IMvxTextProvider>(new TextProviderBuilder().TextProvider);

            Mvx.IoCProvider.RegisterSingleton<IAsyncRepository<CatalogBrand>>(new FakeCatalogBrandRepository());
            Mvx.IoCProvider.RegisterSingleton<IAsyncRepository<CatalogItem>>(new FakeCatalogItemRepository());
            Mvx.IoCProvider.RegisterSingleton<IAsyncRepository<CatalogType>>(new FakeCatalogTypeRepository());
            Mvx.IoCProvider.RegisterSingleton<IAsyncRepository<Basket>>(new FakeBasketRepository());

            Mvx.IoCProvider.ConstructAndRegisterSingleton<IBasketService, BasketService>();

            SetupMediatR();

            RegisterAppStart<StartViewModel>();
        }

        private void SetupMediatR()
        {
            typeof(AppShop.Application.Catalog.UseCases.CatalogItemsHandler)
                .Assembly
                .CreatableTypes()
                .EndingWith("Handler")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            Mvx.IoCProvider.RegisterSingleton<ServiceFactory>((Type serviceType) =>
            {
                var resolver = Mvx.IoCProvider.Resolve<IMvxIoCProvider>();

                if(resolver.CanResolve(serviceType))
                    return resolver.Resolve(serviceType);

                return Array.CreateInstance(serviceType.GenericTypeArguments[0], 0);
            });

            Mvx.IoCProvider.LazyConstructAndRegisterSingleton<IMediator, Mediator>();

        }
    }
}
