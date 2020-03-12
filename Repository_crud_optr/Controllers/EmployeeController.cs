using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Repository_crud_optr.Models;
using Repository_crud_optr.Repositories;

namespace Repository_crud_optr.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly Irepo _irepo;
        //public EmployeeController()
        //{
        //    this._irepo = new Repo(new Models.DbContextClass());
        //}
        public EmployeeController(Irepo irepo)
        {
            this._irepo = irepo;
        }
        public IActionResult Index()
        {
            var v = _irepo.GetList();
            return View(v);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Dept dp)
        {
            _irepo.Insert(dp);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)

        {
            var v = _irepo.GetRecordById(id);
            return View(v);
        }
        public IActionResult Edit(int id)
        {

            var v = _irepo.GetRecordById(id);
            return View(v);
        }
        [HttpPost]
        public IActionResult Edit(Dept dp)
        {
            _irepo.Update(dp);
            _irepo.Save();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var v = _irepo.GetRecordById(id);
            return View(v);
        }
        [HttpPost]
        public IActionResult Delete(int id, Dept dp)
        {
            _irepo.Delete(id);
            _irepo.Save();
            return RedirectToAction("Index");
        }
        public IActionResult Viewmodel()
        {
            var v = _irepo.GetList1();
            return View(v);
        }


    }
}