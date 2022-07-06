using System;
using Framework;
using NUnit.Framework;
using Tests.BaseClases;

namespace Tests
{
	public class Registration : BaseTest
	{
		[SetUp]

		public static void openPage()
		{
			Driver.open("https://www.senukai.lt/users/sign_up");
			SenukaiRegistrationPage.closeCookies();
		}

		[Test]
		public static void inputField()
		{
			string username = "Testas";
			string userSurname = "Testauskas";
			string userEmail = "Testukas_gmail.lt";
			string password = "paslaptis";
			string expectedResult = "neteisingas";
			string actualResult;

			SenukaiRegistrationPage.enterUserName(username);
			SenukaiRegistrationPage.enterUserSurname(userSurname);
			SenukaiRegistrationPage.enterUserEmail(userEmail);
			SenukaiRegistrationPage.enterUserPassword(password);
			SenukaiRegistrationPage.repeatUserPassword(password);
			SenukaiRegistrationPage.clickRegistrationButton();
			actualResult = SenukaiRegistrationPage.getMessage();
			SenukaiRegistrationPage.takeAScreenSchot();


			Assert.AreEqual(expectedResult,actualResult);

		}
	}
}

