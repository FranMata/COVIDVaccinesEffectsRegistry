using System.ComponentModel.DataAnnotations;

namespace COVIDVaccinesEffectsRegistry.Models.ViewModels
{
    public class PatientMedicalHistoryViewModel
    {
        [Required]
        [Display(Name = "¿Ha tenido COVID previo a inyectarse?")]
        public int HadCovidprevios { get; set; }
        [Required]
        [Display(Name = "¿Ha tenido sospecha de haber tenido COVID antes de ponerte lainyección ?")]
        public int HadSuspicionCovid { get; set; }
        [Required]
        [Display(Name = "¿Ha tenido COVID después de tomar la inyección?")]
        public int HadCovidafter { get; set; }
        [Required]
        [Display(Name = "¿Razón de inyectarse contra COVID?")]
        public string Reason { get; set; }
        [Required]
        [Display(Name = "¿Estaba embarazada al inyectarse contra COVID? Si aplica")]
        public int IsPregnant { get; set; }
        [Required]
        [Display(Name = "¿Ha tenido reacciones a vacunas en el pasado?")]
        public int HadVaccineReaction { get; set; }
        [Required]
        [Display(Name = "Especifique las reacciones a vacunas en el pasado")]
        public string VaccineReactionDescription { get; set; }
        [Required]
        [Display(Name = "Medicamentos actuales con receta: enumere todos los medicamentos y las dosis")]
        public string ActualMedicine { get; set; }
        [Required]
        [Display(Name = "Nuevos medicamentos recetados que tuvieron que ser iniciados después de la(s) inyección(es) de COVID")]
        public string MedicineAfterCovidveccine { get; set; }
    }
}