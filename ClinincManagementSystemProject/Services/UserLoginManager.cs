using ClinincManagementSystemProject.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinincManagementSystemProject.Services
{
    public class UserLoginManager : IClinic<UserLogin>
    {
        readonly ClinicContext _context;
        readonly ILogger<UserLoginManager> _Logger;

        public UserLoginManager(ClinicContext context, ILogger<UserLoginManager> logger)
        {
            _context = context;
            _Logger = logger;
        }

        //This will add the data to the data base.
        public void Add(UserLogin t)
        {
            try
            {
                _context.UserLogins.Add(t);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _Logger.LogDebug(e.Message);
            }
        }

        //This will Delete the particular record.
        public void Delete(UserLogin t)
        {
            try
            {
                _context.UserLogins.Remove(t);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _Logger.LogDebug(e.Message);
            }
        }

        //This will fetch the particular id's data.
        public UserLogin Get(int id)
        {
            try
            {
                UserLogin U = _context.UserLogins.FirstOrDefault(i => i.UserID == id);
                return U;
            }
            catch (Exception e)
            {
                _Logger.LogDebug(e.Message);
            }
            return null;
        }


        //This will fetch all the details.
        public IEnumerable<UserLogin> GetAll()
        {
            try
            {
                if (_context.UserLogins.Count() == 0)
                {
                    return null;
                }
                return _context.UserLogins.ToList();
            }
            catch (Exception e)
            {
                _Logger.LogDebug(e.Message);
            }
            return null;
        }

        public void Update(int id, UserLogin t)
        {
            throw new NotImplementedException();
        }
    }
}
