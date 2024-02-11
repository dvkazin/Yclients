using System.Text.Json.Serialization;

namespace Yclients.Model.Response.Data
{
	public class ServiceCategory
	{
		[JsonPropertyName("sex")]
		public int Sex { get; set; }

		[JsonPropertyName("booking_title")]
		public string? BookingTitle { get; set; }

		[JsonPropertyName("is_chain")]
		public bool IsChain { get; set; }

		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("salon_service_id")]
		public int SalonServiceId { get; set; }

		[JsonPropertyName("title")]
		public string? Title { get; set; }

		[JsonPropertyName("weight")]
		public int Weight { get; set; }

		[JsonPropertyName("api_id")]
		public string? ApiId { get; set; }

		[JsonPropertyName("staff")]
		public List<int>? Staff { get; set; }
	}
}