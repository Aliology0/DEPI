using System.ComponentModel.DataAnnotations;

namespace Day01.Models
{
    public class Course
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(50)]
        public string? Crs_name { get; set; }

        [MaxLength(150)]
        public string? crs_desc { get; set; }

        public int? Duration { get; set; }
    }
}
