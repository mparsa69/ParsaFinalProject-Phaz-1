using App.Domain.Core.AdministratorAgg.Entities;
using App.Infrastructures.Database.SqlServer.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructures.Repositories.EfCore.AdministratorRepo
{
    public class AdministratorCommandRepository
    {
        private readonly AppDbContext _dbConext;
        public AdministratorCommandRepository(AppDbContext dbConext)
        {
            _dbConext = dbConext;
        }
        public async Task Add(Administrator model)
        {
            await _dbConext.Administrators.AddAsync(model);
            await _dbConext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var record = await _dbConext.Administrators.SingleOrDefaultAsync(x => x.Id == id);
            _dbConext.Remove(record!);
            await _dbConext.SaveChangesAsync();
        }

        public async Task Update(Administrator model)
        {
            var record = await _dbConext.Administrators.SingleOrDefaultAsync(x => x.Id == model.Id);
            _dbConext.Administrators.Update(model);
            await _dbConext.SaveChangesAsync();
        }
    }
}
