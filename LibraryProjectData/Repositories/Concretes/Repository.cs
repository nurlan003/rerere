using LibraryProject.Data.Contexts;
using LibraryProject.Data.Repositories.Abstracts;
using LibraryProject.Models.Entities.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Data.Repositories.Concretes
{
    public class Repository<T> : IRepository<T> where T : BaseEntity, new()
    {
        private readonly LibraryDbContext _context;
        private readonly DbSet<T> _dbset;

        public Repository()
        {
            _context = new LibraryDbContext();
            _dbset = _context.Set<T>();
        }

        public void Add(T entity)
        {
            if (entity == null) throw new ArgumentNullException("Data is null");
            _dbset.Add(entity);
        }

        public void AddRange(ICollection<T> entities)
        {
            if (_dbset == null|| entities.Count==0) throw new ArgumentNullException("Data is null");
            _dbset.AddRange(entities);
        }

        public ICollection<T> GetAll()
        {
            return _dbset.ToList();
        }

        public T GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
        }

        public void SaveChange()
        {
        }

        public void Update(T entity)
        {
        }
    }
}
