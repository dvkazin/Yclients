using System.ComponentModel;

namespace Yclients.Model.Request
{
	public enum Lang
	{
		/// <summary>
		/// Русский.
		/// </summary>
		[Description("ru-RU")]
		Ru,

		/// <summary>
		/// Латвийский.
		/// </summary>
		[Description("lv-LV")]
		Lv,

		/// <summary>
		/// Английский.
		/// </summary>
		[Description("en-US")]
		Us,

		/// <summary>
		/// Эстонский.
		/// </summary>
		[Description("ee-EE")]
		Ee,

		/// <summary>
		/// Литовский.
		/// </summary>
		[Description("'lt-LT")]
		Lt,

		/// <summary>
		/// Немецкий.
		/// </summary>
		[Description("de-DE")]
		De,

		/// <summary>
		/// Украинский.
		/// </summary>
		[Description("uk-UK")]
		Uk
	}

	internal static class LangExtensions
	{
		internal static string ToDescription(this Enum value)
		{
			var attributes = value
				.GetType()
				?.GetField(value.ToString())
				?.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];
			return attributes?.Length > 0 
				? attributes[0].Description 
				: throw new System.Exception($"The Description Attribute For {value.GetType()}.{value} is not found.");
		}
	}
}