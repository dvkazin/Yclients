using System.Text.Json.Serialization;

namespace Yclients.Model.Response.Data
{
	public class RecordDocument
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("type_id")]
		public int TypeId { get; set; }

		[JsonPropertyName("storage_id")]
		public int StorageId { get; set; }

		[JsonPropertyName("user_id")]
		public int UserId { get; set; }

		[JsonPropertyName("company_id")]
		public int CompanyId { get; set; }

		[JsonPropertyName("number")]
		public int Number { get; set; }

		[JsonPropertyName("comment")]
		public string? Comment { get; set; }

		[JsonPropertyName("date_created")]
		public string? DateCreated { get; set; }

		[JsonPropertyName("category_id")]
		public int CategoryId { get; set; }

		[JsonPropertyName("visit_id")]
		public int VisitId { get; set; }

		[JsonPropertyName("record_id")]
		public int RecordId { get; set; }

		[JsonPropertyName("type_title")]
		public string? TypeTitle { get; set; }
	}
}