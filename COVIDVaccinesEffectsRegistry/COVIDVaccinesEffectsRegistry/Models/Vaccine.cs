using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDVaccinesEffectsRegistry.Models
{
    public partial class Vaccine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string AplicationDate { get; set; }
        public int? BatchNumber { get; set; }
        public string ExpirationDate { get; set; }
        public string AplicationPlace { get; set; }
        public string Observations { get; set; }
        public int? PatientId { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
