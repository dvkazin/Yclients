using System.Text.Json.Serialization;

namespace Yclients.Model.Response.Internationalization
{
	public class Terms
	{
		[JsonPropertyName("prefix")]
		public string? Prefix { get; set; }

		[JsonPropertyName("of-use")]
		public string? OfUse { get; set; }

		[JsonPropertyName("personal-policy")]
		public string? PersonalPolicy { get; set; }

		[JsonPropertyName("prefix-widget")]
		public string? PrefixWidget { get; set; }
	}
}