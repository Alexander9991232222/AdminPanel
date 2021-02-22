using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanelService.Models
{
    public class User : BaseModel
    {
        [Required]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$")]
        public string Email { get; set; }

        [Required]
        [Column("USER_NAME")]
        public string UserName { get; set; }

        public string Addres { get; set; }

        public string Phone { get; set; }

        [Required]
        [MinLength(9)]
        public string Password { get; set; }

        [NotMapped]
        public byte[] Image { get; set; }
    }
}
