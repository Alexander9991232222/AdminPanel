using AdminPanelService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanelService.Data
{
    public class Repasitory<T> where T : BaseModel
    {
        private readonly AppDbContext _dbContext;
        private readonly DbSet<T> _db;

        public Repasitory(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _db = dbContext.Set<T>();
        }

        public async Task AddAsync(T obj)
        {
            await _db.AddAsync(obj);
        } 

        public async Task<List<T>> GetListAsync()
        {
            return await _db.ToListAsync<T>();
        } 

        public async Task<T> GetByIdAsync(int id)
        {
            return (await _db.ToListAsync<T>())
                            .FirstOrDefault(x => x.Id == id);
        }

        public void Update(int id, T obj)
        {
            _db.Update(obj);   
        }

        public void Remove(T obj)
        {
            _db.Remove(obj);
        }

        public async Task<bool> SaveChangeAsync()
        {
          return (await _dbContext.SaveChangesAsync()) >= 0;
        }
    }
}
