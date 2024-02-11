using System.Text.Json.Serialization;

namespace Yclients.Model.Request
{
	public class RecordParameter
	{
		/// <summary>
		/// Номер страницы.
		/// </summary>
		[JsonPropertyName("page")]
		public int Page { get; set; }

		/// <summary>
		/// Количество компаний на странице.
		/// </summary>
		[JsonPropertyName("count")]
		public int Count { get; set; }

		/// <summary>
		/// ID сотрудника. Если нужны записи к конкретному сотруднику.
		/// </summary>
		[JsonPropertyName("staff_id")]
		public int StaffId { get; set; }

		/// <summary>
		/// ID клиента. Если нужны записи конкретного клиента.
		/// </summary>
		[JsonPropertyName("client_id")]
		public int ClientId { get; set; }

		/// <summary>
		/// ID пользователя, создавшего запись. Если нужны записи, созданные конкретным пользователем.
		/// </summary>
		[JsonPropertyName("created_user_id")]
		public int CreatedUserId { get; set; }

		/// <summary>
		/// Дата сеанса начиная с (фильтр по дате сеанса). Если нужны записи на сеанс начиная с конкретной даты.
		/// </summary>
		[JsonPropertyName("start_date")]
		public string? StartDate { get; set; }

		/// <summary>
		/// Дата сеанса по. Если нужны записи на сеанс до конкретной даты.
		/// </summary>
		[JsonPropertyName("end_date")]
		public string? EndDate { get; set; }

		/// <summary>
		/// Дата создания записи начиная с (фильтр по дате создания записи). Если нужны записи, созданные начиная с конкретной даты.
		/// </summary>
		[JsonPropertyName("c_start_date")]
		public string? CStartDate { get; set; }

		/// <summary>
		/// Дата создания записи по (фильтр по дате создания записи).
		/// </summary>
		[JsonPropertyName("c_end_date")]
		public string? CEndDate { get; set; }

		/// <summary>
		/// Дата изменения/создания записи. Если нужны записи созданные/измененные начиная с конкретной даты и времени.
		/// </summary>
		[JsonPropertyName("changed_after")]
		public string? ChangedAfter { get; set; }

		/// <summary>
		/// Дата изменения/создания записи. Если нужны записи созданные/измененные до конкретной даты и времени.
		/// </summary>
		[JsonPropertyName("changed_before")]
		public string? ChangedBefore { get; set; }

		/// <summary>
		/// Флаг для включения в ответ списка расходников по записям.
		/// </summary>
		[JsonPropertyName("include_consumables")]
		public int IncludeConsumables { get; set; }

		/// <summary>
		/// Флаг для включения в ответ финансовых транзакций по записям/
		/// </summary>
		[JsonPropertyName("include_finance_transactions")]
		public int IncludeFinanceTransactions { get; set; }

		/// <summary>
		/// Включить в выдачу удаленные записи (with_deleted=1 вернет и удаленные записи).
		/// </summary>
		[JsonPropertyName("with_deleted")]
		public int WithDeleted { get; set; }
	}
}