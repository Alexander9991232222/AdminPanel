using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanelService.Models
{
    public abstract class BaseModel : IBaseModel
    {
        public long? Id { get; set; }
    }
}
