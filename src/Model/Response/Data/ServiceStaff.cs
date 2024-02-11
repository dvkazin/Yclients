using System.Text.Json.Serialization;

namespace Yclients.Model.Response.Data
{
	public class ServiceStaff
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("seance_length")]
		public int SeanceLength { get; set; }

		[JsonPropertyName("technological_card_id")]
		public int TechnologicalCardId { get; set; }

		[JsonPropertyName("image_url")]
		public string? ImageUrl { get; set; }

		[JsonPropertyName("name")]
		public string? Name { get; set; }
	}
}