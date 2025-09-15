using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3.Models
{
    internal class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }

        // Navigation
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

        public Doctor() { }
    }
}
