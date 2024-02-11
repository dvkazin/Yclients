using System.Text.Json.Serialization;

namespace Yclients.Model.Response.Data
{
	public class VisitStaff
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("api_id")]
		public object? ApiId { get; set; }

		[JsonPropertyName("name")]
		public string? Name { get; set; }

		[JsonPropertyName("specialization")]
		public string? Specialization { get; set; }

		[JsonPropertyName("position")]
		public VisitPosition? Position { get; set; }

		[JsonPropertyName("avatar")]
		public string? Avatar { get; set; }

		[JsonPropertyName("avatar_big")]
		public string? AvatarBig { get; set; }

		[JsonPropertyName("rating")]
		public double? Rating { get; set; }

		[JsonPropertyName("votes_count")]
		public int VotesCount { get; set; }
	}
}