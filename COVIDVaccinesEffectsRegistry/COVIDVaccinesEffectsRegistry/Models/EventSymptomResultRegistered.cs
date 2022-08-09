using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDVaccinesEffectsRegistry.Models
{
    public partial class EventSymptomResultRegistered
    {
        public int Id { get; set; }
        public int? PatientId { get; set; }
        public int? EventSymptomResultId { get; set; }

        public virtual EventSymptomResult EventSymptomResult { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
