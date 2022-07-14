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
    public class ExpertQueryRepository : IExpertQueryRepository
    {
        private readonly AppDbContext _dbConext;
        public ExpertQueryRepository(AppDbContext dbConext)
        {
            _dbConext = dbConext;
        }

        public async Task<Expert>? Get(int id)
        {
            var expert = await _dbConext.Experts.SingleOrDefaultAsync(x => x.Id == id);
            return expert;
        }

        public async Task<Expert>? Get(string name)
        {
            var expert = await _dbConext.Experts.FirstOrDefaultAsync(x => x.Name.Contains(name));
            return expert;
        }

        public List<Expert>? GetAll()
        {
            var experts = _dbConext.Experts.ToList();
            return experts;
        }

        public async Task<List<Expert>>? GetAllAsync()
        {
            var experts = await _dbConext.Experts.ToListAsync();
            return experts;
        }
    }
}
