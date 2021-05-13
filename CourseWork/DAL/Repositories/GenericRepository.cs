using CourseWork.DAL.DbContext;
using CourseWork.DAL.IRepositories;
using CourseWork.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CourseWork.DAL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : Entity
    {
        private readonly AppDbContext _context;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }
        public async Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().Where(predicate).ToListAsync();
        }
        public async Task<T> GetById(int id) => await _context.Set<T>().FindAsync(id);
        public async Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate) => 
            await _context.Set<T>().FirstOrDefaultAsync(predicate);
        public void  Create(T entity)
        {
             _context.Set<T>().AddAsync(entity);
        }
        public virtual void Update(T entity)
        {
            _context.Set<T>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(int id)
        {
            T entityToDelete = _context.Set<T>().Find(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(T entityToDelete)
        {
            if (_context.Entry(entityToDelete).State == EntityState.Detached)
            {
                _context.Set<T>().Attach(entityToDelete);
            }
            _context.Set<T>().Remove(entityToDelete);
        }
        public Task<int> CountAll() => _context.Set<T>().CountAsync();
        public Task<int> CountWhere(Expression<Func<T, bool>> predicate) => _context.Set<T>().CountAsync(predicate);
    }
}
