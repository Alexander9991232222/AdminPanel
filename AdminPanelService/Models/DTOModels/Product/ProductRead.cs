using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanelService.Models.DTOModels.Product
{
    public class ProductRead
    {
        public string ProductName { get; set; }

        public string ProductType { get; set; }

        public object ProductPropertys { get; set; }
    }
}
