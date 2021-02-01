using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanelService.Models.DTOModels.User
{
    public class UserRead : BaseModel
    {
        public string Email { get; set; }

        public string UserName { get; set; }

        public string Addres { get; set; }

        public string Phone { get; set; }

        public string Password { get; set; }

        public byte[] Image { get; set; }
    }
}
