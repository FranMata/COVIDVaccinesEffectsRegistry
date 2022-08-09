using COVIDVaccinesEffectsRegistry.Helper;
using COVIDVaccinesEffectsRegistry.Models;
using COVIDVaccinesEffectsRegistry.Models.OtherModels;
using COVIDVaccinesEffectsRegistry.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COVIDVaccinesEffectsRegistry.Controllers
{
    public class AdverseEffectsAndDataController : Controller
    {
        private readonly COVIDVaccinesEffectsContext _context;

        public AdverseEffectsAndDataController(COVIDVaccinesEffectsContext context) => _context = context;
                     
        public IActionResult Index()
        {
            AdverseEffectsAndDataViewModel adverseEffectsAndDataViewModel = new AdverseEffectsAndDataViewModel();

            ViewData["Answers"] = new SelectList(_context.Answers, "Id", "Aswer");

            adverseEffectsAndDataViewModel.eventSymptomResultViewModel = AdverseEffectsAndDataHelper.BuildEventSymptomResultViewModel(_context.EventSymptomResults.ToList());
            adverseEffectsAndDataViewModel.allergyViewModels = AdverseEffectsAndDataHelper.BuildAllergyViewModel(_context.Allergies.ToList());
            adverseEffectsAndDataViewModel.deseaseViewModel = AdverseEffectsAndDataHelper.BuildDeseaseViewModel(_context.Diseases.ToList());
            adverseEffectsAndDataViewModel.symptomViewModel = AdverseEffectsAndDataHelper.BuildSymptomViewModel(_context.Symptoms.ToList());
            return View(adverseEffectsAndDataViewModel);
        }

        [HttpPost]
        public IActionResult Create(AdverseEffectsAndDataViewModel adverseEffectsAndData)
        {
            _context.AllergyRegistereds.AddRange(
                AdverseEffectsAndDataHelper.BuildAllergy(
                    adverseEffectsAndData.allergyViewModels, DataToKeep.PatientId));

            _context.DiseaseRegistereds.AddRange(
                AdverseEffectsAndDataHelper.BuildDesease(
                    adverseEffectsAndData.deseaseViewModel, DataToKeep.PatientId));

            _context.SymptomRegistereds.AddRange(
                AdverseEffectsAndDataHelper.BuildSymptom(
                    adverseEffectsAndData.symptomViewModel, DataToKeep.PatientId));

            _context.EventSymptomResultRegistereds.AddRange(
                AdverseEffectsAndDataHelper.BuildEventSymptomResult(
                    adverseEffectsAndData.eventSymptomResultViewModel, DataToKeep.PatientId));

            _context.Add(new AdverseEffect()
            {
                KeepSymptom = adverseEffectsAndData.KeepSymptom,
                AllergyDescription = adverseEffectsAndData.AllergyDescription,
                OtherConditions = adverseEffectsAndData.OtherConditions,
                TypeNewCancer = adverseEffectsAndData.TypeNewCancer,
                PatientId = DataToKeep.PatientId
            });

            _context.SaveChanges();
            return Redirect(@"/");
        }
    }
}
