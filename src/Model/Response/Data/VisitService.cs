using System.Text.Json.Serialization;

namespace Yclients.Model.Response.Data
{
	public class VisitService
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("title")]
		public string? Title { get; set; }

		[JsonPropertyName("cost")]
		public float Cost { get; set; }

		[JsonPropertyName("cost_to_pay")]
		public int CostToPay { get; set; }

		[JsonPropertyName("manual_cost")]
		public int ManualCost { get; set; }

		[JsonPropertyName("cost_per_unit")]
		public int CostPerUnit { get; set; }

		[JsonPropertyName("discount")]
		public float Discount { get; set; }

		[JsonPropertyName("first_cost")]
		public float FirstCost { get; set; }

		[JsonPropertyName("amount")]
		public int Amount { get; set; }
	}
}