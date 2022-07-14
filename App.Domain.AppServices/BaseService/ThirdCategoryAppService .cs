using App.Domain.Core.BaseService.Contracts.IAppServices;
using App.Domain.Core.BaseService.Contracts.IServices;
using App.Domain.Core.BaseService.Dtos;
using App.Domain.Core.BaseService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.BaseService
{
    public class ThirdCategoryAppService: IThirdCategoryAppService
    {

        private readonly IThirdCategoryService _thirdCategoryService;

        public ThirdCategoryAppService(IThirdCategoryService thirdCategoryService)
        {
            _thirdCategoryService = thirdCategoryService;
        }

        public async Task Add(ThirdCategoryDto model)
        {
            await _thirdCategoryService.Add(model);
        }

        public async Task Delete(int id)
        {
            await _thirdCategoryService.Delete(id);
        }

        public async Task<ThirdCategoryDto>? Get(int id)
        {
            var record = await _thirdCategoryService.Get(id);
            
            return record;
        }

        public async Task<ThirdCategoryDto>? Get(string name)
        {
            var record = await _thirdCategoryService.Get(name);
            
            return record;
        }

        public Task<List<ThirdCategoryDto>>? GetAll()
        {
            return _thirdCategoryService.GetAll();
        }

        public async Task Update(ThirdCategoryDto model)
        {
            await _thirdCategoryService.Update(model);
        }
    }
}
