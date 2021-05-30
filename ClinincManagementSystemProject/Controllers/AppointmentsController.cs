using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClinincManagementSystemProject.Models;
using ClinincManagementSystemProject.Services;
using Microsoft.Extensions.Logging;

namespace ClinincManagementSystemProject.Controllers
{
    public class AppointmentsController : Controller
    {
        private readonly ClinicContext _context;
        private readonly IClinic<Appointment> _repo;
        private readonly ILogger<AppointmentsController> _logger;

        public AppointmentsController(ClinicContext context, IClinic<Appointment> repo, ILogger<AppointmentsController> logger)
        {
            _context = context;
            _repo = repo;
            _logger = logger;
        }

        // GET: Appointments
        public async Task<IActionResult> Index()
        {
            var clinicContext = _context.Appointments.Include(a => a.Doctor).Include(a => a.Patient);
            return View(await clinicContext.ToListAsync());
        }

        // GET: Appointments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointment = await _context.Appointments
                .Include(a => a.Doctor)
                .Include(a => a.Patient)
                .FirstOrDefaultAsync(m => m.AppointmentId == id);
            if (appointment == null)
            {
                return NotFound();
            }

            return View(appointment);
        }

        // GET: Appointments/Create
        public IActionResult Create()
        {
            ViewData["DoctorID"] = new SelectList(_context.Doctors, "DoctorId", "FirstName");
            ViewData["PatientID"] = new SelectList(_context.Patients, "PatientId", "FirstName");
            return View();
        }

        // POST: Appointments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AppointmentId,DoctorID,SpecializationRequired,PatientID,DoctorAvailability,VisitDate")] Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(appointment);
                await _context.SaveChangesAsync();
                return RedirectToAction("DetailsOfAppointment");
            }
            ViewData["DoctorID"] = new SelectList(_context.Doctors, "DoctorId", "FirstName", appointment.DoctorID);
            ViewData["PatientID"] = new SelectList(_context.Patients, "PatientId", "FirstName", appointment.PatientID);
            return View(appointment);
        }
       
        // GET: Appointments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointment = await _context.Appointments.FindAsync(id);
            if (appointment == null)
            {
                return NotFound();
            }
            ViewData["DoctorID"] = new SelectList(_context.Doctors, "DoctorId", "FirstName", appointment.DoctorID);
            ViewData["PatientID"] = new SelectList(_context.Patients, "PatientId", "FirstName", appointment.PatientID);
            return View(appointment);
        }

        // POST: Appointments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AppointmentId,DoctorID,SpecializationRequired,PatientID,DoctorAvailability,VisitDate")] Appointment appointment)
        {
            if (id != appointment.AppointmentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appointment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppointmentExists(appointment.AppointmentId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DoctorID"] = new SelectList(_context.Doctors, "DoctorId", "FirstName", appointment.DoctorID);
            ViewData["PatientID"] = new SelectList(_context.Patients, "PatientId", "FirstName", appointment.PatientID);
            return View(appointment);
        }
        [HttpGet]
        public IActionResult DetailsOfAppointment()
        {
            try
            {
                var check = _context.Appointments.OrderBy(x => x.DoctorAvailability).FirstOrDefault();
                string checkVariable = Convert.ToString(check.DoctorAvailability);
                string s = "Yes";
                
                if (checkVariable == s)
                {
                    var res = _context.Appointments.OrderBy(x => x.AppointmentId).LastOrDefault();
                    int id = res.AppointmentId;
                    Appointment A = _repo.Get(id);
                    return View(A);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return RedirectToAction("Privacy", "Home");
        }


        // GET: Appointments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointment = await _context.Appointments
                .Include(a => a.Doctor)
                .Include(a => a.Patient)
                .FirstOrDefaultAsync(m => m.AppointmentId == id);
            if (appointment == null)
            {
                return NotFound();
            }

            return View(appointment);
        }

        // POST: Appointments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var appointment = await _context.Appointments.FindAsync(id);
            _context.Appointments.Remove(appointment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppointmentExists(int id)
        {
            return _context.Appointments.Any(e => e.AppointmentId == id);
        }
    }
}
