using System.ComponentModel.DataAnnotations;

namespace Company_System.ViewModel
{
    public class AdminRegisterViewModel
    {
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required, DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Required]
        public string FullName { get; set; } = string.Empty;

        public List<string>? Roles { get; set; }
        [Required(ErrorMessage = "Please select a role")]
        public string? SelectedRole { get; set; }
    }
}
