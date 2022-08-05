using COVIDVaccinesEffectsRegistry.Models;
using COVIDVaccinesEffectsRegistry.Models.OtherModels;
using COVIDVaccinesEffectsRegistry.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace COVIDVaccinesEffectsRegistry.Controllers
{
    public class PatientMedicalHistoryController : Controller
    {
        private readonly COVIDVaccinesEffectsContext _context;

        public PatientMedicalHistoryController(COVIDVaccinesEffectsContext context) => _context = context;

        public IActionResult Index()
        {
            ViewData["Answers"] = new SelectList(_context.Answers, "Id", "Aswer");
            return View();
        }            

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PatientMedicalHistoryViewModel patientMedicalHistory) //Guarda los datos del medico
        {
            if (ModelState.IsValid)
            {
                PatientMedicalHistory patientMedicalHistoryEF = new PatientMedicalHistory()
                {
                    HadCovidprevios = patientMedicalHistory.HadCovidprevios,
                    //HadSuspicionCov = patientMedicalHistory.HadSuspicionCovid,
                    HadCovidafter = patientMedicalHistory.HadCovidafter,
                    Reason = patientMedicalHistory.Reason,
                    IsPregnant = patientMedicalHistory.IsPregnant,
                    HadVaccineReaction = patientMedicalHistory.HadVaccineReaction,
                    VaccineReactionDescription = patientMedicalHistory.VaccineReactionDescription,
                    ActualMedicine = patientMedicalHistory.ActualMedicine,
                    MedicineAfterCovidveccine = patientMedicalHistory.MedicineAfterCovidveccine,
                    PatientId = DataToKeep.PatientId

                };
                _context.Add(patientMedicalHistoryEF);
                await _context.SaveChangesAsync();
                return Redirect(@"/Clinic");
            }
            return View(patientMedicalHistory);
        }
    }
}