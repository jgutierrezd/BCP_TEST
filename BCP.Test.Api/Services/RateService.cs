using BCP.Test.Api.Data;
using BCP.Test.Api.Models;
using System;
using System.Threading.Tasks;

namespace BCP.Test.Api.Services
{
    public class RateService : IRateService
    {
        private readonly TestDbContext _dbContext;
        public RateService(TestDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Rate> Create(Rate _object)
        {
            var obj = await _dbContext.Rates.AddAsync(_object);
            var result = await _dbContext.SaveChangesAsync();
            return result == 1 ? obj.Entity : null;
        }

        public async Task<Rate> GetById(int Id)
        {
            return await _dbContext.Rates.FindAsync(Id);
        }

        public Task<Rate> Delete(Rate _object)
        {
            throw new NotImplementedException();
        }

        public async Task<Rate> Update(Rate _object)
        {
            var obj = _dbContext.Rates.Update(_object);

            var result = await _dbContext.SaveChangesAsync();
            return result == 1 ? obj.Entity : null;
        }
    }
}
