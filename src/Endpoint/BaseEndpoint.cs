using System.Text;
using System.Reflection;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;

namespace Yclients.Endpoint
{
	public abstract class BaseEndpoint
	{
		private protected static string BaseUrl => "https://api.yclients.com/api/v1/";

		/// <summary>
		/// Отправка запроса.
		/// </summary>
		/// <param name="url"></param>
		/// <param name="method"></param>
		/// <param name="bearer"></param>
		/// <param name="body"></param>
		/// <returns></returns>
		private protected static HttpResponseMessage HttpRequest(string url, HttpMethod method, string bearer, string body = "")
		{
			using (var client = new HttpClient())
			{
				using (var request = new HttpRequestMessage())
				{
					request.RequestUri = new Uri(url);
					request.Method = method;

					client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearer);
					request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.yclients.v2+json"));
					
					request.Content = new StringContent(body);
					request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

					return client.Send(request);
				}
			}
		}

		/// <summary>
		/// Сериализация свойств объекта в стрку формата: ключ=значение
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="param"></param>
		/// <param name="delimiter"></param>
		/// <returns></returns>
		private protected static string SerializeToKeyValue<T>(object param, string delimiter = "&")
		{
			var result = new StringBuilder();

			foreach (PropertyInfo property in typeof(T).GetProperties())
			{
				var type = property.PropertyType;
				var value = property.GetValue(param, null);
				var name = property.GetCustomAttributes<JsonPropertyNameAttribute>(true).FirstOrDefault()?.Name;

				#region Параметр не включается в запрос, если его значение равно null или имеет значение по умолчанию

				if (value == null)
				{
					continue;
				}

				if (type == typeof(int) || type == typeof(int?))
				{
					if ((int?)value > 0)
					{
						result.Append($"{name}={value}{delimiter}");
					}
					continue;
				}

				if (type == typeof(string))
				{
					if (!string.IsNullOrWhiteSpace((string?)value))
					{
						result.Append($"{name}={value}{delimiter}");
					}
					continue;
				}

				#endregion
			}

			return result.Length == 0 ? string.Empty : result.ToString().Remove(result.Length - 1);
		}
	}
}