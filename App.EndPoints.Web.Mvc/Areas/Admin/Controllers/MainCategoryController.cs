using App.Domain.Core.BaseService.Contracts.IAppServices;
using App.Domain.Core.BaseService.Dtos;
using App.Domain.Core.BaseService.Entities;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.Web.Mvc.Areas.Admin.Controllers
{
    public class MainCategoryController : Controller
    {
        private readonly IMainCategoryAppService _mainCategoryAppService;

        public MainCategoryController(IMainCategoryAppService mainCategoryAppService)
        {
            _mainCategoryAppService = mainCategoryAppService;
        }

        public async Task<IActionResult> Index()
        {
            var results =await _mainCategoryAppService.GetAllAsync();
            return View(results);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(MainCategoryDto model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _mainCategoryAppService.Add(model);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var MainCategory =await _mainCategoryAppService.Get(id);
            
            return View(MainCategory);
        }

        [HttpPost]
        public async Task<IActionResult> Update(MainCategoryDto model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _mainCategoryAppService.Update(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var model = await _mainCategoryAppService.Get(id);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteMainCategory(int id)
        {
            await _mainCategoryAppService.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
