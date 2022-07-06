using System;
using Framework;
using NUnit.Framework;
using Tests.BaseClases;

namespace Tests
{
	public class SenukaiSearch : BaseTest
	{


		[SetUp]
		public static void openPage()
        {
			Driver.open("https://www.senukai.lt");
		}

		[Test]
		public static void searchField()
        {
			string expectedSearch = "kompiuteris";
			string actualSearchResult;

			SenukaiSearchPage.enterSearchField(expectedSearch);
			SenukaiSearchPage.clickSearchBtn();
			SenukaiSearchPage.waitForElementToBeVisible();
			actualSearchResult = SenukaiSearchPage.ReadMessage();

			Assert.IsTrue(actualSearchResult.Contains(expectedSearch));

        }

	}
}

