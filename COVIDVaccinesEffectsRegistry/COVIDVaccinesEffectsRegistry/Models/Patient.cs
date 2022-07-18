using System;
using System.Collections.Generic;

#nullable disable

namespace COVIDVaccinesEffectsRegistry.Models
{
    public partial class Patient
    {
        public Patient()
        {
            AdverseEffects = new HashSet<AdverseEffect>();
            AllergyRegistereds = new HashSet<AllergyRegistered>();
            DiseaseRegistereds = new HashSet<DiseaseRegistered>();
            PatientMedicalHistories = new HashSet<PatientMedicalHistory>();
            SymptomRegistereds = new HashSet<SymptomRegistered>();
            Vaccines = new HashSet<Vaccine>();
        }

        public int Id { get; set; }
        public int? DocumentId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public int? Gender { get; set; }
        public int? ContactNumber { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public int? MaritalStatus { get; set; }
        public string Email { get; set; }
        public string RegistryDate { get; set; }
        public string Occupation { get; set; }
        public int? DoctorId { get; set; }
        public int? ClinicId { get; set; }

        public virtual Clinic Clinic { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual ICollection<AdverseEffect> AdverseEffects { get; set; }
        public virtual ICollection<AllergyRegistered> AllergyRegistereds { get; set; }
        public virtual ICollection<DiseaseRegistered> DiseaseRegistereds { get; set; }
        public virtual ICollection<PatientMedicalHistory> PatientMedicalHistories { get; set; }
        public virtual ICollection<SymptomRegistered> SymptomRegistereds { get; set; }
        public virtual ICollection<Vaccine> Vaccines { get; set; }
    }
}
