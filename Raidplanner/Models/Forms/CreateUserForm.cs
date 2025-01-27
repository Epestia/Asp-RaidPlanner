using System.ComponentModel.DataAnnotations;

namespace Raidplanner.Models.Forms
{
    public class CreateUserForm
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        [Compare(nameof(Password))]
        public string Confirm { get; set; }
    }
}
