using System;
namespace Framework
{
	public class SenukaiLoginPage
	{
		public SenukaiLoginPage()
		{
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

        public static void clickSubmitBtn()
        {
            string locator = "//*[@id='new_user']/div[4]/input";
            Common.clickElement(locator);
        }

        public static string readTheMessage()
        {
            string locator = "//*[@id='new_user']/div[2]/p";
            return Common.getElementText(locator);

        }

            public static void takeAScreenSchot()
            {
                Driver.takeScreenshot();
            }
        
    }
}

