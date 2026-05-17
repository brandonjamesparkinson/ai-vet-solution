using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VetClinicApp.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        public int PatientId { get; set; }
        [ForeignKey("PatientId")]
        public Patient? Patient { get; set; }

        public int DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public Doctor? Doctor { get; set; }

        public DateTime StartTime { get; set; } = DateTime.Today.AddHours(9); // Default to 9 AM today
        public int DurationMinutes { get; set; } = 30;

        public string AppointmentType { get; set; } = string.Empty; // Checkup, Surgery, Follow-up
        public string Status { get; set; } = "Scheduled"; // Scheduled, Checked-In, Completed, Cancelled
        
        public string Notes { get; set; } = string.Empty;
    }
}
