using BCP.Test.Api.Data;
using BCP.Test.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCP.Test.Api.Services
{
    public class PreferService : IPreferService
    {
        private readonly TestDbContext _dbContext;
        public PreferService(TestDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Prefer> Create(Prefer _object)
        {
            var obj = await _dbContext.Prefers.AddAsync(_object);
            var result = await _dbContext.SaveChangesAsync();
            return result == 1 ? obj.Entity : null;
        }

        public async Task<Prefer> GetById(int Id)
        {
            return await _dbContext.Prefers.FindAsync(Id);
        }

        public Task<Prefer> Delete(Prefer _object)
        {
            throw new NotImplementedException();
        }

        public async Task<Prefer> Update(Prefer _object)
        {
            var obj = _dbContext.Prefers.Update(_object);

            var result = await _dbContext.SaveChangesAsync();
            return result == 1 ? obj.Entity : null;
        }
    }
}
