using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDVaccinesEffectsRegistry.Models
{
    public partial class Disease
    {
        public Disease()
        {
            DiseaseRegistereds = new HashSet<DiseaseRegistered>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DiseaseRegistered> DiseaseRegistereds { get; set; }
    }
}
