using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using CellarManager.model;

namespace CellarManager
{
    internal class BeverageConverter : JsonConverter<Beverage>
    {
        public override Beverage Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using var doc = JsonDocument.ParseValue(ref reader);
            var root = doc.RootElement;

            string type = root.GetProperty("TypeName").GetString() ?? "";

            return type switch
            {
                "Beer" => JsonSerializer.Deserialize<Beer>(root.GetRawText(), options)!,
                "Wine" => JsonSerializer.Deserialize<Wine>(root.GetRawText(), options)!,
                _ => throw new NotSupportedException($"Type '{type}' is not supported"),
            };
        }

        public override void Write(Utf8JsonWriter writer, Beverage value, JsonSerializerOptions options)
        {
            var type = value is Beer ? "Beer" : value is Wine ? "Wine" : "Unknown";
            using var doc = JsonDocument.Parse(JsonSerializer.Serialize(value, value.GetType(), options));
            writer.WriteStartObject();
            writer.WriteString("TypeName", type);
            foreach (var prop in doc.RootElement.EnumerateObject())
            {
                prop.WriteTo(writer);
            }
            writer.WriteEndObject();
        }
    }
}
