using System;
namespace Framework
{
	public class SenukaiRegistrationPage
	{
		public SenukaiRegistrationPage()
		{
		}

        public static void enterUserName(string username)
        {
            string locator = "//*[@id='user_first_name']";
            Common.sendKeysToElement(locator, username);
        }

        public static void closeCookies()
        {
            string locatorCookiesButton = "//*[@id='cookiebanner' and contains(@style,'bottom: 0px')]//*[@id='cookie-btns']/a[1]";
            Common.waitForElementToBeVisible(locatorCookiesButton);
            Common.clickElement(locatorCookiesButton);
        }

        public static void enterUserSurname(string userSurname)
        {
            string locator = "//*[@id='user_last_name']";
            Common.sendKeysToElement(locator, userSurname);
        }

        public static void enterUserEmail(string userEmail)
        {
            string locator = "//*[@id='user_email']";
            Common.sendKeysToElement(locator, userEmail);
        }

        public static void enterUserPassword(string password)
        {
            string locator = "//*[@id='user_password']";
            Common.sendKeysToElement(locator, password);
        }

        public static void repeatUserPassword(string password)
        {
            string locator = "//*[@id='user_password_confirmation']";
            Common.sendKeysToElement(locator, password);
        }

        public static void clickRegistrationButton()
        {
            string locator = "//*[@id='new_user']/div[9]/input";
            Common.waitForElementToBeClickable(locator);
            Common.clickElement(locator);
        }
        
        public static void takeAScreenSchot()
        {
            Driver.takeScreenshot();
        }

        public static string getMessage()
        {
            string locator = "//*[@id='new_user']/div[5]/p";
            return Common.getElementText(locator);
        }
    }
}

