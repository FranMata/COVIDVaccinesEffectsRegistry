using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDVaccinesEffectsRegistry.Models
{
    public partial class Answer
    {
        public Answer()
        {
            AdverseEffects = new HashSet<AdverseEffect>();
            PatientMedicalHistoryHadCovidafterNavigations = new HashSet<PatientMedicalHistory>();
            PatientMedicalHistoryHadCovidpreviosNavigations = new HashSet<PatientMedicalHistory>();
            PatientMedicalHistoryHadSuspicionCovs = new HashSet<PatientMedicalHistory>();
            PatientMedicalHistoryHadVaccineReactionNavigations = new HashSet<PatientMedicalHistory>();
            PatientMedicalHistoryIsPregnantNavigations = new HashSet<PatientMedicalHistory>();
        }

        public int Id { get; set; }
        public string Aswer { get; set; }

        public virtual ICollection<AdverseEffect> AdverseEffects { get; set; }
        public virtual ICollection<PatientMedicalHistory> PatientMedicalHistoryHadCovidafterNavigations { get; set; }
        public virtual ICollection<PatientMedicalHistory> PatientMedicalHistoryHadCovidpreviosNavigations { get; set; }
        public virtual ICollection<PatientMedicalHistory> PatientMedicalHistoryHadSuspicionCovs { get; set; }
        public virtual ICollection<PatientMedicalHistory> PatientMedicalHistoryHadVaccineReactionNavigations { get; set; }
        public virtual ICollection<PatientMedicalHistory> PatientMedicalHistoryIsPregnantNavigations { get; set; }
    }
}
