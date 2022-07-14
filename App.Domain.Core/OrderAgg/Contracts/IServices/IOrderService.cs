using App.Domain.Core.OrderAgg.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.OrderAgg.Contracts.IServices
{
    public interface IOrderService
    {
        Task Add(OrderDto model);
        Task Update(OrderDto model);
        Task Delete(int id);

        Task<List<OrderDto>>? GetAllAsync();
        List<OrderDto> GetAll();
        Task<OrderDto>? Get(int id);
        Task<OrderDto>? Get(string name);
    }
}
