using Microsoft.AspNetCore.Mvc;
using Project_Test.Data;
using Project_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Test.Controllers
{
    public class CustomerController : Controller
    {
        public readonly DbContextCustomer _db;

        public CustomerController(DbContextCustomer db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Customers> Obj = _db.customersTbl;
            return View(Obj);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Customers Obj)
        {
            _db.customersTbl.Add(Obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
