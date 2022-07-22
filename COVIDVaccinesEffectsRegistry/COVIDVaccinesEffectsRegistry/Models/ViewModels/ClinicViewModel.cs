using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COVIDVaccinesEffectsRegistry.Models.ViewModels
{
    public class ClinicViewModel
    {
        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Cedula Juridica")]
        public int? TaxId { get; set; }

        [Required]
        [Display(Name = "Pais")]
        public string Country { get; set; }

        [Required]
        [Display(Name = "Provincia")]
        public string Province { get; set; }

        [Required]
        [Display(Name = "Distrito")]
        public string District { get; set; }

        [Required]
        [Display(Name = "Telefono")]
        public int? Phone { get; set; }

        [Required]
        [Display(Name = "Correo Electronico")]
        [RegularExpression("^[A-Za-z0-9._%+-]*@[A-Za-z0-9.-]*\\.[A-Za-z0-9-]{2,}$",
            ErrorMessage = "Formato incorrecto")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Pagina Web")]
        [RegularExpression(@"[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_\+.~#?&//=]*)",
            ErrorMessage = "Formato incorrecto")]
        public string Web { get; set; }
    }
}
