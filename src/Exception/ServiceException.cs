namespace Yclients.Exception
{
	internal class ServiceException : System.Exception
	{
		public ServiceException(string message) : base(message) { }
	}
}