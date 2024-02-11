using Yclients.Converter;
using System.Text.Json.Serialization;

namespace Yclients.Model.Response.Data
{
	public class VisitRecord
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("company_id")]
		public int CompanyId { get; set; }

		[JsonPropertyName("staff_id")]
		public int StaffId { get; set; }

		[JsonPropertyName("services")]
		public List<VisitService>? Services { get; set; }

		[JsonPropertyName("goods_transactions")]
		public List<object>? GoodsTransactions { get; set; }

		[JsonPropertyName("staff")]
		public VisitStaff? Staff { get; set; }

		[JsonPropertyName("client")]
		public VisitClient? Client { get; set; }

		[JsonPropertyName("comer")]
		public object? Comer { get; set; }

		[JsonPropertyName("clients_count")]
		public int ClientsCount { get; set; }

		[JsonPropertyName("date")]
		public string? Date { get; set; }

		[JsonPropertyName("datetime")]
		public string? Datetime { get; set; }

		[JsonPropertyName("create_date")]
		public string? CreateDate { get; set; }

		[JsonPropertyName("comment")]
		public string? Comment { get; set; }

		[JsonPropertyName("online")]
		public bool Online { get; set; }

		[JsonPropertyName("visit_attendance")]
		public int VisitAttendance { get; set; }

		[JsonPropertyName("attendance")]
		public int Attendance { get; set; }

		[JsonPropertyName("confirmed")]
		public int Confirmed { get; set; }

		[JsonPropertyName("seance_length")]
		public int SeanceLength { get; set; }

		[JsonPropertyName("length")]
		public int Length { get; set; }

		[JsonPropertyName("sms_before")]
		[JsonConverter(typeof(IntToBoolJsonConverter))]
		public bool SmsBefore { get; set; }

		[JsonPropertyName("sms_now")]
		public int SmsNow { get; set; }

		[JsonPropertyName("sms_now_text")]
		public string? SmsNowText { get; set; }

		[JsonPropertyName("email_now")]
		public int EmailNow { get; set; }

		[JsonPropertyName("notified")]
		public int Notified { get; set; }

		[JsonPropertyName("master_request")]
		public int MasterRequest { get; set; }

		[JsonPropertyName("api_id")]
		public string? ApiId { get; set; }

		[JsonPropertyName("from_url")]
		public string? FromUrl { get; set; }

		[JsonPropertyName("review_requested")]
		public int ReviewRequested { get; set; }

		[JsonPropertyName("visit_id")]
		public int VisitId { get; set; }

		[JsonPropertyName("created_user_id")]
		public int CreatedUserId { get; set; }

		[JsonPropertyName("deleted")]
		public bool Deleted { get; set; }

		[JsonPropertyName("paid_full")]
		public int PaidFull { get; set; }

		[JsonPropertyName("prepaid")]
		public bool Prepaid { get; set; }

		[JsonPropertyName("prepaid_confirmed")]
		public bool PrepaidConfirmed { get; set; }

		[JsonPropertyName("last_change_date")]
		public string? LastChangeDate { get; set; }

		[JsonPropertyName("custom_color")]
		public string? CustomColor { get; set; }

		[JsonPropertyName("custom_font_color")]
		public string? CustomFontColor { get; set; }

		[JsonPropertyName("record_labels")]
		public List<object>? RecordLabels { get; set; }

		[JsonPropertyName("activity_id")]
		public int ActivityId { get; set; }

		[JsonPropertyName("custom_fields")]
		public List<object>? CustomFields { get; set; }

		[JsonPropertyName("documents")]
		public List<VisitDocument>? Documents { get; set; }

		[JsonPropertyName("sms_remain_hours")]
		public int SmsRemainHours { get; set; }

		[JsonPropertyName("email_remain_hours")]
		public int EmailRemainHours { get; set; }

		[JsonPropertyName("bookform_id")]
		public int BookformId { get; set; }

		[JsonPropertyName("record_from")]
		public string? RecordFrom { get; set; }

		[JsonPropertyName("is_mobile")]
		public int IsMobile { get; set; }

		[JsonPropertyName("payment_status")]
		public int PaymentStatus { get; set; }
	 }
}