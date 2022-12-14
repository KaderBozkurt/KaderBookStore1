using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KadersBooks.DataAccess.Repository.IRepository;
using KadersBooks.Models;
using Dapper;
using KadersBooks.Utility;

namespace KaderBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CoverTypeController : Controller

    {
        private readonly IUnitOfWork _unitOfWork;
        public CoverTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Upsert(int? id)
        {
            CoverType coverType = new CoverType();
            if(id == null)
            {
                return View(coverType);
            }

            // this is for edit
            var parameter = new DynamicParameters();
            parameter.Add("@Id", id);

            coverType = _unitOfWork.SP_Call.OneRecord<CoverType>(SD.Proc_CoverType_Get, parameter);

           
            if(coverType == null)
            {
                return NotFound();
            }
            return View(coverType);
        }



        //use HTTP POST to define the post-action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(CoverType coverType)
        {
            if (ModelState.IsValid)     //check all validations in the model(e.g Name Required) to increase security
            {
                if (coverType.Id == 0)
                {
                    _unitOfWork.CoverType.Add(coverType);
                    _unitOfWork.Save();
                }
                else
                {
                    _unitOfWork.CoverType.Update(coverType);

                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));       //to see all categories
            }
            return View(coverType);
        }

        //API calls here
        #region API CALLS
        [HttpGet]
    public IActionResult GetAll()
    {
        //return NotFound();
        var allObj = _unitOfWork.CoverType.GetAll();
        return Json(new { data = allObj });
    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {
        var objFromDb = _unitOfWork.CoverType.Get(id);
        if (objFromDb == null)
        {
            return Json(new { success = true, message = "Error while deleting " });
        }
        _unitOfWork.CoverType.Remove(objFromDb);
        _unitOfWork.Save();
        return Json(new { success = true, message = " Delete successful" });
    }
    #endregion
}
}