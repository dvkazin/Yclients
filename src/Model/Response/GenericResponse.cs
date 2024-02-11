using System.Text.Json.Serialization;

namespace Yclients.Model.Response
{
	public class GenericResponse<TData, TMeta>
	{
		[JsonPropertyName("success")]
		public bool Success { get; set; }

		[JsonPropertyName("data")]
		public TData? Data { get; set; }

		[JsonPropertyName("meta")]
		public TMeta? Meta { get; set; }
	}
}