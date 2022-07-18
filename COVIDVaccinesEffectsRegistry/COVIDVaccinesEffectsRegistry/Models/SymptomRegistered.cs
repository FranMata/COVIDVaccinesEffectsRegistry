using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDVaccinesEffectsRegistry.Models
{
    public partial class SymptomRegistered
    {
        public int Id { get; set; }
        public int? PatientId { get; set; }
        public int? SymptomId { get; set; }

        public virtual Patient Patient { get; set; }
        public virtual Symptom Symptom { get; set; }
    }
}
