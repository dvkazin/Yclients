using System.Text.Json.Serialization;

namespace Yclients.Model.Response.Data
{
	public class CompanySocial
	{
		[JsonPropertyName("facebook")]
		public string? Facebook { get; set; }

		[JsonPropertyName("vk")]
		public string? Vk { get; set; }

		[JsonPropertyName("instagram")]
		public string? Instagram { get; set; }

		[JsonPropertyName("telegram")]
		public string? Telegram { get; set; }

		[JsonPropertyName("whatsapp")]
		public string? WhatsApp { get; set; }

		[JsonPropertyName("viber")]
		public string? Viber { get; set; }
	}
}