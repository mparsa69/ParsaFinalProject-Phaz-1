
using App.Domain.Core.BaseService.Contracts.IRepositories;
using App.Domain.Core.BaseService.Dtos;
using App.Domain.Core.BaseService.Entities;
using App.Infrastructures.Database.SqlServer.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructures.Repositories.EfCore.BaseService
{
    public class ThirdCategoryQueryRepository : IThirdCategoryQueryRepository
    {
        private readonly AppDbContext _dbConext;

        public ThirdCategoryQueryRepository(AppDbContext dbConext)
        {
            _dbConext = dbConext;
        }
        public async Task<ThirdCategoryDto>? Get(int id)
        {
            var result = await _dbConext.ThirdCategories.Where(x=>x.Id==id).Select(x=>new ThirdCategoryDto()
            {
                Title = x.Title,
                SecondaryCategoryId = x.SecondaryCategoryId,
                Description = x.Description,
                Price = x.Price
            }).SingleOrDefaultAsync();
            return result;
        }

        public async Task<ThirdCategoryDto>? Get(string name)
        {
            var result = await _dbConext.ThirdCategories.Where(x => x.Title.Contains(name)).Select(x => new ThirdCategoryDto()
            {
                Title = x.Title,
                SecondaryCategoryId = x.SecondaryCategoryId,
                Description = x.Description,
                Price = x.Price
            }).FirstOrDefaultAsync();
            return result;
        }

        public async Task<List<ThirdCategoryDto>>? GetAllAsync()
        {
            var results =await _dbConext.ThirdCategories.Select(x => new ThirdCategoryDto()
            {
                Title = x.Title,
                SecondaryCategoryId = x.SecondaryCategoryId,
                Description = x.Description,
                Price = x.Price
            }).ToListAsync();
            return results;
        }
        public  List<ThirdCategoryDto>? GetAll()
        {
            var results =_dbConext.ThirdCategories.Select(x => new ThirdCategoryDto()
            {
                Title = x.Title,
                SecondaryCategoryId = x.SecondaryCategoryId,
                Description = x.Description,
                Price = x.Price
            }).ToList();
            return results;
        }

        
    }
}
