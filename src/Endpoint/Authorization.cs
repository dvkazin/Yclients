using System.Text.Json;
using Yclients.Exception;
using Yclients.Model.Response;

namespace Yclients.Endpoint
{
	public class Authorization : BaseEndpoint
	{
		/// <summary>
		/// Аутентификация пользователя.
		/// </summary>
		/// <param name="partnerToken">Ключ партнёра</param>
		/// <param name="login">Логин</param>
		/// <param name="password">Пароль</param>
		/// <returns>Возвращает token пользователя и прочую информацию о пользователи.</returns>
		/// <exception cref="AuthenticationException"></exception>
		public static GenericResponse<Model.Response.Data.AuthorizationUser, List<object>>? AuthenticationUser(string login, string password, string partnerToken)
		{
			var response = HttpRequest($"{BaseUrl}auth", HttpMethod.Post, partnerToken, JsonSerializer.Serialize(new { login, password }));

			var responseContent = response.Content.ReadAsStringAsync().Result;

			if (response.StatusCode != System.Net.HttpStatusCode.Created)
			{
				throw new AuthenticationException(responseContent);
			}

			return JsonSerializer.Deserialize<GenericResponse<Model.Response.Data.AuthorizationUser, List<object>>>(responseContent);
		}

		/// <summary>
		/// Аутентификация пользователя онлайн-записи.
		/// </summary>
		/// <param name="login">Номер телефона или Email</param>
		/// <param name="password">Пароль</param>
		/// <param name="partnerToken"></param>
		/// <returns>Возвращает token пользователя и прочую информацию о пользователи.</returns>
		/// <exception cref="AuthenticationException"></exception>
		public static GenericResponse<Model.Response.Data.AuthorizationUserBooking, List<object>>? AuthenticationBooking(string login, string password, string partnerToken)
		{
			var response = HttpRequest($"{BaseUrl}booking/auth", HttpMethod.Post, partnerToken, JsonSerializer.Serialize(new { login, password }));

			var responseContent = response.Content.ReadAsStringAsync().Result;

			if (response.StatusCode != System.Net.HttpStatusCode.Created)
			{
				throw new AuthenticationException(responseContent);
			}

			return JsonSerializer.Deserialize<GenericResponse<Model.Response.Data.AuthorizationUserBooking, List<object>>>(responseContent);
		}
	}
}