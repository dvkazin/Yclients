using System.Text.Json.Serialization;

namespace Yclients.Model.Response.Data
{
	public class Service
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("booking_title")]
		public string? BookingTitle { get; set; }
		
		[JsonPropertyName("tax_variant")]
		public int? TaxVariant { get; set; }

		[JsonPropertyName("vat_id")]
		public int? VatId { get; set; }

		[JsonPropertyName("print_title")]
		public string? PrintTitle { get; set; }

		[JsonPropertyName("service_type")]
		public int ServiceType { get; set; }

		[JsonPropertyName("api_service_id")]
		public int ApiServiceId { get; set; }

		[JsonPropertyName("repeat_visit_days_step")]
		public object? RepeatVisitDaysStep { get; set; }

		[JsonPropertyName("seance_search_start")]
		public int SeanceSearchStart { get; set; }

		[JsonPropertyName("seance_search_finish")]
		public int SeanceSearchFinish { get; set; }

		[JsonPropertyName("seance_search_step")]
		public int SeanceSearchStep { get; set; }

		[JsonPropertyName("step")]
		public int Step { get; set; }

		[JsonPropertyName("is_need_limit_date")]
		public bool IsNeedLimitDate { get; set; }

		[JsonPropertyName("date_from")]
		public string? DateFrom { get; set; }

		[JsonPropertyName("date_to")]
		public string? DateTo { get; set; }

		[JsonPropertyName("schedule_template_type")]
		public int ScheduleTemplateType { get; set; }

		[JsonPropertyName("online_invoicing_status")]
		public int OnlineInvoicingStatus { get; set; }

		[JsonPropertyName("is_abonement_autopayment_enabled")]
		public int IsAbonementAutopaymentEnabled { get; set; }

		[JsonPropertyName("autopayment_before_visit_time")]
		public int AutopaymentBeforeVisitTime { get; set; }

		[JsonPropertyName("abonement_restriction_value")]
		public int AbonementRestrictionValue { get; set; }

		[JsonPropertyName("is_chain")]
		public bool IsChain { get; set; }

		[JsonPropertyName("is_price_managed_only_in_chain")]
		public bool IsPriceManagedOnlyInChain { get; set; }

		[JsonPropertyName("is_omment_managed_only_in_chain")]
		public bool IsOmmentManagedOnlyInChain { get; set; }

		[JsonPropertyName("price_prepaid_amount")]
		public int PricePrepaidAmount { get; set; }

		[JsonPropertyName("price_prepaid_percent")]
		public int PricePrepaidPercent { get; set; }

		[JsonPropertyName("salon_service_id")]
		public int SalonServiceId { get; set; }
		
		[JsonPropertyName("title")]
		public string? Title { get; set; }

		[JsonPropertyName("category_id")]
		public int CategoryId { get; set; }

		[JsonPropertyName("price_min")]
		public int PriceMin { get; set; }

		[JsonPropertyName("price_max")]
		public int OriceMax { get; set; }

		[JsonPropertyName("discoun")]
		public float Discount { get; set; }

		[JsonPropertyName("comment")]
		public string? Comment { get; set; }

		[JsonPropertyName("weight")]
		public int Weight { get; set; }

		[JsonPropertyName("active")]
		public int Active { get; set; }

		[JsonPropertyName("api_id")]
		public string? ApiId { get; set; }

		[JsonPropertyName("prepaid")]
		public string? Prepaid { get; set; }

		[JsonPropertyName("is_multi")]
		public bool IsMulti { get; set; }

		[JsonPropertyName("capacity")]
		public int Capacity { get; set; }

		[JsonPropertyName("image_group")]
		public List<object>? ImageGroup { get; set; }

		[JsonPropertyName("staff")]
		public List<ServiceStaff>? Staff { get; set; }

		[JsonPropertyName("dates")]
		public List<object>? Dates { get; set; }

		[JsonPropertyName("duration")]
		public int Duration { get; set; }

		[JsonPropertyName("resources")]
		public List<object>? Resources { get; set; }

		[JsonPropertyName("is_online")]
		public bool IsOnline { get; set; }
	}
}