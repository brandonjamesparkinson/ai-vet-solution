using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VetClinicApp.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }

        public string Title { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string County { get; set; } = string.Empty;

        public string HomePhone { get; set; } = string.Empty;
        public string WorkPhone { get; set; } = string.Empty;
        public string CellPhone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public decimal Balance { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;

        // Navigation property
        public ICollection<Patient> Patients { get; set; } = new List<Patient>();
    }
}
