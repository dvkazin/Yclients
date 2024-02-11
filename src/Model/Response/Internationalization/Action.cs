using System.Text.Json.Serialization;

namespace Yclients.Model.Response.Internationalization
{
	public class Action
	{
		[JsonPropertyName("send")]
		public string? Send { get; set; }
	}
}