using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StockBook.DataAccess.Repository;
using StockBook.DataAccess.Repository.IRepository;

namespace StockBook.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult Upsert(int? id)
        //{

        //}

        #region API CALLS

        public IActionResult GetAll()
        {
            var objFromDb = _unitOfWork.Category.GetAll();
            return Json(new { data = objFromDb });
        }

        #endregion
    }


}
