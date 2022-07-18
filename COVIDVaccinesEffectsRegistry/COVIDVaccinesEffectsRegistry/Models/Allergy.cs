using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDVaccinesEffectsRegistry.Models
{
    public partial class Allergy
    {
        public Allergy()
        {
            AllergyRegistereds = new HashSet<AllergyRegistered>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AllergyRegistered> AllergyRegistereds { get; set; }
    }
}
