using COVIDVaccinesEffectsRegistry.Models.OtherModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COVIDVaccinesEffectsRegistry.Models.ViewModels
{
    public class PatientController : Controller
    {
        private COVIDVaccinesEffectsContext _context;

        public PatientController(COVIDVaccinesEffectsContext context) => _context = context;
        public ActionResult Index() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PatientViewModel patient)
        {
            if (ModelState.IsValid)
            {
                Patient patientEF = new Patient()
                {
                    DocumentId = patient.DocumentId,
                    Name = patient.Name,
                    LastName = patient.LastName,
                    BirthDate = patient.BirthDate.ToString(),
                    Gender = 1,
                    ContactNumber = patient.ContactNumber,
                    Country = patient.Country,
                    Province = patient.Province,
                    District = patient.District,
                    MaritalStatus = patient.MaritalStatus,
                    Email = patient.Email,
                    RegistryDate = patient.RegistryDate.ToString(),
                    Occupation = patient.Occupation,
                    DoctorId = DataToKeep.DoctorId,
                    ClinicId = DataToKeep.ClinicId
                };
                _context.Add(patientEF);
                await _context.SaveChangesAsync();
                DataToKeep.PatientId = patientEF.Id;
                return Redirect(@"/Vaccine");
            }
            return View(patient);
        }
    }         
}
