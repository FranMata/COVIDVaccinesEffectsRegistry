using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDVaccinesEffectsRegistry.Models
{
    public partial class DiseaseRegistered
    {
        public int Id { get; set; }
        public int? PatientId { get; set; }
        public int? DeseaseId { get; set; }

        public virtual Disease Desease { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
