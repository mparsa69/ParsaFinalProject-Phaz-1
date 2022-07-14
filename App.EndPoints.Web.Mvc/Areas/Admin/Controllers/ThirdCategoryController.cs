using App.Domain.Core.BaseService.Contracts.IAppServices;
using App.Domain.Core.BaseService.Dtos;
using App.Domain.Core.BaseService.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace App.EndPoints.Web.Mvc.Areas.Admin.Controllers
{
    public class ThirdCategoryController : Controller
    {
        private readonly ISecondaryCategoryAppService _secondaryCategoryAppService;
        private readonly IThirdCategoryAppService _thirdCategoryAppService;

        public ThirdCategoryController(ISecondaryCategoryAppService secondaryCategoryAppService,
                IThirdCategoryAppService thirdCategoryAppService)
        {
            _secondaryCategoryAppService = secondaryCategoryAppService;
            _thirdCategoryAppService = thirdCategoryAppService;
        }

        public async Task<IActionResult> Index()
        {
            var results =await _thirdCategoryAppService.GetAll();
            return View(results);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var ThirdCategoryDropDown = _secondaryCategoryAppService.GetAll().Select(i => new SelectListItem
            {
                Text = i.Title,
                Value = i.Id.ToString()
            }).ToList();
            ViewBag.ThirdCategoryDropDown = ThirdCategoryDropDown;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ThirdCategoryDto model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _thirdCategoryAppService.Add(model);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var thirdCategory =await _thirdCategoryAppService.Get(id);
            
            return View(thirdCategory);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ThirdCategoryDto model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _thirdCategoryAppService.Update(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var model = await _thirdCategoryAppService.Get(id);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteThirdCategory(int id)
        {
            await _thirdCategoryAppService.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
