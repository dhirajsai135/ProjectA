using ClinincManagementSystemProject.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinincManagementSystemProject.Services
{
    public class DoctorManager :IClinic<Doctor>
    {
        readonly ClinicContext _context;
        readonly ILogger<DoctorManager> _Logger;

        public DoctorManager(ClinicContext context, ILogger<DoctorManager> logger)
        {
            _context = context;
            _Logger = logger;
        }

        //This will add the data to the data base.
        public void Add(Doctor t)
        {
            try
            {
                _context.Doctors.Add(t);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _Logger.LogDebug(e.Message);
            }
        }

        //This will Delete the particular record.
        public void Delete(Doctor t)
        {
            try
            {
                _context.Doctors.Remove(t);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _Logger.LogDebug(e.Message);
            }
        }

        //This will fetch the particular id's data.
        public Doctor Get(int id)
        {
            try
            {
                Doctor P = _context.Doctors.FirstOrDefault(i => i.DoctorId == id);
                return P;
            }
            catch (Exception e)
            {
                _Logger.LogDebug(e.Message);
            }
            return null;
        }


        //This will fetch all the details.
        public IEnumerable<Doctor> GetAll()
        {
            try
            {
                if (_context.Doctors.Count() == 0)
                {
                    return null;
                }
                return _context.Doctors.ToList();
            }
            catch (Exception e)
            {
                _Logger.LogDebug(e.Message);
            }
            return null;
        }

        public void Update(int id, Doctor t)
        {
            try
            {
                Doctor D = Get(id);
                if (D != null)
                {
                    D.FirstName = t.FirstName;
                    D.LastName = t.LastName;
                    D.Gender = t.Gender;
                    D.Specialization = t.Specialization;
                    D.AvailableFrom = t.AvailableFrom;
                    D.AvailableTo = t.AvailableTo;
                   
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
