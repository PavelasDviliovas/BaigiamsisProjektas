using System;
using Framework;
using NUnit.Framework;
using Tests.BaseClases;

namespace Tests
{
	public class SenukaiBuyWithoutReg : BaseTest
	{
		[SetUp]
		public static void openPage()
		{
			Driver.open("https://www.senukai.lt/checkout_authentication/new");
		}

		[Test]
		public static void WithoutReg()
		{
			string email = "beRegistracijos@gmail.com";
			string expectedResult = "Užsakymo informacija";
			string actualResult;

			SenukaiBuyWithoutRegPage.enterBuyerEmail(email);
			SenukaiBuyWithoutRegPage.clickContinueBtn();
			actualResult = SenukaiBuyWithoutRegPage.readActualResult();

			Assert.AreEqual(expectedResult, actualResult);
		}
	}
}

