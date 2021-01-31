using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanelService.Models
{
    public class User : BaseModel
    {
        public string Email { get; set; }

        [Column("USER_NAME")]
        public string UserName { get; set; }

        public string Addres { get; set; }

        public string Phone { get; set; }

        public string Password { get; set; }

        [Column("ID_IMAGE_FOREIGN")]
        public int? IdImage { get; set; }
    }
}
