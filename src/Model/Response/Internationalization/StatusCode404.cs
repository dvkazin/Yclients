using System.Text.Json.Serialization;

namespace Yclients.Model.Response.Internationalization
{
	public class StatusCode404
	{
		[JsonPropertyName("not-found")]
		public string? NotFound { get; set; }

		[JsonPropertyName("not-found-record")]
		public string? NotFoundRecord { get; set; }

		[JsonPropertyName("go-home")]
		public string? GoHome { get; set; }
	}
}