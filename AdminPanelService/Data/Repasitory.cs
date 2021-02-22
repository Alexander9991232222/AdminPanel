using AdminPanelService.Helpers;
using AdminPanelService.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using AdminPanelService.Extensions;

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

        public async Task<T> QueryToProcedureAsync <T>(
            string procedureName,
            IDictionary<string, object> inParams = null,
            IDictionary<string, string> outParams = null)
        {
            try
            {
                using (DbCommand command = _dbContext.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = procedureName;
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    if(inParams != null || outParams != null)
                    {
                        SqlParameter[] parameters = SqlDataHelper.GetSQLParamsArray(inParams, outParams);
                        command.Parameters.AddRange(parameters);
                    }

                    bool wasOpen = command.Connection.State == System.Data.ConnectionState.Open;
                    if (!wasOpen) command.Connection.Open();

                    return await command.GetResultExecuteScalarAsync<T>();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
      

        }
    }
}
