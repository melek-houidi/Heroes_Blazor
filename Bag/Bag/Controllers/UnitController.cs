using Bag.Data;
using Bag.Interfaces;
using Bag.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bag.Controllers
{
    public class UnitController : Controller
    {
        public IActionResult Index()  //read method of the crud operations, it lists all data from the units table.
        {
            //List<Unit> units = _context.Units.ToListAsync();  ==>putting this code in repository 
            //return View(units);
            List<Unit> units = _unitRepo.GetItems();
            return View(units);
        }

        //private readonly BagContext _context; ==>not require anymore with the controller
        private readonly IUnit _unitRepo;
       
        public UnitController( IUnit unitRepo)
        {
            //_context = context;
            _unitRepo = unitRepo;
        }

        public IActionResult Create()
        {
            Unit unit = new Unit();
            return View(unit);
        }

        [HttpPost]
        public IActionResult Create (Unit unit)
        {
            try
            {
                //_context.Units.Add(unit); ==>putting this code in repository 
                //_context.SaveChanges();

                unit = _unitRepo.Create(unit);
                //SqlCommand cmd = new SqlCommand("Insert into table_name (FirstName, LastName) Values('B' ,'Y')"); ==> insert into table
                //cmd.ExecuteNonQuery();
            }
            catch
            {

            }

            return RedirectToAction(nameof (Index));
        }


        public IActionResult Details(int id) 
        {
            Unit unit = (Unit)_unitRepo.GetUnit(id);
            return View(unit);
        }


        public IActionResult Edit(int id)
        {
            Unit unit = (Unit)_unitRepo.GetUnit(id);
            return View(unit);
        }


        [HttpPost]
        public IActionResult Edit(Unit unit)
        {
            try
            {
                //_context.Units.Attach(unit); ==>putting this code in repository 
                //_context.Entry(unit).State = EntityState.Modified; //update the echange
                //_context.SaveChanges();

                unit = _unitRepo.Edit(unit);
            }
            catch
            {

            }

            return RedirectToAction(nameof(Index));
        }


        public IActionResult Delete(int id)
        {
            Unit unit = (Unit)_unitRepo.GetUnit(id);
            return View(unit);
        }

        [HttpPost]
        public IActionResult Delete(Unit unit)
        {
            try
            {
                //_context.Units.Attach(unit);   ==> putting this code in repository
                //_context.Entry(unit).State = EntityState.Deleted; 
                //_context.SaveChanges();
                unit = _unitRepo.Delete(unit);
            }
            catch
            {

            }

            return RedirectToAction(nameof(Index));
        }

       
    }
}
