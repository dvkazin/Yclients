using System.Text.Json.Serialization;

namespace Yclients.Model.Response.Meta
{
	public class Record
	{
		[JsonPropertyName("page")]
		public int Page { get; set; }

		[JsonPropertyName("total_count")]
		public int TotalCount { get; set; }
	}
}