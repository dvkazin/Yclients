using System.Text.Json.Serialization;

namespace Yclients.Model.Request
{
	public class CompanyParameter
	{
		/// <summary>
		/// ID сети компаний.Если нужны компании входящие в конкретную сеть.
		/// </summary>
		[JsonPropertyName("group_id")]
		public int GroupId { get; set; }

		/// <summary>
		/// Только для авторизованного пользователя(с использованием user_token в Headers). Если нужны компании, на управление которыми пользователь имеет права.
		/// </summary>
		[JsonPropertyName("my")]
		public int My { get; set; }

		/// <summary>
		/// Если нужно получить только активные для онлайн-записи компании.
		/// </summary>
		[JsonPropertyName("active")]
		public bool Active { get; set; }

		/// <summary>
		/// Если нужно получить только прошедшие модерацию компании.Т.е.чей контент проверен для публикации.
		/// </summary>
		[JsonPropertyName("moderated")]
		public bool Moderated { get; set; }

		/// <summary>
		/// Если нужно получить поле next_slot по каждой компании.
		/// </summary>
		[JsonPropertyName("forBooking")]
		public bool ForBooking { get; set; }

		/// <summary>
		/// Широта центра поиска по координатам.
		/// </summary>
		[JsonPropertyName("coordinate_lat")]
		public string? CoordinateLat { get; set; }

		/// <summary>
		/// Долгота центра поиска по координатам.
		/// </summary>
		[JsonPropertyName("coordinate_lon")]
		public string? CoordinateLon { get; set; }

		/// <summary>
		/// Радиус поиска.
		/// </summary>
		[JsonPropertyName("distance")]
		public string? Distance { get; set; }

		/// <summary>
		/// Поиск по вхождению подстроки в название компании.
		/// </summary>
		[JsonPropertyName("title")]
		public string? Title { get; set; }

		/// <summary>
		/// Поиск по ID города.
		/// </summary>
		[JsonPropertyName("city_id")]
		public int CityId { get; set; }

		/// <summary>
		/// Включить в обьект компании список сетей в которые входит эта компания.
		/// </summary>
		[JsonPropertyName("show_groups")]
		public bool ShowGroups { get; set; }

		/// <summary>
		/// Количество компаний на странице.
		/// </summary>
		[JsonPropertyName("count")]
		public int Count { get; set; }

		/// <summary>
		/// Номер страницы.
		/// </summary>
		[JsonPropertyName("page")]
		public int Page { get; set; }
	}
}