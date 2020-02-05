using System.ComponentModel.DataAnnotations;

namespace ForumProject.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
