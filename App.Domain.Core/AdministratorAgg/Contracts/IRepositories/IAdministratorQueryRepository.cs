using App.Domain.Core.AdministratorAgg.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.AdministratorAgg.Contracts.IRepositories
{
    public interface IAdministratorQueryRepository
    {
        Task<List<Administrator>>? GetAllAsync();
        List<Administrator>? GetAll();
        Task<Administrator>? Get(int id);
        Task<Administrator>? Get(string name);
    }
}
