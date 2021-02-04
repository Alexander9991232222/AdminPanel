using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanelService.Models.DTOModels.User
{
    public class UserCreate
    {
        public string Email { get; set; }

        [Column("USER_NAME")]
        public string UserName { get; set; }

        public string Addres { get; set; }

        public string Phone { get; set; }

        public string Password { get; set; }

        public byte[] Image { get; set; }
    }
}
