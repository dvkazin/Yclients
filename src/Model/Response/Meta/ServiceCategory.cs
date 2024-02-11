using System.Text.Json.Serialization;

namespace Yclients.Model.Response.Meta
{
	public class ServiceCategory
	{
		[JsonPropertyName("total_count")]
		public int TotalCount { get; set; }
	}
}