using System.ComponentModel.DataAnnotations;

namespace JWTAuthDotnetAPI.Core.Dtos
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Username is Required ")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is Required ")]
        public string Password { get; set; }
    }
}
