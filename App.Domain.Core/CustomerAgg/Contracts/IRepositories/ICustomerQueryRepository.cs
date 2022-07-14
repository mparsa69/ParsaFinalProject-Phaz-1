using App.Domain.Core.CustomerAgg.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.CustomerAgg.Contracts.IRepositories
{
    public interface ICustomerQueryRepository
    {
        Task<List<Customer>>? GetAllAsync();
        List<Customer>? GetAll();
        Task<Customer>? Get(int id);
        Task<Customer>? Get(string name);
    }
}
