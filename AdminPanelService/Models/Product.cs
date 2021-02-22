using AdminPanelService.Attributes;
using AdminPanelService.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminPanelService.Models
{
    [JsonConverter(typeof(ProductPropertysConverter<Product>))]
    public class Product : BaseModel
    {
        public string ProductName { get; set; }

        public string ProductType { get; set; }
        
        public string ProductPropertys { get; set; }

        [NotMapped]
        public object ProductPropertysObject { get; set; }
    }
}
