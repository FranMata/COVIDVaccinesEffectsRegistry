using COVIDVaccinesEffectsRegistry.Models;
using COVIDVaccinesEffectsRegistry.Models.OtherModels;
using COVIDVaccinesEffectsRegistry.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COVIDVaccinesEffectsRegistry.Controllers
{
    public class VaccineController : Controller
    {
        private readonly COVIDVaccinesEffectsContext _context;

        public VaccineController(COVIDVaccinesEffectsContext context) => _context = context;
        public IActionResult Index() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(VaccineViewModel vaccine) //Guarda los datos del medico
        {
            if (ModelState.IsValid)
            {
                Vaccine vaccineEF = new Vaccine()
                {
                    Name = vaccine.Name,
                    Brand = vaccine.Brand,
                    AplicationDate = vaccine.AplicationDate.ToString(),
                    BatchNumber = vaccine.BatchNumber,
                    ExpirationDate = vaccine.ExpirationDate.ToString(),
                    AplicationPlace = vaccine.AplicationPlace,
                    Observations = vaccine.Observations,
                    PatientId = DataToKeep.PatientId
                };

                _context.Add(vaccineEF);
                await _context.SaveChangesAsync();                
                return Redirect(@"/Clinic");
            }
            return View(vaccine);
        }
    }
}
