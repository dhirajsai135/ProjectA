using ClinincManagementSystemProject.Models;
using ClinincManagementSystemProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinincManagementSystemProject.Controllers
{
    public class DoctorController : Controller
    {
        private readonly IClinic<Doctor> _repo;
        private readonly ILogger<DoctorController> _logger;
        private readonly ClinicContext _context;

        //Dependancey injection
        public DoctorController(IClinic<Doctor> repo, ILogger<DoctorController> logger, ClinicContext context)
        {
            _repo = repo;
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            List<Doctor> D = _repo.GetAll().ToList();
            return View(D);
            
        }

        public IActionResult AddDoctor()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddDoctor(Doctor doc)
        {
            try
            {
                _repo.Add(doc);
                return RedirectToAction("DetailsOfDoctor");
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return RedirectToAction("Privacy", "Home");
        }

        [HttpGet]
        public IActionResult DetailsOfDoctor()
        {
            try
            {
                var res = _context.Doctors.OrderBy(x => x.DoctorId).LastOrDefault();
                int id = res.DoctorId;
                Doctor p = _repo.Get(id);
                return View(p);
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return RedirectToAction("Privacy", "Home");
        }

        [HttpGet]
        public IActionResult UpdateDoctorDetails(int id)
        {
            Doctor D = _repo.Get(id);
            return View(D);
        }
        [HttpPost]
        public IActionResult UpdateDoctorDetails(int id, Doctor D)
        {
            try
            {
                _repo.Update(id, D);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult DeleteDoctor(int id)
        {
            Doctor D = _repo.Get(id);
            return View(D);
        }
        [HttpPost]
        public IActionResult DeleteDoctor(Doctor D)
        {
            try
            {
                _repo.Delete(D);
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return RedirectToAction("Index");
        }
        public IActionResult View(string spec)
        {
            ViewBag.Name = (from r in _context.Doctors select r.Specialization).Distinct();
            var model = from r in _context.Doctors
                        orderby r.Specialization
                        where r.Specialization == spec
                        select r;
            return View(model);
        }
    }
}
