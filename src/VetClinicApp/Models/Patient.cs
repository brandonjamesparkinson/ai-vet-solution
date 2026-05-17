using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VetClinicApp.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }

        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public Client Client { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Species { get; set; } = string.Empty; // Canine, Feline, etc.
        public string Breed { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string Sex { get; set; } = string.Empty; // M, F, Neutered, Spayed
        public DateTime DateOfBirth { get; set; }
        public decimal WeightLbs { get; set; }

        public string RabiesTagNumber { get; set; } = string.Empty;
        public string MicrochipId { get; set; } = string.Empty;
        public string Allergies { get; set; } = string.Empty;

        // Navigation property
        public ICollection<MedicalRecord> MedicalHistory { get; set; } = new List<MedicalRecord>();
    }
}
