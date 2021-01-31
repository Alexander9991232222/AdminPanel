using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanelService.Models
{
    public class ImageAvatar : BaseModel
    {
        [Column("ID_USER_FOREIGN")]
        public int? IdUser { get; set; }

        [Column("NAME_IMAGE")]
        public string NameImage { get; set; }

        [Column("ORIGENAL_FORMAT")]
        public string ImageFormat { get; set; }

        public byte[] Image { get; set; } 
    }
}
