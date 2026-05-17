using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VetClinicApp.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }

        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string County { get; set; }

        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string CellPhone { get; set; }
        public string Email { get; set; }

        public decimal Balance { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;

        // Navigation property
        public ICollection<Patient> Patients { get; set; } = new List<Patient>();
    }
}
