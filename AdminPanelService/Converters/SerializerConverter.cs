using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Linq.Expressions;
using System.Text.Json;

namespace AdminPanelService.Converters
{
    class SerializerConverter : ValueConverter<string, object>
    {
        public SerializerConverter(ConverterMappingHints mappingHints = default)
            : base(DeserializeProp, SerializeProp, mappingHints)
        { }

        static Expression<Func<object, string>> SerializeProp = (x) => _serializeObject(x);

        static Expression<Func<string, object>> DeserializeProp = x => _deserializeObject(x);

        private static string _serializeObject(object x) => JsonSerializer.Serialize(x);
        private static object _deserializeObject(string x) => JsonSerializer.Deserialize<object>(x);
    }
}
