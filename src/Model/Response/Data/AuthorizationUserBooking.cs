using System.Text.Json.Serialization;

namespace Yclients.Model.Response.Data
{
	public class AuthorizationUserBooking
	{
		/// <summary>
		/// Идентификатор пользователя.
		/// </summary>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <summary>
		/// Используется в методах, требующих авторизацию пользователя.
		/// </summary>
		[JsonPropertyName("user_token")]
		public string? UserToken { get; set; }

		/// <summary>
		/// Имя пользователя.
		/// </summary>
		[JsonPropertyName("name")]
		public string? Name { get; set; }

		/// <summary>
		/// Телефон пользователя.
		/// </summary>
		[JsonPropertyName("phone")]
		public string? Phone { get; set; }

		/// <summary>
		/// Логин пользователя.
		/// </summary>
		[JsonPropertyName("login")]
		public string? Login { get; set; }

		/// <summary>
		/// Почтовый адрес пользователя.
		/// </summary>
		[JsonPropertyName("email")]
		public string? Email { get; set; }

		/// <summary>
		/// Путь к файлу аватарки пользователя.
		/// </summary>
		[JsonPropertyName("avatar")]
		public string? Avatar { get; set; }
	}
}