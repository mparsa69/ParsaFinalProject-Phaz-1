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
    public class OrderCommandRepository : IOrderCommandRepository
    {
        private readonly AppDbContext _dbConext;

        public OrderCommandRepository(AppDbContext dbConext)
        {
            _dbConext = dbConext;
        }
        public async Task Add(OrderDto model)
        {
            var order = new Order()
            {
                Description = model.Description,
                Status = model.Status,
                Title = model.Title,
                CustomerId = model.CustomerId,
                ThirdCategoryId = model.ThirdCategoryId
            };
            await _dbConext.Orders.AddAsync(order);
            await _dbConext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var record = await _dbConext.Orders.SingleOrDefaultAsync(x => x.Id == id);
            _dbConext.Orders.Remove(record!);
            await _dbConext.SaveChangesAsync();
        }

        public async Task Update(OrderDto model)
        {
            var record = await _dbConext.Orders.SingleOrDefaultAsync(x => x.Id == model.Id);
            record.Description = model.Description;
            record.Status = model.Status;
            record.Title = model.Title;
            record.CustomerId = model.CustomerId;
            record.ThirdCategoryId = model.ThirdCategoryId;
            _dbConext.Orders.Update(record);
            await _dbConext.SaveChangesAsync();
        }
    }
}
