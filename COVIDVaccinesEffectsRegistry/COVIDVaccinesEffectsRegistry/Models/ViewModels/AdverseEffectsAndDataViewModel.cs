using COVIDVaccinesEffectsRegistry.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COVIDVaccinesEffectsRegistry.Models.ViewModels
{
    public class AdverseEffectsAndDataViewModel
    {
        [Display(Name = "¿Se mantiene los síntomas?")]
        public int KeepSymptom { get; set; }

        [Display(Name = "Descripción de alergias conocidas")]
        public string AllergyDescription { get; set; }

        [Display(Name = "Especifique otras condiciones")]
        public string OtherConditions { get; set; }

        [Display(Name = "¿Si ha desarrollado un nuevo cáncer o la reaparición de un cáncer existente después de la inyección de COVID, especifique el tipo de cáncer ?")]
        public string TypeNewCancer { get; set; }
        public List<AllergyViewModel> allergyViewModels { get; set; }
        public List<DeseaseViewModel> deseaseViewModel { get; set; }
        public List<SymptomViewModel> symptomViewModel { get; set; }
    }    
}
