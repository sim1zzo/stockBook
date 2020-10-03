using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Security;
using StockBook.DataAccess.Repository;
using StockBook.DataAccess.Repository.IRepository;
using StockBook.Models;
using StockBook.Utility;

namespace StockBook.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
        
        public async Task<IActionResult> Upsert(int? id)
        {
            var category = new Category();

            if(id == null)
            {
                return View(category);
            }
            category = await _unitOfWork.Category.GetAsync(id.GetValueOrDefault());

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(Category category)
        {
            if (ModelState.IsValid)
            {
                if (category.Id == 0)
                {
                   await _unitOfWork.Category.AddAsync(category);
                    
                }
                else
                {
                    _unitOfWork.Category.Update(category);
                }

                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));       
            }
            return View(category);
        }

        

        #region API CALLS

        public async Task<IActionResult> GetAll()
        {
            var objFromDb = _unitOfWork.Category.GetAllAsync();
            return Json(new { data = objFromDb });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var objFromDb =await  _unitOfWork.Category.GetAsync(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            await _unitOfWork.Category.RemoveAsync(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });
        }

        #endregion
    }


}
