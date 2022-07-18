using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDVaccinesEffectsRegistry.Models
{
    public partial class AdverseEffect
    {
        public int Id { get; set; }
        public int? KeepSymptom { get; set; }
        public string AllergyDescription { get; set; }
        public string OtherConditions { get; set; }
        public string TypeNewCancer { get; set; }
        public int? PatientId { get; set; }

        public virtual Answer KeepSymptomNavigation { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
