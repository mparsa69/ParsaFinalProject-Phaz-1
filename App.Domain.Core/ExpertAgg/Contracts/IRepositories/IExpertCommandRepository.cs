using App.Domain.Core.ExpertAgg.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.ExpertAgg.Contracts.IRepositories
{
    public interface IExpertCommandRepository
    {
        Task Add(Expert model);
        Task Update(Expert model);
        Task Delete(int id);
    }
}
