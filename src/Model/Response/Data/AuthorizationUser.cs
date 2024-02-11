using System.Text.Json.Serialization;

namespace Yclients.Model.Response.Data
{
	public class AuthorizationUser : AuthorizationUserBooking
	{
		/// <summary>
		/// Подтвержден ли пользователь в системе.
		/// </summary>
		[JsonPropertyName("is_approved")]
		public bool IsApproved { get; set; }
	}
}