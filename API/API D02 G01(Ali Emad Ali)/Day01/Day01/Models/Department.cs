using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Day01.Models
{
    public class Department
    {
        [Key]
        public int StID { get; set; }

        [MaxLength(50)]
        public string? Name { get; set; }

        // Each department has many courses
        [JsonIgnore]
        public List<Course>? Courses { get; set; }
    }
}
