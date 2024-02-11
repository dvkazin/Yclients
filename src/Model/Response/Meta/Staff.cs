using System.Text.Json.Serialization;

namespace Yclients.Model.Response.Meta
{
	public class Staff
	{
		[JsonPropertyName("total_count")]
		public int TotalCount { get; set; }
	}
}