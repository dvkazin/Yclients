using System.Text.Json;
using Yclients.Exception;
using Yclients.Model.Response;

namespace Yclients.Endpoint
{
	public class Staff : BaseEndpoint
	{
		private readonly string partnerToken;
		private readonly string userToken;
		private readonly string companyId;

		public Staff(string partnerToken, string userToken, string companyId) =>
			(this.partnerToken, this.userToken, this.companyId) = (partnerToken, userToken, companyId);

		/// <summary>
		/// Возвращает список сотрудников.
		/// </summary>
		/// <returns></returns>
		/// <exception cref="StaffException"></exception>
		public GenericResponse<List<Model.Response.Data.Staff>, Model.Response.Meta.Staff>? Get()
		{
			var response = HttpRequest($"{BaseUrl}company/{companyId}/staff", HttpMethod.Get, $"{partnerToken}, User {userToken}");
			var responseContent = response.Content.ReadAsStringAsync().Result;

			if (response.StatusCode != System.Net.HttpStatusCode.OK)
			{
				throw new StaffException(responseContent);
			}

			return JsonSerializer.Deserialize<GenericResponse<List<Model.Response.Data.Staff>, Model.Response.Meta.Staff>>(responseContent);
		}

		/// <summary>
		/// Возвращает сотрудника по его ID.
		/// </summary>
		/// <param name="staffId"></param>
		/// <returns></returns>
		/// <exception cref="StaffException"></exception>
		public GenericResponse<Model.Response.Data.Staff, List<object>>? Get(int staffId)
		{
			var response = HttpRequest($"{BaseUrl}company/{companyId}/staff/{staffId}", HttpMethod.Get, $"{partnerToken}, User {userToken}");
			var responseContent = response.Content.ReadAsStringAsync().Result;

			if (response.StatusCode != System.Net.HttpStatusCode.OK)
			{
				throw new StaffException(responseContent);
			}

			return JsonSerializer.Deserialize<GenericResponse<Model.Response.Data.Staff, List<object>>>(responseContent);
		}

		/// <summary>
		/// Общее количество записей.
		/// </summary>
		public int Count => Get()?.Meta?.TotalCount ?? 0;
	}
}