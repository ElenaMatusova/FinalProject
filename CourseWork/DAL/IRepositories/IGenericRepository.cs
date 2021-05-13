using CourseWork.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CourseWork.DAL.IRepositories
{
    public interface IGenericRepository<T> where T : Entity
    {
        Task<T> GetById(int id); 
        Task<IEnumerable<T>> GetAll();
        Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate);
        void Create(T obj);
        void Update(T obj);
        void Delete(int id);
        Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate);
        Task<int> CountAll();
        Task<int> CountWhere(Expression<Func<T, bool>> predicate);

    }
}
