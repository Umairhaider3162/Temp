using EventFinal.Models;
using EventFinal.Repositories;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventFinal.Controllers
{
    public class RegistrationController : Controller
    {
        IRegistrationRepository registrationRepository;
        private readonly IConfiguration _configuration;
        public RegistrationController(IRegistrationRepository registration,IConfiguration configuration)
        {
            registrationRepository = registration;
            _configuration = configuration;
        }
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(Registration model)
        {
            if (ModelState.IsValid)
            {
                registrationRepository.AddRegistration(model);
                return RedirectToAction("Home", "Index");
            }
            return View();
        }
    }
}
