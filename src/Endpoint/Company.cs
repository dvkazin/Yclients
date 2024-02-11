using System.Text.Json;
using Yclients.Exception;
using Yclients.Model.Request;
using Yclients.Model.Response;

namespace Yclients.Endpoint
{
	public class Company : BaseEndpoint
	{
		private readonly string partnerToken;

		public Company(string partnerToken) => (this.partnerToken) = (partnerToken);

		/// <summary>
		/// Возвращает список компаний.
		/// </summary>
		/// <param name="count">Номер страницы</param>
		/// <param name="page">Количество записей на странице</param>
		/// <returns></returns>
		/// <exception cref="CompanyException"></exception>
		public GenericResponse<List<Model.Response.Data.Company>, List<object>>? Get(int count = 25, int page = 1)
		{
			var response = HttpRequest($"{BaseUrl}companies?page={page}&count={count}", HttpMethod.Get, $"{partnerToken}");
			var responseContent = response.Content.ReadAsStringAsync().Result;

			if (response.StatusCode != System.Net.HttpStatusCode.OK)
			{
				throw new CompanyException(responseContent);
			}

			return JsonSerializer.Deserialize<GenericResponse<List<Model.Response.Data.Company>, List<object>>>(responseContent);
		}

		/// <summary>
		/// Возвращает компанию по её ID.
		/// </summary>
		/// <param name="companyId"></param>
		/// <returns></returns>
		/// <exception cref="CompanyException"></exception>
		public GenericResponse<Model.Response.Data.Company, List<object>>? Get(int companyId)
		{
			var response = HttpRequest($"{BaseUrl}company/{companyId}", HttpMethod.Get, $"{partnerToken}");
			var responseContent = response.Content.ReadAsStringAsync().Result;

			if (response.StatusCode != System.Net.HttpStatusCode.OK)
			{
				throw new CompanyException(responseContent);
			}

			return JsonSerializer.Deserialize<GenericResponse<Model.Response.Data.Company, List<object>>>(responseContent);
		}

		/// <summary>
		/// Возвращает список компаний.
		/// </summary>
		/// <param name="queryParameters">Параметры фильтрации</param>
		/// <returns></returns>
		/// <exception cref="CompanyException"></exception>
		public GenericResponse<List<Model.Response.Data.Company>, List<object>>? Get(CompanyParameter queryParameters)
		{
			var queryParam = SerializeToKeyValue<CompanyParameter>(queryParameters);
			if (!string.IsNullOrEmpty(queryParam))
			{
				queryParam = "?" + queryParam;
			}

			var response = HttpRequest($"{BaseUrl}companies{queryParam}", HttpMethod.Get, $"{partnerToken}");
			var responseContent = response.Content.ReadAsStringAsync().Result;

			if (response.StatusCode != System.Net.HttpStatusCode.OK)
			{
				throw new CompanyException(responseContent);
			}

			return JsonSerializer.Deserialize<GenericResponse<List<Model.Response.Data.Company>, List<object>>>(responseContent);
		}
	}
}