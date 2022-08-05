using System;
using System.ComponentModel.DataAnnotations;

namespace COVIDVaccinesEffectsRegistry.Models.ViewModels
{
    public class VaccineViewModel
    {
        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Marca")]
        public string Brand { get; set; }
        [Required]
        [Display(Name = "Fecha de aplicacion")]
        public DateTime AplicationDate { get; set; }
        [Required]
        [Display(Name = "Numero de lote")]
        public int? BatchNumber { get; set; }
        [Required]
        [Display(Name = "Fecha de expiracion")]
        public DateTime ExpirationDate { get; set; }
        [Required]
        [Display(Name = "Lugar de aplicacion")]
        public string AplicationPlace { get; set; }
        [Required]
        [Display(Name = "Observasiones")]
        public string Observations { get; set; }
    }
}
