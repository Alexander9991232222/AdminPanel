using AdminPanelService.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanelService.Data
{
    public enum EMessages
    {
        [StringValue("Element [{0}] was not found in DB")]
        NotFoundElement,

        [StringValue("Element [{0}] was found in DB")]
        ElementIsFound,

        [StringValue("Element [{0}] was deleted from DB")]
        ElementIsDelete,

        [StringValue("Element [{0}] was update in DB")]
        ElementIsUpdate,

        [StringValue("Elements [{0}] was found in DB")]
        ElementsIsFound
    }
}
