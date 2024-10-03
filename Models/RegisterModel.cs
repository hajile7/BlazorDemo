using System.ComponentModel.DataAnnotations;
namespace BlazorPractice.Models 
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "First Name is Required.")]
        [StringLength(25, ErrorMessage = "First Name may not exceed 25 characters")]
        public string FirstName { get; set;} = string.Empty;

        [Required(ErrorMessage = "Last Name is Required.")]
        public string LastName { get; set;} = string.Empty;

        [Required(ErrorMessage = "Username is Required.")]
        public string Username { get; set;} = string.Empty;

        [Required(ErrorMessage = "Password is Required.")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Confirmation Password is Required.")]
        public string ConfirmPassword { get; set; } = string.Empty;
    
    }
}
