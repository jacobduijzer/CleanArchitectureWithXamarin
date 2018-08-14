using System;
using System.Linq.Expressions;
using AppShop.Domain.Catalog.Entities;
using LinqBuilder;

namespace AppShop.Application.Catalog.Specifications
{
    public class CatalogItemsFilter : QuerySpecification<CatalogItem>
    {
        public int BrandId { get; internal set; }

        public int TypeId { get; internal set; }

        private CatalogItemsFilter()
        {
        }

        public override Expression<Func<CatalogItem, bool>> AsExpression()
        {
            if (BrandId == 0 && TypeId == 0)
                return item => true;
            else if(BrandId > 0)
                return item => item.CatalogBrandId == BrandId;
            else if(TypeId > 0)
                return item => item.CatalogTypeId == TypeId;

            throw new Exception("AsExpression shouldn't reach here");
        }

        #region Builder

        public static CatalogItemsFilterBuilder Builder => new CatalogItemsFilterBuilder();

        public class CatalogItemsFilterBuilder
        {
            private int _brandId;

            private int _typeId;

            public CatalogItemsFilterBuilder WithBrandId(int brandId)
            {
                _brandId = brandId;
                return this;
            }

            public CatalogItemsFilterBuilder WithTypeId(int typeId)
            {
                _typeId = typeId;
                return this;
            }

            public CatalogItemsFilter Build()
            {
                return new CatalogItemsFilter
                {
                    BrandId = _brandId,
                    TypeId = _typeId
                };
            }
        }

        #endregion
    }
}