using System.Text.Json.Serialization;

namespace Yclients.Model.Response.Data
{
	public class Staff
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("name")]
		public string? Name { get; set; }

		[JsonPropertyName("company_id")]
		public int CompanyId { get; set; }

		[JsonPropertyName("specialization")]
		public string? Specialization { get; set; }

		[JsonPropertyName("avatar")]
		public string? Avatar { get; set; }

		[JsonPropertyName("avatar_big")]
		public string? AvatarBig { get; set; }

		[JsonPropertyName("fired")]
		public int Fired { get; set; }

		[JsonPropertyName("status")]
		public int Status { get; set; }

		[JsonPropertyName("hidden")]
		public int Hidden { get; set; }

		[JsonPropertyName("position")]
		public Position? Position { get; set; }
	}
}