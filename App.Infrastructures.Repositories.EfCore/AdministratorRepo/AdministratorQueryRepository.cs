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
    public class AdministratorQueryRepository
    {
        private readonly AppDbContext _dbConext;
        public AdministratorQueryRepository(AppDbContext dbConext)
        {
            _dbConext = dbConext;
        }

        public async Task<Administrator>? Get(int id)
        {
            var administrator = await _dbConext.Administrators.SingleOrDefaultAsync(x => x.Id == id);
            return administrator;
        }

        public async Task<Administrator>? Get(string name)
        {
            var administrator = await _dbConext.Administrators.FirstOrDefaultAsync(x => x.Name.Contains(name));
            return administrator;
        }

        public List<Administrator>? GetAll()
        {
            var administrators = _dbConext.Administrators.ToList();
            return administrators;
        }

        public async Task<List<Administrator>>? GetAllAsync()
        {
            var administrators = await _dbConext.Administrators.ToListAsync();
            return administrators;
        }
    }
}
