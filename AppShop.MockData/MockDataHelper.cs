using System.Collections.Generic;
using AppShop.Domain.Catalog.Entities;

namespace AppShop.MockData
{
    public static class MockDataHelper
    {
        public static List<CatalogItem> CatalogItems => new List<CatalogItem>()
        {
            new CatalogItem() { Id = 1, CatalogTypeId=2, CatalogBrandId=2, Description = ".NET Bot Black Sweatshirt", Name = ".NET Bot Black Sweatshirt", Price = 19.5M, PictureUri = "item1.png" },
            new CatalogItem() { Id = 2, CatalogTypeId=1, CatalogBrandId=2, Description = ".NET Black & White Mug", Name = ".NET Black & White Mug", Price= 8.50M, PictureUri = "item2.png" },
            new CatalogItem() { Id = 3, CatalogTypeId=2, CatalogBrandId=5, Description = "Prism White T-Shirt", Name = "Prism White T-Shirt", Price = 12, PictureUri = "item3.png" },
            new CatalogItem() { Id = 4, CatalogTypeId=2, CatalogBrandId=2, Description = ".NET Foundation Sweatshirt", Name = ".NET Foundation Sweatshirt", Price = 12, PictureUri = "item4.png" },
            new CatalogItem() { Id = 5, CatalogTypeId=3, CatalogBrandId=5, Description = "Roslyn Red Sheet", Name = "Roslyn Red Sheet", Price = 8.5M, PictureUri = "item5.png" },
            new CatalogItem() { Id = 6, CatalogTypeId=2, CatalogBrandId=2, Description = ".NET Blue Sweatshirt", Name = ".NET Blue Sweatshirt", Price = 12, PictureUri = "item6.png" },
            new CatalogItem() { Id = 7, CatalogTypeId=2, CatalogBrandId=5, Description = "Roslyn Red T-Shirt", Name = "Roslyn Red T-Shirt", Price = 12, PictureUri = "item7.png"  },
            new CatalogItem() { Id = 8, CatalogTypeId=2, CatalogBrandId=5, Description = "Kudu Purple Sweatshirt", Name = "Kudu Purple Sweatshirt", Price = 8.5M, PictureUri = "item8.png" },
            new CatalogItem() { Id = 9, CatalogTypeId=1, CatalogBrandId=5, Description = "Cup<T> White Mug", Name = "Cup<T> White Mug", Price = 12, PictureUri = "item9.png" },
            new CatalogItem() { Id = 10, CatalogTypeId=3, CatalogBrandId=2, Description = ".NET Foundation Sheet", Name = ".NET Foundation Sheet", Price = 12, PictureUri = "item10.png" },
            new CatalogItem() { Id = 11, CatalogTypeId=3, CatalogBrandId=2, Description = "Cup<T> Sheet", Name = "Cup<T> Sheet", Price = 8.5M, PictureUri = "item11.png" },
            new CatalogItem() { Id = 12, CatalogTypeId=2, CatalogBrandId=5, Description = "Prism White TShirt", Name = "Prism White TShirt", Price = 12, PictureUri = "item12.png" }
        };

        public static List<CatalogType> CatalogTypes => new List<CatalogType>
        {
            new CatalogType() { Id = 1, Type = "Mug"},
            new CatalogType() { Id = 2, Type = "T-Shirt" },
            new CatalogType() { Id = 3, Type = "Sheet" },
            new CatalogType() { Id = 4, Type = "USB Memory Stick" }
        };

        public static List<CatalogBrand> CatalogBrands => new List<CatalogBrand>
        {
            new CatalogBrand() { Id = 1, Brand = "Azure"},
            new CatalogBrand() { Id = 2, Brand = ".NET" },
            new CatalogBrand() { Id = 3, Brand = "Visual Studio" },
            new CatalogBrand() { Id = 4, Brand = "SQL Server" },
            new CatalogBrand() { Id = 5, Brand = "Other" }
        };
    }
}
