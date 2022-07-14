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
    public class CustomerCommandRepository : ICustomerCommandRepository
    {
        private readonly AppDbContext _dbConext;
        public CustomerCommandRepository(AppDbContext dbConext)
        {
            _dbConext = dbConext;
        }
        public async Task Add(Customer model)
        {
            await _dbConext.Customers.AddAsync(model);
            await _dbConext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var record = await _dbConext.Customers.SingleOrDefaultAsync(x => x.Id == id);
            _dbConext.Remove(record!);
            await _dbConext.SaveChangesAsync();
        }

        public async Task Update(Customer model)
        {
            var record = await _dbConext.Customers.SingleOrDefaultAsync(x => x.Id == model.Id);
            _dbConext.Customers.Update(model);
            await _dbConext.SaveChangesAsync();
        }
    }
}
