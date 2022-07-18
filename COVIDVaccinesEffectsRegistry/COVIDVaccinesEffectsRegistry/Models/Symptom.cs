using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDVaccinesEffectsRegistry.Models
{
    public partial class Symptom
    {
        public Symptom()
        {
            SymptomRegistereds = new HashSet<SymptomRegistered>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<SymptomRegistered> SymptomRegistereds { get; set; }
    }
}
