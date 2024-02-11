using System.Text.Json.Serialization;

namespace Yclients.Model.Response.Internationalization
{
	public class Tips
	{
		[JsonPropertyName("terms")]
		public Terms Terms { get; set; }

		[JsonPropertyName("review-sent")]
		public string? ReviewSent { get; set; }

		[JsonPropertyName("your-mark")]
		public string? YourMark { get; set; }

		[JsonPropertyName("leave-a-review")]
		public string? LeaveAReview { get; set; }

		[JsonPropertyName("leave-a-tip-to-a-specialist")]
		public string? LeaveATipToASpecialist { get; set; }

		[JsonPropertyName("credited")]
		public string? Credited { get; set; }

		[JsonPropertyName("visit-amount")]
		public string? VisitAmount { get; set; }

		[JsonPropertyName("will-be-written-off")]
		public string? WillBeWrittenOff { get; set; }

		[JsonPropertyName("at-time")]
		public string? AtTime { get; set; }

		[JsonPropertyName("rate-specialist-to-sent-feedback")]
		public string? RateSpecialistToSentFeedback { get; set; }

		[JsonPropertyName("title")]
		public string? Title { get; set; }

		[JsonPropertyName("tips-required")]
		public string? TipsRequired { get; set; }

		[JsonPropertyName("review-or-tips-required")]
		public string? ReviewOrTipsRequired { get; set; }

		[JsonPropertyName("enter-sum")]
		public string? EnterSum { get; set; }

		[JsonPropertyName("custom-sum")]
		public string? CustomSum { get; set; }

		[JsonPropertyName("cancel-tips")]
		public string? CancelTips { get; set; }

		[JsonPropertyName("bad-sum")]
		public string? BadSum { get; set; }

		[JsonPropertyName("max-sum")]
		public string? MaxSum { get; set; }

		[JsonPropertyName("payment-by-card")]
		public string? PaymentByCard { get; set; }

		[JsonPropertyName("commission-title")]
		public string? CommissionTitle { get; set; }

		[JsonPropertyName("commission-description")]
		public string? CommissionDescription { get; set; }

		[JsonPropertyName("payment-by-card-button")]
		public string? PaymentByCardButton { get; set; }
	}
}