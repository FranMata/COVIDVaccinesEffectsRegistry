using COVIDVaccinesEffectsRegistry.Models;
using COVIDVaccinesEffectsRegistry.Models.OtherModels;
using COVIDVaccinesEffectsRegistry.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace COVIDVaccinesEffectsRegistry.Controllers
{
    public class ClinicController : Controller
    {
        private COVIDVaccinesEffectsContext _context;

        public ClinicController(COVIDVaccinesEffectsContext context) => _context = context;

        public ActionResult Index() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ClinicViewModel clinic)
        {
            if (ModelState.IsValid)
            {
                Clinic clinicEF = new Clinic()
                {                    
                    Name = clinic.Name,
                    TaxId = clinic.TaxId,                    
                    Country = clinic.Country,
                    Province = clinic.Province,
                    District = clinic.District,
                    Phone = clinic.Phone,
                    Email = clinic.Email,
                    Web = clinic.Web
                };

                _context.Add(clinicEF);
                await _context.SaveChangesAsync();
                DataToKeep.ClinicId = clinicEF.Id;
                return Redirect(@"/Patient");
            }
            return View(clinic);
        }
    }
}
