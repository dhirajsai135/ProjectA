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
    public class PatientController : Controller
    {
        private readonly IClinic<Patient> _repo;
        private readonly ILogger<PatientController> _logger;
        private readonly ClinicContext _context;

        //Dependancey injection
        public PatientController(IClinic<Patient> repo, ILogger<PatientController> logger, ClinicContext context)
        {
            _repo = repo;
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            List<Patient> res= _repo.GetAll().ToList();
            return View(res);
        }

        public IActionResult AddPatient()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddPatient(Patient pat)
        {
            try
            {
                _repo.Add(pat);
                return RedirectToAction("DetailsOfPatient");
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return RedirectToAction("Privacy", "Home");
        }

        [HttpGet]
        public IActionResult DetailsOfPatient()
        {
            try
            {
                var res = _context.Patients.OrderBy(x => x.PatientId).LastOrDefault();
                int id = res.PatientId;
                Patient p = _repo.Get(id);
                return View(p);
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return RedirectToAction("Privacy", "Home");
        }

        [HttpGet]
        public IActionResult UpdatePatientDetails(int id)
        {
            Patient P = _repo.Get(id);
            return View(P);
        }
        [HttpPost]
        public IActionResult UpdatePatientDetails(int id, Patient P)
        {
            try
            {
                _repo.Update(id, P);
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult DeletePatient(int id)
        {
            Patient p = _repo.Get(id);
            return View(p);
        }
        [HttpPost]
        public IActionResult DeletePatient(Patient p)
        {
            try
            {
                _repo.Delete(p);
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return RedirectToAction("Index");
        }


    }
}
