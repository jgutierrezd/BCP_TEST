using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MODEL = BCP.Test.Api.Models.Prefer;

namespace BCP.Test.Api.Services
{
    public interface IPreferService
    {
        Task<MODEL> Create(MODEL _object);

        Task<MODEL> GetById(int Id);

        Task<MODEL> Delete(MODEL _object);

        Task<MODEL> Update(MODEL _object);
    }
}
