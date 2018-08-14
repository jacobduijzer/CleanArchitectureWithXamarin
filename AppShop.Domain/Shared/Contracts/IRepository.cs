using System.Collections.Generic;
using AppShop.Domain.Shared.Entities;
using LinqBuilder.Core;

namespace AppShop.Domain.Shared.Contracts
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(int id);

        T GetSingleBySpec(ISpecification<T> spec);

        IEnumerable<T> ListAll();

        IEnumerable<T> List(ISpecification<T> spec);

        T Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
