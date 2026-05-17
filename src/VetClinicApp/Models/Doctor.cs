using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VetClinicApp.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Specialty { get; set; } = string.Empty;

        // Navigation property
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
