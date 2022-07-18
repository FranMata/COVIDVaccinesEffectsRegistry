using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDVaccinesEffectsRegistry.Models
{
    public partial class PatientMedicalHistory
    {
        public int Id { get; set; }
        public int? HadCovidprevios { get; set; }
        public int? HadSuspicionCovid { get; set; }
        public int? HadCovidafter { get; set; }
        public string Reason { get; set; }
        public int? IsPregnant { get; set; }
        public int? HadVaccineReaction { get; set; }
        public string VaccineReactionDescription { get; set; }
        public string ActualMedicine { get; set; }
        public string MedicineAfterCovidveccine { get; set; }
        public int? PatientId { get; set; }

        public virtual Answer HadCovidafterNavigation { get; set; }
        public virtual Answer HadCovidpreviosNavigation { get; set; }
        public virtual Answer HadSuspicionCov { get; set; }
        public virtual Answer HadVaccineReactionNavigation { get; set; }
        public virtual Answer IsPregnantNavigation { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
