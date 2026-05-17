using Microsoft.EntityFrameworkCore;
using VetClinicApp.Models;

namespace VetClinicApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<InventoryItem> InventoryItems { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Ensure ItemCode is unique in Inventory
            modelBuilder.Entity<InventoryItem>()
                .HasIndex(i => i.ItemCode)
                .IsUnique();

            // Configure relationships for Appointments
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Patient)
                .WithMany()
                .HasForeignKey(a => a.PatientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Doctor)
                .WithMany(d => d.Appointments)
                .HasForeignKey(a => a.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Client>()
                .Property(c => c.Balance)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Patient>()
                .Property(p => p.WeightLbs)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<MedicalRecord>()
                .Property(m => m.Amount)
                .HasColumnType("decimal(18,2)");
        }
    }
}
