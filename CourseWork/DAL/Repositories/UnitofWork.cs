using CourseWork.DAL.DbContext;
using CourseWork.DAL.IRepositories;
using CourseWork.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork

    {
        //private ApplicationUserManager userManager;
        //private ApplicationRoleManager roleManager;

        private readonly AppDbContext _context;

        private GenericRepository<Campain> campainRepository;

        private GenericRepository<User> userRepository;

        private GenericRepository<Bonus> bonusRepository;

        private GenericRepository<Comment> commentRepository;

        private GenericRepository<Like> likeRepository;

        private GenericRepository<PicturesGalary> galaryRepository;

        private GenericRepository<News> newsRepository;

        private GenericRepository<Tag> tagRepository;

        private GenericRepository<Transaction> transactRepository;

        private GenericRepository<Vote> voteRepository;
        public UnitOfWork(AppDbContext context) 
        {
            _context = context;
        }
        public IGenericRepository<User> User
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new GenericRepository<User>(_context);
                }
                return userRepository;
            }
        }

        public IGenericRepository<Campain> Campain
        {
            get
            {
                if (campainRepository == null)
                {
                    campainRepository = new GenericRepository<Campain>(_context);
                }
                return campainRepository;
            }
        }
        public IGenericRepository<Bonus> Bonus
        {
            get
            {
                if (bonusRepository == null)
                {
                    bonusRepository = new GenericRepository<Bonus>(_context);
                }
                return bonusRepository;
            }
        }

        public IGenericRepository<Comment> Comment
        {
            get
            { 
                if (commentRepository == null)
                {
                    commentRepository = new GenericRepository<Comment>(_context);
                }
                return commentRepository;
            }
        }

        public IGenericRepository<Like> Like
        {
            get
            {
                if (likeRepository == null)
                {
                    likeRepository = new GenericRepository<Like>(_context);
                }
                return likeRepository;
            }
        }

        public IGenericRepository<News> News
        {
            get
            {
                if (newsRepository == null)
                {
                    newsRepository = new GenericRepository<News>(_context);
                }
                return newsRepository;
            }
        }

        public IGenericRepository<PicturesGalary> PicturesGalary
        {
            get
            {
                if (galaryRepository == null)
                {
                    galaryRepository = new GenericRepository<PicturesGalary>(_context);
                }
                return galaryRepository;
            }
        }

        public IGenericRepository<Tag> Tag
        {
            get
            {
                if (tagRepository == null)
                {
                    tagRepository = new GenericRepository<Tag>(_context);
                }
                return tagRepository;
            }
        }

        public IGenericRepository<Transaction> Transaction
        {
            get
            {
                if (transactRepository == null)
                {
                    transactRepository = new GenericRepository<Transaction>(_context);
                }
                return transactRepository;
            }
        }

        public IGenericRepository<Vote> Vote
        {
            get
            {
                if (voteRepository == null)
                {
                    voteRepository = new GenericRepository<Vote>(_context);
                }
                return voteRepository;
            }
        }
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
