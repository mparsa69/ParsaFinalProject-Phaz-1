using App.Domain.Core.AdministratorAgg.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.AdministratorAgg.Contracts.IRepositories
{
    public interface IAdministratorCommandRepository
    {
        Task Add(Administrator model);
        Task Update(Administrator model);
        Task Delete(int id);
    }
}
