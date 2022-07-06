using System;
using Framework;
using NUnit.Framework;
using Tests.BaseClases;

namespace Tests
{
	public class SenukaiLogin : BaseTest
	{

		[SetUp]
		public static void openPage()
		{
			Driver.open("https://www.senukai.lt/users/sign_in");
		}

		[Test]
		public static void loginInputFieds()
        {
			string userEmail = "Testukas@gmail.lt";
			string password = "nezinau";
			string LoginResult ;
			string ExpectedResult = "Neteisingas el. pašto adresas arba slaptažodis";

			SenukaiLoginPage.enterUserEmail(userEmail);
			SenukaiLoginPage.enterUserPassword(password);
			SenukaiLoginPage.clickSubmitBtn();
			LoginResult = SenukaiLoginPage.readTheMessage();
			SenukaiLoginPage.takeAScreenSchot();

            Assert.AreEqual(ExpectedResult,LoginResult);
		}
	}
}

