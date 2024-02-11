using System.Text.Json.Serialization;

namespace Yclients.Model.Response.Meta
{
	public class Service
	{
		[JsonPropertyName("total_count")]
		public int TotalCount { get; set; }
	}
}