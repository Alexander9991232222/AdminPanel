using AdminPanelService.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace AdminPanelService.Converters
{
    public class ProductPropertysConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType is JsonToken.Null) return null;

            JObject jObject = JObject.Load(reader);
            var propertys = jObject.Value<string>("ProductPropertys");
            var propJson = JObject.Parse(propertys);
            jObject["ProductPropertysObject"] = propJson;

            return System.Text.Json.JsonSerializer.Deserialize<T>(jObject.ToString());
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
