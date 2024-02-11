using System.Text.Json;
using Yclients.Exception;
using Yclients.Model.Response;

namespace Yclients.Endpoint
{
	public class Service : BaseEndpoint
	{
		private readonly string partnerToken;
		private readonly string userToken;
		private readonly string companyId;

		public Service(string partnerToken, string userToken, string companyId) =>
			(this.partnerToken, this.userToken, this.companyId) = (partnerToken, userToken, companyId);

		/// <summary>
		/// Возвращает список услуг.
		/// </summary>
		/// <returns></returns>
		/// <exception cref="StaffException"></exception>
		public GenericResponse<List<Model.Response.Data.Service>, Model.Response.Meta.Service>? Get()
		{
			var response = HttpRequest($"{BaseUrl}company/{companyId}/services", HttpMethod.Get, $"{partnerToken}, User {userToken}");
			var responseContent = response.Content.ReadAsStringAsync().Result;

			if (response.StatusCode != System.Net.HttpStatusCode.OK)
			{
				throw new ServiceException(responseContent);
			}

			return JsonSerializer.Deserialize<GenericResponse<List<Model.Response.Data.Service>, Model.Response.Meta.Service>>(responseContent);
		}

		/// <summary>
		/// Возвращает услугу по её ID.
		/// </summary>
		/// <param name="serviceId"></param>
		/// <returns></returns>
		/// <exception cref="StaffException"></exception>
		public GenericResponse<Model.Response.Data.Service, List<object>>? Get(int serviceId)
		{
			var response = HttpRequest($"{BaseUrl}company/{companyId}/services/{serviceId}", HttpMethod.Get, $"{partnerToken}, User {userToken}");
			var responseContent = response.Content.ReadAsStringAsync().Result;

			if (response.StatusCode != System.Net.HttpStatusCode.OK)
			{
				throw new ServiceException(responseContent);
			}

			return JsonSerializer.Deserialize<GenericResponse<Model.Response.Data.Service, List<object>>>(responseContent);
		}

		/// <summary>
		/// Общее количество записей.
		/// </summary>
		public int Count => Get()?.Meta?.TotalCount ?? 0;
	}
}