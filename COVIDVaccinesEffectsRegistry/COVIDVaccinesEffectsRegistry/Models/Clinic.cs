using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDVaccinesEffectsRegistry.Models
{
    public partial class Clinic
    {
        public Clinic()
        {
            Patients = new HashSet<Patient>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? TaxId { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public int? Phone { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }
    }
}
