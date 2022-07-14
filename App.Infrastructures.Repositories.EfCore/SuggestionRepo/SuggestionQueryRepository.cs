using App.Domain.Core.SuggestionAgg.Contracts.IRepositories;
using App.Domain.Core.SuggestionAgg.Dtos;
using App.Domain.Core.SuggestionAgg.Entities;
using App.Infrastructures.Database.SqlServer.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructures.Repositories.EfCore.SuggestionRepo
{
    public class SuggestionQueryRepository : ISuggestionQueryRepository
    {
        private readonly AppDbContext _dbConext;
        public SuggestionQueryRepository(AppDbContext dbConext)
        {
            _dbConext = dbConext;
        }
        public async Task<SuggestionDto>? Get(int id)
        {
            var result = await _dbConext.Suggestions.Where(x => x.Id == id).Select(y=>new SuggestionDto()
            {
                Id = y.Id,
                Duration=y.Duration,
                Price=y.Price,
                StartTime=y.StartTime,
                ExpertId=y.ExpertId,
                OrderId=y.OrderId
            }).SingleOrDefaultAsync();
            return result;
        }

        public async Task<SuggestionDto>? Get(string name)
        {
            throw new NotImplementedException();
        }

        public  List<SuggestionDto>? GetAll()
        {
            var results = _dbConext.Suggestions.Select(y => new SuggestionDto()
            {
                Id = y.Id,
                Duration = y.Duration,
                Price = y.Price,
                StartTime = y.StartTime,
                ExpertId = y.ExpertId,
                OrderId = y.OrderId
            }).ToList();
            return results;
        }

        public async Task<List<SuggestionDto>>? GetAllAsync()
        {
            var results = await _dbConext.Suggestions.Select(y => new SuggestionDto()
            {
                Id = y.Id,
                Duration = y.Duration,
                Price = y.Price,
                StartTime = y.StartTime,
                ExpertId = y.ExpertId,
                OrderId = y.OrderId
            }).ToListAsync();
            return results;
        }
    }
}
