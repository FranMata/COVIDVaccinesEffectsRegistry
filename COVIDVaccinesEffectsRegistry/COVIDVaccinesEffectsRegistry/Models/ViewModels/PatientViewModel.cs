using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COVIDVaccinesEffectsRegistry.Models.ViewModels
{
    public class PatientViewModel
    {
        [Required]
        [Display(Name = "Cedula")]
        public int? DocumentId { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Apellido")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime BirthDate { get; set; }
        [Required]
        [Display(Name = "Sexo")]
        public string? Gender { get; set; }
        [Required]
        [Display(Name = "Numero de contacto")]
        public int? ContactNumber { get; set; }
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
        [Display(Name = "Estado civil")]
        public int? MaritalStatus { get; set; }
        [Required]
        [Display(Name = "Correo electronico")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Fecha de registro")]
        public DateTime RegistryDate { get; set; }
        [Required]
        [Display(Name = "Ocupacion")]
        public string Occupation { get; set; }        
        public int? DoctorId { get; set; }        
        public int? ClinicId { get; set; }
    }
}
