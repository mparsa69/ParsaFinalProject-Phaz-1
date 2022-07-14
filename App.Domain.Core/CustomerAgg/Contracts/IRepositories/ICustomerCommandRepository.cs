using App.Domain.Core.CustomerAgg.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.CustomerAgg.Contracts.IRepositories
{
    public interface ICustomerCommandRepository
    {
        Task Add(Customer model);
        Task Update(Customer model);
        Task Delete(int id);
    }
}
