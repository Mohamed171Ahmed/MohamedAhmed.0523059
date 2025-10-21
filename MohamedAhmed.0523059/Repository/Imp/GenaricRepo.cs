using Microsoft.EntityFrameworkCore;
using MohamedAhmed._0523059.Data;
using MohamedAhmed._0523059.Repository.Interface;

namespace MohamedAhmed._0523059.Repository.Imp
{
    public class GenaricRepo<T> : IgenaricRepo<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _Dbset;

        public GenaricRepo(AppDbContext context)
        {
            _context = context;
            _Dbset = context.Set<T>();
        }

        public async Task Create(T entity)
        {
             await _Dbset.AddAsync(entity);
        }

        public  void Delete( T entity)
        {
              _Dbset.Remove(entity);
        }

        public async Task<IEnumerable<T>> Get()
        {
            return await _Dbset.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _Dbset.FindAsync(id);
        }

        public  void savechanges()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
             _Dbset.Update(entity);
        }
    }
}
