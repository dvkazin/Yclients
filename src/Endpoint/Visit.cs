using System.Text.Json;
using Yclients.Exception;
using Yclients.Model.Response;

namespace Yclients.Endpoint
{
	public class Visit : BaseEndpoint
	{
		private readonly string partnerToken;
		private readonly string userToken;

		public Visit(string partnerToken, string userToken) =>
			(this.partnerToken, this.userToken) = (partnerToken, userToken);

		/// <summary>
		/// Возвращает информацию о визите.
		/// </summary>
		/// <param name="visitId">ID визита</param>
		/// <returns></returns>
		/// <exception cref="VisitException"></exception>
		public GenericResponse<Model.Response.Data.Visit, List<object>>? Get(int visitId)
		{
			var response = HttpRequest($"{BaseUrl}visits/{visitId}", HttpMethod.Get, $"{partnerToken}, User {userToken}");
			var responseContent = response.Content.ReadAsStringAsync().Result;

			if (response.StatusCode != System.Net.HttpStatusCode.OK)
			{
				throw new VisitException(responseContent);
			}

			return JsonSerializer.Deserialize<GenericResponse<Model.Response.Data.Visit, List<object>>>(responseContent);
		}
	}
}