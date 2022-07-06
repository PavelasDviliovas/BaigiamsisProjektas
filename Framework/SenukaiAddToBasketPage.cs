using System;
namespace Framework
{
	public class SenukaiAddToBasketPage
	{
		public SenukaiAddToBasketPage()
		{
		}

        public static void SelectQty()
        {
            string locator = "//*[@id='inc-quantity']";
            Common.clickElement(locator);
        }

        public static void clickBasketBtn()
        {
            string locator = "//*[@id='add_to_cart_btn']";
            Common.clickElement(locator);
        }

        public static void closeCookies()
        {
            string locatorCookiesButton = "//*[@id='cookiebanner' and contains(@style,'bottom: 0px')]//*[@id='cookie-btns']/a[1]";
            Common.waitForElementToBeVisible(locatorCookiesButton);
            Common.clickElement(locatorCookiesButton);
        }

        public static void waitForElementToBeVisible()
        {
            throw new NotImplementedException();
        }

        public static string ReadResult()
        {
            string locator = "//*[@class='title-success']";
            Common.waitForElementToBeVisible(locator);
            return Common.getElementText(locator);
        }
    
    }
}

