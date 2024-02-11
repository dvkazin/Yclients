using System.Text.Json;
using Yclients.Exception;
using Yclients.Model.Response;

namespace Yclients.Endpoint
{
	public class ServiceCategory : BaseEndpoint
	{
		private readonly string partnerToken;
		private readonly string userToken;
		private readonly string companyId;

		public ServiceCategory(string partnerToken, string userToken, string companyId) =>
			(this.partnerToken, this.userToken, this.companyId) = (partnerToken, userToken, companyId);

		/// <summary>
		/// Возвращает список категорий услуг.
		/// </summary>
		/// <returns></returns>
		/// <exception cref="ServiceCategoryException"></exception>
		public GenericResponse<List<Model.Response.Data.ServiceCategory>, Model.Response.Meta.ServiceCategory>? Get()
		{
			var response = HttpRequest($"{BaseUrl}company/{companyId}/service_categories", HttpMethod.Get, $"{partnerToken}, User {userToken}");
			var responseContent = response.Content.ReadAsStringAsync().Result;

			if (response.StatusCode != System.Net.HttpStatusCode.OK)
			{
				throw new ServiceCategoryException(responseContent);
			}

			return JsonSerializer.Deserialize<GenericResponse<List<Model.Response.Data.ServiceCategory>, Model.Response.Meta.ServiceCategory>>(responseContent);
		}

		/// <summary>
		/// Возвращает категорию по её ID.
		/// </summary>
		/// <param name="idServiceCategory"></param>
		/// <returns></returns>
		/// <exception cref="ServiceCategoryException"></exception>
		public GenericResponse<Model.Response.Data.ServiceCategory, List<object>>? Get(int idServiceCategory)
		{
			var response = HttpRequest($"{BaseUrl}company/{companyId}/service_categories/{idServiceCategory}", HttpMethod.Get, $"{partnerToken}, User {userToken}");
			var responseContent = response.Content.ReadAsStringAsync().Result;

			if (response.StatusCode != System.Net.HttpStatusCode.OK)
			{
				throw new ServiceCategoryException(responseContent);
			}

			return JsonSerializer.Deserialize<GenericResponse<Model.Response.Data.ServiceCategory, List<object>>>(responseContent);
		}

		/// <summary>
		/// Общее количество записей.
		/// </summary>
		public int Count => Get()?.Meta?.TotalCount ?? 0;
	}
}