using ClinincManagementSystemProject.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinincManagementSystemProject.Services
{
    public class PatientManager : IClinic<Patient>
    {
        readonly ClinicContext _context;
        readonly ILogger<PatientManager> _Logger;

        public PatientManager(ClinicContext context, ILogger<PatientManager> logger)
        {
            _context = context;
            _Logger = logger;
        }

        //This will add the data to the data base.
        public void Add(Patient t)
        {
            try
            {
                _context.Patients.Add(t);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _Logger.LogDebug(e.Message);
            }
        }

        //This will Delete the particular record.
        public void Delete(Patient t)
        {
            try
            {
                _context.Patients.Remove(t);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _Logger.LogDebug(e.Message);
            }
        }

        //This will fetch the particular id's data.
        public Patient Get(int id)
        {
            try
            {
                Patient P = _context.Patients.FirstOrDefault(i => i.PatientId == id);
                return P;
            }
            catch (Exception e)
            {
                _Logger.LogDebug(e.Message);
            }
            return null;
        }


        //This will fetch all the details.
        public IEnumerable<Patient> GetAll()
        {
            try
            {
                if (_context.UserLogins.Count() == 0)
                {
                    return null;
                }
                return _context.Patients.ToList();
            }
            catch (Exception e)
            {
                _Logger.LogDebug(e.Message);
            }
            return null;
        }

        public void Update(int id, Patient t)
        {
            try
            {
                Patient P = Get(id);
                if(P!=null)
                {
                    P.FirstName = t.FirstName;
                    P.LastName = t.LastName;
                    P.Gender = t.Gender;
                    P.Age = t.Age;
                    P.DateOfBirth = t.DateOfBirth;
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
