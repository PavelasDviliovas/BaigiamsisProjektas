using System;
namespace Framework
{
	public class SenukaiSearchPage 
	{
		public SenukaiSearchPage()
		{
		}

        public static void enterSearchField(string expectedSearch)
        {
            string locator = "//*[@id='q']";
            Common.sendKeysToElement(locator, expectedSearch);
        }

        public static void clickSearchBtn()
        {
            string locator = "//*[@id='top-search-form']/div/div[2]/button/i";
            Common.clickElement(locator);
        }

        public static void waitForElementToBeVisible()
        { 
            string locatorActualSearchResult = "//*[@class='ks-page-title']//span";
            Common.waitForElementToBeVisible(locatorActualSearchResult);
            Common.clickElement(locatorActualSearchResult);
        }

        public static string ReadMessage()
        {
            string locator = "//*[@class='ks-page-title']//span";
            return Common.getElementText(locator);
        }
    
     
    }


}    

