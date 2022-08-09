using COVIDVaccinesEffectsRegistry.Models;
using COVIDVaccinesEffectsRegistry.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COVIDVaccinesEffectsRegistry.Helper
{
    public static class AdverseEffectsAndDataHelper
    {
        public static List<AllergyViewModel> BuildAllergyViewModel(List<Allergy> allergies)
        {
            List<AllergyViewModel> allergiesViewModels = new List<AllergyViewModel>();

            allergies.ForEach(e =>
            {
                allergiesViewModels.Add(new AllergyViewModel()
                {
                    Id = e.Id,
                    Name = e.Name,
                    IsChecked = false
                });
            });            
            return allergiesViewModels;
        }

        public static List<AllergyRegistered> BuildAllergy(List<AllergyViewModel> allergyViewModels, int patientId)
        {
            List<AllergyRegistered> allergies = new List<AllergyRegistered>();

            List<AllergyViewModel> allergiesChecked = allergyViewModels.Where(e => e.IsChecked).ToList();

            allergiesChecked.ForEach(e =>
            {
                allergies.Add(new AllergyRegistered()
                {
                    AllergyId = e.Id,
                    PatientId = patientId
                });
            });

            return allergies;
        }

        public static List<DeseaseViewModel> BuildDeseaseViewModel(List<Disease> deseases)
        {
            List<DeseaseViewModel> deseasesViewModels = new List<DeseaseViewModel>();

            deseases.ForEach(e =>
            {
                deseasesViewModels.Add(new DeseaseViewModel()
                {
                    Id = e.Id,
                    Name = e.Name,
                    IsChecked = false
                });
            });
            return deseasesViewModels;
        }

        public static List<DiseaseRegistered> BuildDesease(List<DeseaseViewModel> deseaseViewModels, int patientId)
        {
            List<DiseaseRegistered> deseases = new List<DiseaseRegistered>();

            List<DeseaseViewModel> deseaseChecked = deseaseViewModels.Where(e => e.IsChecked).ToList();

            deseaseChecked.ForEach(e =>
            {
                deseases.Add(new DiseaseRegistered()
                {
                    DeseaseId = e.Id,
                    PatientId = patientId
                });
            });
            return deseases;
        }

        public static List<SymptomViewModel> BuildSymptomViewModel(List<Symptom> symptom)
        {
            List<SymptomViewModel> symptomViewModels = new List<SymptomViewModel>();

            symptom.ForEach(e =>
            {
                symptomViewModels.Add(new SymptomViewModel()
                {
                    Id = e.Id,
                    Name = e.Name,
                    IsChecked = false
                });
            });
            return symptomViewModels;
        }

        public static List<SymptomRegistered> BuildSymptom(List<SymptomViewModel> symptomViewModels, int patientId)
        {
            List<SymptomRegistered> symptoms = new List<SymptomRegistered>();

            List<SymptomViewModel> symptomChecked = symptomViewModels.Where(e => e.IsChecked).ToList();

            symptomChecked.ForEach(e =>
            {
                symptoms.Add(new SymptomRegistered()
                {
                    SymptomId = e.Id,
                    PatientId = patientId
                });
            });
            return symptoms;
        }

        public static List<EventSymptomResultViewModel> BuildEventSymptomResultViewModel(List<EventSymptomResult> symptom)
        {
            List<EventSymptomResultViewModel> symptomViewModels = new List<EventSymptomResultViewModel>();

            symptom.ForEach(e =>
            {
                symptomViewModels.Add(new EventSymptomResultViewModel()
                {
                    Id = e.Id,
                    Name = e.Name,
                    IsChecked = false
                });
            });
            return symptomViewModels;
        }

        public static List<EventSymptomResultRegistered> BuildEventSymptomResult(List<EventSymptomResultViewModel> eventSymptomResultViewModel, int patientId)
        {
            List<EventSymptomResultRegistered> eventSymptomResult = new List<EventSymptomResultRegistered>();

            List<EventSymptomResultViewModel> eventSymptomResultChecked = eventSymptomResultViewModel.Where(e => e.IsChecked).ToList();

            eventSymptomResultChecked.ForEach(e =>
            {
                eventSymptomResult.Add(new EventSymptomResultRegistered()
                {
                    EventSymptomResultId = e.Id,
                    PatientId = patientId
                });
            });
            return eventSymptomResult;
        }
    }   
}