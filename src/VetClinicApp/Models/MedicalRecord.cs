using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VetClinicApp.Models
{
    public class MedicalRecord
    {
        [Key]
        public int RecordId { get; set; }

        public int PatientId { get; set; }
        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        public string DoctorId { get; set; } = string.Empty; // String or FK to Doctor table

        public string ItemCode { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public bool IsPublic { get; set; }
    }
}
