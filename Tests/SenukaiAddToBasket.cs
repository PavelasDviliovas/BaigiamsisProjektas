using System;
using Framework;
using NUnit.Framework;
using Tests.BaseClases;

namespace Tests
{
	public class SenukaiAddToBasket : BaseTest
	{
		[SetUp]
		public static void openPage()
		{
			Driver.open("https://www.senukai.lt/p/baseinas-intex-28242np-melynas-4570x1220-mm-16805-l/ah6m?mtd=top&pos=top&src=bitrec&index=1");
			SenukaiAddToBasketPage.closeCookies();
		}

		[Test]
		public static void AddToBasket()
        {
			string expectedResult = "Prekė sėkmingai įdėta į pirkinių krepšelį";
			string actualResult;

			SenukaiAddToBasketPage.SelectQty();
			SenukaiAddToBasketPage.clickBasketBtn();
			actualResult = SenukaiAddToBasketPage.ReadResult();

			Assert.AreEqual(expectedResult, actualResult);
		}



	}
}

