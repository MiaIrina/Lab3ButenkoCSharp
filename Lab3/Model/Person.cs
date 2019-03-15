using ButenkoLab03.Exceptions;
using System;
using System.ComponentModel.DataAnnotations;


namespace ButenkoLab03.Model
{
	class Person
	{
		#region Fields
		private string _name;
		private int _age;
		private string _surname;
		private DateTime _birthDay = DateTime.Today;
		private string _email;
		public static readonly String[] ChineseYear = { "Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat" };
		private string _chineseHoroscope;
		private string _westHoroscope;



		#endregion



		public int Age
		{
			get
			{
				return _age;
			}
			private set
			{
				_age = value;
				if (_age > 135)
				{
					throw new PastBirthdayException(BirthDay.ToShortDateString());
				}
				else if (BirthDay > DateTime.Today)
				{
					throw new FutureBirthException(BirthDay.ToShortDateString());
				}
			}
		}
		public string Name
		{
			get
			{
				return _name;
			}
			private set
			{
				_name = value;


			}
		}
		public string Surname
		{
			get
			{
				return _surname;
			}
			private set
			{
				_surname = value;

			}
		}
		public DateTime BirthDay
		{
			get
			{
				return _birthDay;
			}
			private set
			{
				_birthDay = value;


			}
		}
		public string Email
		{
			get
			{
				return _email;
			}
			private set
			{
				_email = value;
				if (!new EmailAddressAttribute().IsValid(Email))
				{
					throw new WrongMailException(Email);
				}

			}
		}
		public bool IsAdult
		{
			get
			{
				return (Age >= 18);
			}
		}
		public bool IsBirthDay
		{
			get
			{


				return (_birthDay.Day == DateTime.Now.Day && _birthDay.Month == DateTime.Now.Month);

			}
		}

		public string WestHoroscope
		{
			get
			{
				return _westHoroscope;
			}
			private set
			{
				_westHoroscope = value;

			}
		}
		public string ChineseHoroscope
		{
			get
			{
				return _chineseHoroscope;
			}
			private set
			{
				_chineseHoroscope = value;

			}

		}

		public Person(string name, string surname, DateTime birthDay, string email)
		{
			Name = name;
			Surname = surname;
			BirthDay = birthDay;
			Email = email;
			DefineAge();
			DefineChineseHoroscope();
			DefineTheWestHoroscope();


		}
		public Person(string name, string surname, string email) : this(name, surname, DateTime.Today, email)
		{
		}
		public Person(string name, string surname, DateTime birthDay) : this(name, surname, DateTime.Today, "unknown@gmail.com")
		{
		}
		private void DefineTheWestHoroscope()
		{

			int day = _birthDay.Day;
			int month = _birthDay.Month;
			if (day >= 22 && month == 12 || day <= 20 && month == 1)
			{
				WestHoroscope = "Capricorn";
			}
			else if (day >= 21 && month == 1 || day <= 19 && month == 2)
			{
				WestHoroscope = "Aquarius";
			}
			else if (day >= 20 && month == 2 || day <= 20 && month == 3)
			{
				WestHoroscope = "Pisces";
			}
			else if (day >= 21 && month == 3 || day <= 19 && month == 4)
			{
				WestHoroscope = "Aries";
			}
			else if (day >= 20 && month == 4 || day <= 20 && month == 5)
			{
				WestHoroscope = "Taurus";
			}
			else if (day >= 21 && month == 5 || day <= 21 && month == 6)
			{
				WestHoroscope = "Gemini";
			}
			else if (day >= 22 && month == 6 || day <= 23 && month == 7)
			{
				WestHoroscope = "Cancer";
			}
			else if (day >= 24 && month == 7 || day <= 23 && month == 8)
			{
				WestHoroscope = "Leo";
			}
			else if (day >= 24 && month == 8 || day <= 22 && month == 9)
			{
				WestHoroscope = "Virgo";
			}
			else if (day >= 23 && month == 9 || day <= 22 && month == 10)
			{
				WestHoroscope = "Libra";
			}
			else if (day >= 23 && month == 10 || day <= 22 && month == 11)
			{
				WestHoroscope = "Scorpio";
			}
			else WestHoroscope = "Sagittarius";

		}
		private void DefineChineseHoroscope()
		{

			ChineseHoroscope = ChineseYear[_birthDay.Year % 12];
		}
		private void DefineAge()
		{
			Age = (int)((DateTime.Today - _birthDay).Days / 365);
		}
		private bool CheckEmail(string mail)
		{
			return new EmailAddressAttribute().IsValid(mail);
		}

	}
}
