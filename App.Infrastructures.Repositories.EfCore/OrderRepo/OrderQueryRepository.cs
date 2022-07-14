using App.Domain.Core.OrderAgg.Contracts.IRepositories;
using App.Domain.Core.OrderAgg.Dtos;
using App.Domain.Core.OrderAgg.Entities;
using App.Infrastructures.Database.SqlServer.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructures.Repositories.EfCore.OrderRepo
{
    public class OrderQueryRepository : IOrderQueryRepository
    {
        private readonly AppDbContext _dbConext;
        public OrderQueryRepository(AppDbContext dbConext)
        {
            _dbConext = dbConext;
        }
        public async Task<OrderDto>? Get(int id)
        {
            var result = await _dbConext.Orders.Where(x=>x.Id==id).Select(y=>new OrderDto()
            {
                Id= y.Id,   
                Description=y.Description,
                Status=y.Status,
                Title=y.Title,
                CustomerId=y.CustomerId,
                ThirdCategoryId=y.ThirdCategoryId
            }).SingleOrDefaultAsync();
            return result;
        }

        public async Task<OrderDto>? Get(string name)
        {
            var result = await _dbConext.Orders.Where(x => x.Title.Contains(name)).Select(y => new OrderDto()
            {
                Id = y.Id,
                Description = y.Description,
                Status = y.Status,
                Title = y.Title,
                CustomerId = y.CustomerId,
                ThirdCategoryId = y.ThirdCategoryId
            }).FirstOrDefaultAsync();
            return result;
        }

        public List<OrderDto>? GetAll()
        {
            var results = _dbConext.Orders.Select(y => new OrderDto()
            {
                Id = y.Id,
                Description = y.Description,
                Status = y.Status,
                Title = y.Title,
                CustomerId = y.CustomerId,
                ThirdCategoryId = y.ThirdCategoryId
            }).ToList();
            return results;
        }
        public async Task<List<OrderDto>>? GetAllAsync()
        {
            var results = await _dbConext.Orders.Select(y => new OrderDto()
            {
                Id = y.Id,
                Description = y.Description,
                Status = y.Status,
                Title = y.Title,
                CustomerId = y.CustomerId,
                ThirdCategoryId = y.ThirdCategoryId
            }).ToListAsync();
            return results;
        }
    }
}
