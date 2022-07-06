using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Framework
{
	internal class Common
	{
		public static IWebElement getElement(string locator)
		{
			return Driver.getDriver().FindElement(By.XPath(locator));
		}

		public static void selectOptionByValue(string locator, string value)
		{
			IWebElement element = getElement(locator);
			SelectElement selectElement = new SelectElement(element);
			selectElement.SelectByValue(value);
		}

		public static void sendKeysToElement(string locator, string keys)
		{
			getElement(locator).SendKeys(keys);
		}

		public static void clickElement(string locator)
		{
			getElement(locator).Click();
		}

		internal static void sendKeysToElement(string locator)
		{
			IWebElement element = getElement(locator);
			Actions actions = new Actions(Driver.getDriver());

			actions.MoveToElement(element);
			actions.Release();
			actions.Perform();
		}
		

        public static void MoveToElement(string locator)
        {
			IWebElement element = getElement(locator);
			Actions actions = new Actions(Driver.getDriver());

			actions.MoveToElement(element);
			actions.Click(element);
			actions.Perform();
		}

        public static string getElementText(string locator)
		{
			return getElement(locator).Text;
		}


		internal static void enterKey(string locator)
		{
			IWebElement element = getElement(locator);
			Actions actions = new Actions(Driver.getDriver());

			actions.MoveToElement(element);
			actions.Release();
			actions.Perform();
		}

		public static void waitForElementToBeVisible(string locator)
		{
			WebDriverWait wait = new WebDriverWait(Driver.getDriver(), TimeSpan.FromSeconds(10));
			wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));

		}

		public static void waitForElementToBeClickable(string locator)
		{
			WebDriverWait wait = new WebDriverWait(Driver.getDriver(), TimeSpan.FromSeconds(10));
			wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locator)));

		}
	}
}