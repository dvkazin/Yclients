using System.Text.Json;
using Yclients.Exception;
using Yclients.Model.Request;
using Yclients.Model.Response;

namespace Yclients.Endpoint
{
	public class Record : BaseEndpoint
	{
		private readonly string partnerToken;
		private readonly string userToken;
		private readonly string companyId;

		public Record(string partnerToken, string userToken, string companyId) => 
			(this.partnerToken, this.userToken, this.companyId) = (partnerToken, userToken, companyId);

		/// <summary>
		/// Возвращает список записей.
		/// </summary>
		/// <param name="count">Количество записей на странице</param>
		/// <param name="page">Номер страницы</param>
		/// <returns></returns>
		/// <exception cref="StaffException"></exception>
		public GenericResponse<List<Model.Response.Data.Record>, Model.Response.Meta.Record>? Get(int count = 50, int page = 1)
		{
			var response = HttpRequest($"{BaseUrl}records/{companyId}?page={page}&count={count}", HttpMethod.Get, $"{partnerToken}, User {userToken}");
			var responseContent = response.Content.ReadAsStringAsync().Result;

			if (response.StatusCode != System.Net.HttpStatusCode.OK)
			{
				throw new RecordException(responseContent);
			}

			return JsonSerializer.Deserialize<GenericResponse<List<Model.Response.Data.Record>, Model.Response.Meta.Record>>(responseContent);
		}

		/// <summary>
		/// Возвращает список записей.
		/// </summary>
		/// <param name="queryParameters">Параметры фильтрации</param>
		/// <returns></returns>
		/// <exception cref="StaffException"></exception>
		public GenericResponse<List<Model.Response.Data.Record>, Model.Response.Meta.Record>? Get(RecordParameter queryParameters)
		{
			var queryParam = SerializeToKeyValue<RecordParameter>(queryParameters);
			if (!string.IsNullOrEmpty(queryParam))
			{
				queryParam = "?" + queryParam;
			}

			var response = HttpRequest($"{BaseUrl}records/{companyId}{queryParam}", HttpMethod.Get, $"{partnerToken}, User {userToken}");
			var responseContent = response.Content.ReadAsStringAsync().Result;

			if (response.StatusCode != System.Net.HttpStatusCode.OK)
			{
				throw new RecordException(responseContent);
			}

			return JsonSerializer.Deserialize<GenericResponse<List<Model.Response.Data.Record>, Model.Response.Meta.Record>>(responseContent);
		}

		/// <summary>
		/// Общее количество записей.
		/// </summary>
		public int Count => Get(1, 1)?.Meta?.TotalCount ?? 0;
	}
}