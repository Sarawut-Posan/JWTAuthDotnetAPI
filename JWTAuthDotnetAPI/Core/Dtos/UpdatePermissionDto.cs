using System.ComponentModel.DataAnnotations;

namespace JWTAuthDotnetAPI.Core.Dtos
{
    public class UpdatePermissionDto
    {
        [Required(ErrorMessage = "Username is Required ")]
        public string Username { get; set; }

    }
}
