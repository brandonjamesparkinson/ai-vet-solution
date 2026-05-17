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

        public string Name { get; set; }
        public string Species { get; set; } // Canine, Feline, etc.
        public string Breed { get; set; }
        public string Color { get; set; }
        public string Sex { get; set; } // M, F, Neutered, Spayed
        public DateTime DateOfBirth { get; set; }
        public decimal WeightLbs { get; set; }

        public string RabiesTagNumber { get; set; }
        public string MicrochipId { get; set; }
        public string Allergies { get; set; }

        // Navigation property
        public ICollection<MedicalRecord> MedicalHistory { get; set; } = new List<MedicalRecord>();
    }
}
