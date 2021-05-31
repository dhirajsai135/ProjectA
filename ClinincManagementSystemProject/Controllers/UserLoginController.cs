using ClinincManagementSystemProject.Models;
using ClinincManagementSystemProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ClinincManagementSystemProject.Controllers
{
    public class UserLoginController : Controller
    {
        private readonly IClinic<UserLogin> _repo;
        private readonly ILogger<UserLoginController> _logger;
        private readonly ClinicContext _context;

        //Dependancey injection
        public UserLoginController(IClinic<UserLogin> repo, ILogger<UserLoginController> logger,ClinicContext context)
        {
            _repo = repo;
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Register(UserLogin reg)
        {
            try
            {
                _repo.Add(reg);
                return RedirectToAction("Login","UserLogin");
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return RedirectToAction("Privacy", "Home");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserLogin login)
        {
            if (_context.UserLogins.Where(x => x.Username == login.Username && x.Password == login.Password).FirstOrDefault() != null)
            {
                ViewBag.Firstname = _context.UserLogins.Where(x => x.Username == login.Username).Select(x => x.FirstName);
                return RedirectToAction("Welcome");
            }
            else
            {
                TempData["Message"] = "Please Enter Valid Login Details";
                return RedirectToAction("Login");

            }
            
        }
        public IActionResult Logout()
        {
            return RedirectToAction("Login", "UserLogin");
        }
        public IActionResult Welcome()
        {
            return View();
        }



    }
}
