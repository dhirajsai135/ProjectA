using ClinincManagementSystemProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinincManagementSystemProject.Services
{
    public class AppointmentManager :IClinic<Appointment>
    {
        readonly ClinicContext _context;
        readonly ILogger<AppointmentManager> _Logger;

        public AppointmentManager(ClinicContext context, ILogger<AppointmentManager> logger)
        {
            _context = context;
            _Logger = logger;
        }

        //This will add the data to the data base.
        public void Add(Appointment t)
        {
            try
            {
                _context.Appointments.Add(t);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _Logger.LogDebug(e.Message);
            }
        }

        //This will Delete the particular record.
        public void Delete(Appointment t)
        {
            try
            {
                _context.Appointments.Remove(t);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _Logger.LogDebug(e.Message);
            }
        }

        //This will fetch the particular id's data.
        public Appointment Get(int id)
        {
            try
            {
                Appointment P = _context.Appointments.FirstOrDefault(i => i.AppointmentId == id);
                return P;
            }
            catch (Exception e)
            {
                _Logger.LogDebug(e.Message);
            }
            return null;
        }


        //This will fetch all the details.
        public IEnumerable<Appointment> GetAll()
        {
            try
            {
                if (_context.Appointments.Count() == 0)
                {
                    return null;
                }
                return _context.Appointments.Include(D=>D.Doctor).ToList();
            }
            catch (Exception e)
            {
                _Logger.LogDebug(e.Message);
            }
            return null;
        }

        public void Update(int id, Appointment t)
        {
            try
            {
                Appointment A = Get(id);
                if (A != null)
                {
                    A.DoctorID = t.DoctorID;
                    A.PatientID = t.PatientID;
                    A.DoctorAvailability = t.DoctorAvailability;
                    A.VisitDate = t.VisitDate;
                    A.SpecializationRequired = t.SpecializationRequired;

                }
                _context.SaveChanges();

            }
            catch (Exception e)
            {

                _Logger.LogDebug(e.Message);
            }

        }
    }
}
