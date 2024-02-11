using System.Text.Json;
using System.Text.Json.Serialization;

namespace Yclients.Converter
{
	public class IntToBoolJsonConverter : JsonConverter<bool>
	{
		public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => reader.GetByte().ToString() == "1";

		public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options) => writer.WriteNumberValue(value ? 1 : 0);
	}
}