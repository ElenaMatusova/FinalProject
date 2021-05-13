using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseWork.DAL.Models;

namespace CourseWork.DAL.IRepositories
{
    public interface IUnitOfWork : IDisposable
    {
        //ApplicationUserManager UserManager { get; }
        //ApplicationRoleManager RoleManager { get; }
        IGenericRepository<User> User { get; }
        IGenericRepository<Campain> Campain { get; }
        IGenericRepository<Bonus> Bonus { get; }
        IGenericRepository<Comment> Comment { get; }
        IGenericRepository<Like> Like { get; }
        IGenericRepository<News> News { get; }
        IGenericRepository<PicturesGalary> PicturesGalary { get; }
        IGenericRepository<Tag> Tag { get; }
        IGenericRepository<Transaction> Transaction { get; }
        IGenericRepository<Vote> Vote { get; }
        Task Save();
    }
}
