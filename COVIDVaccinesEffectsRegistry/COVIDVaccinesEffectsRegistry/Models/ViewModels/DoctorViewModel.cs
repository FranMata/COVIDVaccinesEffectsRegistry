using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace COVIDVaccinesEffectsRegistry.Models
{
    public partial class DoctorViewModel
    {
        public int? Id { get; set; }

        [Required]
        [Display(Name = "Identificación")]
        public int? DocumentId { get; set; }

        [Required]
        [Display(Name = "Código profesional")]
        public int? ProfessionalCode { get; set; }

        [Required]
        [Display(Name = "Nombre completo")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Correo electrónico")]
        [RegularExpression("^[A-Za-z0-9._%+-]*@[A-Za-z0-9.-]*\\.[A-Za-z0-9-]{2,}$", 
            ErrorMessage ="Formato incorrecto")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "País")]
        public string Country { get; set; }

        [Required]
        [Display(Name = "Estado/Provincia")]
        public string Province { get; set; }
    }
}
