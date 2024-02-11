using System.Text.Json;
using Yclients.Exception;
using Yclients.Model.Request;
using Yclients.Model.Response;

namespace Yclients.Endpoint
{
	public class Internationalization : BaseEndpoint
	{
		private readonly string partnerToken;

		public Internationalization(string partnerToken) => 
			(this.partnerToken) = (partnerToken);

		/// <summary>
		/// Возвращает параметры интернационализации.
		/// </summary>
		/// <param name="langCode">Код языка</param>
		/// <returns></returns>
		/// <exception cref="CompanyException"></exception>
		public GenericResponse<List<Model.Response.Data.Company>, List<object>>? Get(Lang langCode)
		{
			throw new NotImplementedException("Не описана модель для десериализации.");

			var response = HttpRequest($"{BaseUrl}i18n/{langCode.ToDescription()}", HttpMethod.Get, $"{partnerToken}");
			var responseContent = response.Content.ReadAsStringAsync().Result;

			if (response.StatusCode != System.Net.HttpStatusCode.OK)
			{
				throw new InternationalizationException(responseContent);
			}

			return JsonSerializer.Deserialize<GenericResponse<List<Model.Response.Data.Company>, List<object>>>(responseContent);
		}
	}
}