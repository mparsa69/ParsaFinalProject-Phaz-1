using App.Domain.Core.OrderAgg.Contracts.IAppServices;
using App.Domain.Core.OrderAgg.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Order
{
    public class OrderAppService : IOrderAppService
    {
        private readonly IOrderAppService _orderAppService;
        public OrderAppService(IOrderAppService orderAppService)
        {
            _orderAppService = orderAppService; 
        }

        public async Task Add(OrderDto model)
        {
            await _orderAppService.Add(model); ;
        }

        public async Task Delete(int id)
        {
            await _orderAppService.Delete(id);
        }

        public async Task<OrderDto>? Get(int id)
        {
            return await _orderAppService.Get(id);
        }

        public async Task<OrderDto>? Get(string name)
        {
            return await _orderAppService.Get(name);
        }

        public List<OrderDto> GetAll()
        {
            return  _orderAppService.GetAll();
        }

        public async Task<List<OrderDto>>? GetAllAsync()
        {
            return await _orderAppService.GetAllAsync();
        }

        public async Task Update(OrderDto model)
        {
            await _orderAppService.Update(model);
        }
    }
}
