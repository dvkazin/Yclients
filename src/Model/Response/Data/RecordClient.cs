using System.Text.Json.Serialization;

namespace Yclients.Model.Response.Data
{
	public class RecordClient
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }
		
		[JsonPropertyName("name")]
		public string? Name { get; set; }

		[JsonPropertyName("phone")]
		public string? Phone { get; set; }

		[JsonPropertyName("card")]
		public string? Card { get; set; }

		[JsonPropertyName("email")]
		public string? Email { get; set; }

		[JsonPropertyName("success_visits_count")]
		public int SuccessVisitsCount { get; set; }

		[JsonPropertyName("fail_visits_count")]
		public int FailVisitsCount { get; set; }

		[JsonPropertyName("discount")]
		public float Discount { get; set; }

		[JsonPropertyName("is_new")]
		public bool IsNew { get; set; }

		[JsonPropertyName("custom_fields")]
		public List<object>? CustomFields { get; set; }
	}
}