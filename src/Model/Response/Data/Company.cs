using System.Text.Json.Serialization;

namespace Yclients.Model.Response.Data
{
	public class Company
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("title")]
		public string? Title { get; set; }

		[JsonPropertyName("public_title")]
		public string? PublicTitle { get; set; }

		[JsonPropertyName("short_descr")]
		public string? ShortDescr { get; set; }

		[JsonPropertyName("logo")]
		public string? Logo { get; set; }

		[JsonPropertyName("country_id")]
		public int CountryId { get; set; }

		[JsonPropertyName("country")]
		public string? Country { get; set; }

		[JsonPropertyName("city_id")]
		public int CityId { get; set; }

		[JsonPropertyName("city")]
		public string? City { get; set; }

		[JsonPropertyName("active")]
		public int Active { get; set; }

		[JsonPropertyName("phone")]
		public string? Phone { get; set; }

		[JsonPropertyName("phones")]
		public List<string?>? Phones { get; set; }

		[JsonPropertyName("email")]
		public string? Email { get; set; }

		[JsonPropertyName("timezone")]
		public int TimeZone { get; set; }

		[JsonPropertyName("timezone_name")]
		public string? TimeZoneName { get; set; }

		[JsonPropertyName("schedule")]
		public string? Schedule { get; set; }

		[JsonPropertyName("address")]
		public string? Address { get; set; }

		[JsonPropertyName("coordinate_lat")]
		public double CoordinateLat { get; set; }

		[JsonPropertyName("coordinate_lon")]
		public double CoordinateLon { get; set; }

		[JsonPropertyName("app_ios")]
		public string? AppIos { get; set; }

		[JsonPropertyName("app_android")]
		public string? AppAndroid { get; set; }

		[JsonPropertyName("phone_confirmation")]
		public bool PhoneConfirmation { get; set; }

		[JsonPropertyName("currency_short_title")]
		public string? CurrencyShortTitle { get; set; }

		[JsonPropertyName("reminds_sms_disabled")]
		public bool RemindsSmsDisabled { get; set; }

		[JsonPropertyName("reminds_sms_default")]
		public int RemindsSmsDefault { get; set; }

		[JsonPropertyName("group_priority")]
		public int GroupPriority { get; set; }

		[JsonPropertyName("bookform_group_priority")]
		public int BookformGroupPriority { get; set; }

		[JsonPropertyName("description")]
		public string? Description { get; set; }

		[JsonPropertyName("photos")]
		public List<string?>? Photos { get; set; }

		[JsonPropertyName("company_photos")]
		public List<string?>? CompanyPhotos { get; set; }

		[JsonPropertyName("seance_delay_step")]
		public double SeanceDelayStep { get; set; }

		[JsonPropertyName("show_any_master")]
		public bool ShowAnyMaster { get; set; }

		[JsonPropertyName("allow_delete_record")]
		public bool AllowDeleteRecord { get; set; }

		[JsonPropertyName("allow_change_record")]
		public bool AllowChangeRecord { get; set; }

		[JsonPropertyName("allow_change_record_delay_step")]
		public int AllowChangeRecordDelayStep { get; set; }

		[JsonPropertyName("allow_delete_record_delay_step")]
		public int AllowDeleteRecordDelayStep { get; set; }

		[JsonPropertyName("timetable_off")]
		public bool TimetableOff { get; set; }

		[JsonPropertyName("site")]
		public string? Site { get; set; }

		[JsonPropertyName("zip")]
		public object? Zip { get; set; }

		[JsonPropertyName("business_group_id")]
		public int BusinessGroupId { get; set; }

		[JsonPropertyName("business_type_id")]
		public int BusinessTypeId { get; set; }

		[JsonPropertyName("is_charge_active")]
		public bool IsChargeActive { get; set; }

		[JsonPropertyName("is_abonement_restriction_enabled")]
		public bool IsAbonementRestrictionEnabled { get; set; }

		[JsonPropertyName("print_bill_on")]
		public int PrintBillOn { get; set; }

		[JsonPropertyName("print_bill_type")]
		public string? PrintBillType { get; set; }

		[JsonPropertyName("record_type_id")]
		public int RecordTypeId { get; set; }

		[JsonPropertyName("split_records_by_resources")]
		public int SplitRecordsByResources { get; set; }

		[JsonPropertyName("auto_pay_account_id")]
		public int AutoPayAccountId { get; set; }

		[JsonPropertyName("auto_pay_bank_account_id")]
		public int AutoPayBankAccountId { get; set; }

		[JsonPropertyName("is_admin_app")]
		public int IsAdminApp { get; set; }

		[JsonPropertyName("push_notification_phone_confirm")]
		public int PushNotificationPhoneConfirm { get; set; }

		[JsonPropertyName("switched_to_tariff")]
		public bool SwitchedToTariff { get; set; }

		[JsonPropertyName("sms_enabled")]
		public bool SmsEnabled { get; set; }

		[JsonPropertyName("activity_record_clients_count_max")]
		public int ActivityRecordClientsCountMax { get; set; }

		[JsonPropertyName("activity_online_record_clients_count_max")]
		public int ActivityOnlineRecordClientsCountMax { get; set; }

		[JsonPropertyName("is_individual")]
		public bool IsIndividual { get; set; }

		[JsonPropertyName("is_tips_enabled")]
		public bool IsTipsEnabled { get; set; }

		[JsonPropertyName("social")]
		public CompanySocial? Social { get; set; }

		[JsonPropertyName("email_hours_default")]
		public int EmailHoursDefault { get; set; }

		[JsonPropertyName("is_show_privacy_policy")]
		public bool IsShowPrivacyPolicy { get; set; }

		[JsonPropertyName("is_show_timetable_record_master_resources")]
		public bool IsShowTimetableRecordMasterResources { get; set; }

		[JsonPropertyName("main_group_id")]
		public int MainGroupId { get; set; }

		[JsonPropertyName("main_group")]
		public CompanyMainGroup? MainGroup { get; set; }

		[JsonPropertyName("booking_comment_required")]
		public bool BookingCommentRequired { get; set; }

		[JsonPropertyName("booking_email_required")]
		public bool BookingEmailRequired { get; set; }

		[JsonPropertyName("booking_promo_link_url")]
		public string? BookingPromoLinkUrl { get; set; }

		[JsonPropertyName("booking_comment_input_name")]
		public string? BookingCommentInputName { get; set; }

		[JsonPropertyName("booking_notify_text")]
		public string? BookingNotifyText { get; set; }
	}
}