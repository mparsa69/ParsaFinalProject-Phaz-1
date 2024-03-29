﻿using App.Domain.Core.OrderAgg.Contracts.IRepositories;
using App.Domain.Core.OrderAgg.Contracts.IServices;
using App.Domain.Core.OrderAgg.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.Order
{
    public class OrderService : IOrderService
    {
        private readonly IOrderCommandRepository _orderCommandRepository;
        private readonly IOrderQueryRepository _orderQueryRepository;
        public OrderService(IOrderCommandRepository orderCommandRepository, IOrderQueryRepository orderQueryRepository)
        {

            _orderCommandRepository = orderCommandRepository;
            _orderQueryRepository = orderQueryRepository;
        }
        public async Task Add(OrderDto model)
        {
            await _orderCommandRepository.Add(model);
        }

        public async Task Delete(int id)
        {
            await _orderCommandRepository.Delete(id);
        }

        public async Task<OrderDto>? Get(int id)
        {
            return await _orderQueryRepository.Get(id);
        }

        public async Task<OrderDto>? Get(string name)
        {
            return await _orderQueryRepository.Get(name);
        }

        public List<OrderDto> GetAll()
        {
            return  _orderQueryRepository.GetAll();
        }

        public async Task<List<OrderDto>>? GetAllAsync()
        {
            return await _orderQueryRepository.GetAllAsync();
        }

        public async Task Update(OrderDto model)
        {
            await _orderCommandRepository.Update(model);
        }
    }
}
