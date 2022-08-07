using COVIDVaccinesEffectsRegistry.Models;
using COVIDVaccinesEffectsRegistry.Models.OtherModels;
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

        [HttpGet]
        public IActionResult ValidateDoctor(int documentId, int professionalCode)
        {
            List<Doctor> doctors = _context.Doctors.ToList();
            Doctor doctor = (Doctor)doctors.Where(e => e.DocumentId.Equals(documentId) && e.ProfessionalCode.Equals(professionalCode)).FirstOrDefault();

            if (doctor == null)
                return Json(0);

            DataToKeep.DoctorId = doctor.Id;
            return Json(1);
        }

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
                DataToKeep.DoctorId = doctorEF.Id;
                return Redirect(@"/Clinic");
            }
            return View(doctor);
        }
    }
}
