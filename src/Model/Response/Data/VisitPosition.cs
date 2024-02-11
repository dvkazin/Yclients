using System.Text.Json.Serialization;

namespace Yclients.Model.Response.Data
{
	public class VisitPosition
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("title")]
		public string? Title { get; set; }
	}
}