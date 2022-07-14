using App.Domain.Core.SuggestionAgg.Contracts.IAppServices;
using App.Domain.Core.SuggestionAgg.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Suggestion
{
    public class SuggestionAppService: ISuggestionAppService
    {
        private readonly ISuggestionAppService _suggestionAppService;
        public SuggestionAppService(ISuggestionAppService suggestionAppService)
        {
            _suggestionAppService = suggestionAppService;
        }

        public async Task Add(SuggestionDto model)
        {
            await _suggestionAppService.Add(model); ;
        }

        public async Task Delete(int id)
        {
            await _suggestionAppService.Delete(id);
        }

        public async Task<SuggestionDto>? Get(int id)
        {
            return await _suggestionAppService.Get(id);
        }

        public async Task<SuggestionDto>? Get(string name)
        {
            return await _suggestionAppService.Get(name);
        }

        public List<SuggestionDto> GetAll()
        {
            return _suggestionAppService.GetAll();
        }

        public async Task<List<SuggestionDto>>? GetAllAsync()
        {
            return await _suggestionAppService.GetAllAsync();
        }

        public async Task Update(SuggestionDto model)
        {
            await _suggestionAppService.Update(model);
        }
    }
}
