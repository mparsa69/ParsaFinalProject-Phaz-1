﻿using App.Domain.Core.SuggestionAgg.Contracts.IRepositories;
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
    public class SuggestionCommandRepository : ISuggestionCommandRepository
    {
        private readonly AppDbContext _dbConext;

        public SuggestionCommandRepository(AppDbContext dbConext)
        {
            _dbConext = dbConext;
        }
        public async Task Add(SuggestionDto model)
        {
            var suggestion = new Suggestion()
            {
                Duration = model.Duration,
                Price = model.Price,
                StartTime = model.StartTime,
                ExpertId = model.ExpertId,
                OrderId = model.OrderId
            };
            await _dbConext.Suggestions.AddAsync(suggestion);
            await _dbConext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var record = await _dbConext.Suggestions.SingleOrDefaultAsync(x => x.Id == id);
            _dbConext.Suggestions.Remove(record!);
            await _dbConext.SaveChangesAsync();
        }
        
        public async Task Update(SuggestionDto model)
        {
            var record = await _dbConext.Suggestions.SingleOrDefaultAsync(x => x.Id == model.Id);
            record.Duration = model.Duration;
            record.Price = model.Price;
            record.StartTime = model.StartTime;
            record.ExpertId = model.ExpertId;
            record.OrderId = model.OrderId;
            _dbConext.Suggestions.Update(record);
            await _dbConext.SaveChangesAsync();
        }
    }
}
