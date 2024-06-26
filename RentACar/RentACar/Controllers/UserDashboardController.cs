﻿using Microsoft.AspNetCore.Mvc;
using RentACar_DataAccess.Data;
using RentACar_Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace RentACar.Controllers
{
    public class UserDashboardController : Controller
    {
        private readonly ApplicationDbContext _db;

        public UserDashboardController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Vehicle> objList = _db.vehicles.ToList();
            return View(objList);
        }

        [HttpGet]
        public IActionResult AddVehicleInfo(int? id)
        {
            if (id == null)
            {
                return View(new Vehicle());
            }

            var objDb = _db.vehicles.FirstOrDefault(a => a.VehicleId == id);

            if (objDb == null)
            {
                return NotFound();
            }

            return View(objDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddVehicleInfo(Vehicle obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.VehicleId == 0)
                {
                    _db.vehicles.Add(obj);
                }
                else
                {
                    _db.vehicles.Update(obj);
                }

                obj.CalculateIdleStandbyTime();
                obj.CalculateActiveWorkingTimePercentage();
                obj.CalculateIdleStandbyTimePercentage();

                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }


       


    }
}
