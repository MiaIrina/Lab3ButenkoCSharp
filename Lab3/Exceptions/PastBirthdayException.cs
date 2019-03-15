using System;


namespace ButenkoLab03.Exceptions
{
	internal class PastBirthdayException : ArgumentException
	{
		public PastBirthdayException() : base()
		{

		}
		public PastBirthdayException(string date)
			: base($"Your birthday cannot be such a long period ago {date}")
		{

		}
	}
}
