using COVIDVaccinesEffectsRegistry.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COVIDVaccinesEffectsRegistry.Controllers
{
    public class DoctorController : Controller
    {
        private readonly COVIDVaccinesEffectsContext _context;

        public DoctorController(COVIDVaccinesEffectsContext context) => _context = context;

        public IActionResult Index() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(DoctorViewModel doctor) //Guarda los datos del medico
        {
            if (ModelState.IsValid)
            {
                Doctor doctorEF = new Doctor()
                {
                    DocumentId = doctor.DocumentId,
                    ProfessionalCode = doctor.ProfessionalCode,
                    Name = doctor.Name,
                    Email = doctor.Email,
                    Country = doctor.Country,
                    Province = doctor.Province
                };

                _context.Add(doctorEF);
                await _context.SaveChangesAsync();
                return Redirect(@"/Clinic");
            }

            return View(doctor);
        }
    }
}
