using System.ComponentModel.DataAnnotations;

namespace LoginRegistration.ViewModel
{
    public class Register
    {
        [Required]
        [DataType(DataType.EmailAddress)]
       
        public string Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(20, MinimumLength = 5)]


        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage ="Password and confirmation password do not match")]

        public string ConfirmedPassword { get; set; }





    }
}
