using System;
using System.Collections.Generic;

namespace Project_3.Models
{
    internal class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        // Navigation
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

        public Patient() { }
    }
}
