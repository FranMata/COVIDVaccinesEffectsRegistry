using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace COVIDVaccinesEffectsRegistry.Models
{
    public partial class COVIDVaccinesEffectsContext : DbContext
    {
        public COVIDVaccinesEffectsContext()
        {
        }

        public COVIDVaccinesEffectsContext(DbContextOptions<COVIDVaccinesEffectsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdverseEffect> AdverseEffects { get; set; }
        public virtual DbSet<Allergy> Allergies { get; set; }
        public virtual DbSet<AllergyRegistered> AllergyRegistereds { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Clinic> Clinics { get; set; }
        public virtual DbSet<Disease> Diseases { get; set; }
        public virtual DbSet<DiseaseRegistered> DiseaseRegistereds { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<EventSymptomResult> EventSymptomResults { get; set; }
        public virtual DbSet<EventSymptomResultRegistered> EventSymptomResultRegistereds { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<PatientMedicalHistory> PatientMedicalHistories { get; set; }
        public virtual DbSet<Symptom> Symptoms { get; set; }
        public virtual DbSet<SymptomRegistered> SymptomRegistereds { get; set; }
        public virtual DbSet<Vaccine> Vaccines { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-4GCB4GD;Database=COVIDVaccinesEffects;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdverseEffect>(entity =>
            {
                entity.ToTable("AdverseEffect");

                entity.Property(e => e.AllergyDescription).IsUnicode(false);

                entity.Property(e => e.OtherConditions).IsUnicode(false);

                entity.Property(e => e.TypeNewCancer)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.KeepSymptomNavigation)
                    .WithMany(p => p.AdverseEffects)
                    .HasForeignKey(d => d.KeepSymptom)
                    .HasConstraintName("FK__AdverseEf__KeepS__398D8EEE");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.AdverseEffects)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__AdverseEf__Patie__38996AB5");
            });

            modelBuilder.Entity<Allergy>(entity =>
            {
                entity.ToTable("Allergy");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AllergyRegistered>(entity =>
            {
                entity.ToTable("AllergyRegistered");

                entity.HasOne(d => d.Allergy)
                    .WithMany(p => p.AllergyRegistereds)
                    .HasForeignKey(d => d.AllergyId)
                    .HasConstraintName("FK__AllergyRe__Aller__4E88ABD4");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.AllergyRegistereds)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__AllergyRe__Patie__4F7CD00D");
            });

            modelBuilder.Entity<Answer>(entity =>
            {
                entity.Property(e => e.Aswer)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Clinic>(entity =>
            {
                entity.ToTable("Clinic");

                entity.Property(e => e.Country)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.District)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Web)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Disease>(entity =>
            {
                entity.ToTable("Disease");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DiseaseRegistered>(entity =>
            {
                entity.ToTable("DiseaseRegistered");

                entity.HasOne(d => d.Desease)
                    .WithMany(p => p.DiseaseRegistereds)
                    .HasForeignKey(d => d.DeseaseId)
                    .HasConstraintName("FK__DiseaseRe__Desea__4AB81AF0");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.DiseaseRegistereds)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__DiseaseRe__Patie__4BAC3F29");
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.ToTable("Doctor");

                entity.Property(e => e.Country)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EventSymptomResult>(entity =>
            {
                entity.ToTable("EventSymptomResult");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EventSymptomResultRegistered>(entity =>
            {
                entity.ToTable("EventSymptomResultRegistered");

                entity.HasOne(d => d.EventSymptomResult)
                    .WithMany(p => p.EventSymptomResultRegistereds)
                    .HasForeignKey(d => d.EventSymptomResultId)
                    .HasConstraintName("FK__EventSymp__Event__5EBF139D");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.EventSymptomResultRegistereds)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__EventSymp__Patie__5FB337D6");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("Patient");

                entity.Property(e => e.BirthDate)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.District)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Occupation)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.RegistryDate)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.HasOne(d => d.Clinic)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.ClinicId)
                    .HasConstraintName("FK__Patient__ClinicI__29572725");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK__Patient__DoctorI__286302EC");
            });

            modelBuilder.Entity<PatientMedicalHistory>(entity =>
            {
                entity.ToTable("PatientMedicalHistory");

                entity.Property(e => e.ActualMedicine).IsUnicode(false);

                entity.Property(e => e.HadCovidafter).HasColumnName("HadCOVIDAfter");

                entity.Property(e => e.HadCovidprevios).HasColumnName("HadCOVIDPrevios");

                entity.Property(e => e.HadSuspicionCovid).HasColumnName("HadSuspicionCOVID");

                entity.Property(e => e.MedicineAfterCovidveccine)
                    .IsUnicode(false)
                    .HasColumnName("MedicineAfterCOVIDVeccine");

                entity.Property(e => e.Reason).IsUnicode(false);

                entity.Property(e => e.VaccineReactionDescription).IsUnicode(false);

                entity.HasOne(d => d.HadCovidafterNavigation)
                    .WithMany(p => p.PatientMedicalHistoryHadCovidafterNavigations)
                    .HasForeignKey(d => d.HadCovidafter)
                    .HasConstraintName("FK__PatientMe__HadCO__33D4B598");

                entity.HasOne(d => d.HadCovidpreviosNavigation)
                    .WithMany(p => p.PatientMedicalHistoryHadCovidpreviosNavigations)
                    .HasForeignKey(d => d.HadCovidprevios)
                    .HasConstraintName("FK__PatientMe__HadCO__31EC6D26");

                entity.HasOne(d => d.HadSuspicionCov)
                    .WithMany(p => p.PatientMedicalHistoryHadSuspicionCovs)
                    .HasForeignKey(d => d.HadSuspicionCovid)
                    .HasConstraintName("FK__PatientMe__HadSu__32E0915F");

                entity.HasOne(d => d.HadVaccineReactionNavigation)
                    .WithMany(p => p.PatientMedicalHistoryHadVaccineReactionNavigations)
                    .HasForeignKey(d => d.HadVaccineReaction)
                    .HasConstraintName("FK__PatientMe__HadVa__35BCFE0A");

                entity.HasOne(d => d.IsPregnantNavigation)
                    .WithMany(p => p.PatientMedicalHistoryIsPregnantNavigations)
                    .HasForeignKey(d => d.IsPregnant)
                    .HasConstraintName("FK__PatientMe__IsPre__34C8D9D1");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientMedicalHistories)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__PatientMe__Patie__30F848ED");
            });

            modelBuilder.Entity<Symptom>(entity =>
            {
                entity.ToTable("Symptom");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SymptomRegistered>(entity =>
            {
                entity.ToTable("SymptomRegistered");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.SymptomRegistereds)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__SymptomRe__Patie__534D60F1");

                entity.HasOne(d => d.Symptom)
                    .WithMany(p => p.SymptomRegistereds)
                    .HasForeignKey(d => d.SymptomId)
                    .HasConstraintName("FK__SymptomRe__Sympt__52593CB8");
            });

            modelBuilder.Entity<Vaccine>(entity =>
            {
                entity.ToTable("Vaccine");

                entity.Property(e => e.AplicationDate)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.AplicationPlace)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Brand)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ExpirationDate)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Observations).IsUnicode(false);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Vaccines)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__Vaccine__Patient__2C3393D0");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
