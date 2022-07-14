using App.Domain.Core.CustomerAgg.Contracts.IRepositories;
using App.Domain.Core.CustomerAgg.Entities;
using App.Infrastructures.Database.SqlServer.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructures.Repositories.EfCore.CustomerRepo
{
    public class CustomerQueryRepository : ICustomerQueryRepository
    {
        private readonly AppDbContext _dbConext;
        public CustomerQueryRepository(AppDbContext dbConext)
        {
            _dbConext = dbConext;
        }

        public async Task<Customer>? Get(int id)
        {
            var customer = await _dbConext.Customers.SingleOrDefaultAsync(x => x.Id == id);
            return customer;
        }

        public async Task<Customer>? Get(string name)
        {
            var customer = await _dbConext.Customers.FirstOrDefaultAsync(x => x.Name.Contains(name));
            return customer;
        }

        public List<Customer>? GetAll()
        {
            var customers = _dbConext.Customers.ToList();
            return customers;
        }

        public async Task<List<Customer>>? GetAllAsync()
        {
            var customers = await _dbConext.Customers.ToListAsync();
            return customers;
        }
    }
}
