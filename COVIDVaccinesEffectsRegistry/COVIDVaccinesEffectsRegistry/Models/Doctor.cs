using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDVaccinesEffectsRegistry.Models
{
    public partial class Doctor
    {
        public Doctor()
        {
            Patients = new HashSet<Patient>();
        }

        public int Id { get; set; }
        public int? DocumentId { get; set; }
        public int? ProfessionalCode { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }
    }
}
