using System.ComponentModel.DataAnnotations;

namespace MidTerm.Models
{
    public class UserInfo
    {
        [Required]
        public int UserInfoId { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(10)]
        public string UserDB { get; set; }

        public string Bio { get; set; }

        public string Disability { get; set; }

        [Required]
        public string Gender { get; set; }

        
    }
}