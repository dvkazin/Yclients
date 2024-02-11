using System.Text.Json.Serialization;

namespace Yclients.Model.Response.Data
{
	public class Visit
	{
		[JsonPropertyName("attendance")]
		public int Attendance { get; set; }

		[JsonPropertyName("datetime")]
		public DateTime Datetime { get; set; }

		[JsonPropertyName("comment")]
		public int Comment { get; set; }

		[JsonPropertyName("records")]
		public List<VisitRecord>? Records { get; set; }
	}
}