using App.Domain.Core.ExpertAgg.Contracts.IRepositories;
using App.Domain.Core.ExpertAgg.Entities;
using App.Infrastructures.Database.SqlServer.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructures.Repositories.EfCore.ExpertRepo
{
    public class ExpertCommandRepository : IExpertCommandRepository
    {
        private readonly AppDbContext _dbConext;
        public ExpertCommandRepository(AppDbContext dbConext)
        {
            _dbConext = dbConext;
        }
        public async Task Add(Expert model)
        {
            await _dbConext.Experts.AddAsync(model);
            await _dbConext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var record = await _dbConext.Experts.SingleOrDefaultAsync(x => x.Id == id);
            _dbConext.Remove(record!);
            await _dbConext.SaveChangesAsync();
        }

        public async Task Update(Expert model)
        {
            var record = await _dbConext.Experts.SingleOrDefaultAsync(x => x.Id == model.Id);
            _dbConext.Experts.Update(model);
            await _dbConext.SaveChangesAsync();
        }
    }
}
