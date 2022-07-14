using App.Domain.Core.ExpertAgg.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.ExpertAgg.Contracts.IRepositories
{
    public interface IExpertQueryRepository
    {
        Task<List<Expert>>? GetAllAsync();
        List<Expert>? GetAll();
        Task<Expert>? Get(int id);
        Task<Expert>? Get(string name);
    }
}
