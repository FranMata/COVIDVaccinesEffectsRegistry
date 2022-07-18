using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDVaccinesEffectsRegistry.Models
{
    public partial class AllergyRegistered
    {
        public int Id { get; set; }
        public int? PatientId { get; set; }
        public int? AllergyId { get; set; }

        public virtual Allergy Allergy { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
