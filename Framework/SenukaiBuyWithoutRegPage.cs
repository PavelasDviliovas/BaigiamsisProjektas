using System;
namespace Framework
{
    public class SenukaiBuyWithoutRegPage
    {
        public static void enterBuyerEmail(string email)
        {
            string locator = "(//*[@id='user_email'])[2]";
            Common.sendKeysToElement(locator, email);
            
        }

        public static void clickContinueBtn()
        {
            string locator = "//*[@id='new_user_guest']/div[2]/input";
            Common.clickElement(locator);
        }

        public static string readActualResult()
        {
            string locator = "//*[@class='checkout-order-summary__title-label']";;
            return Common.getElementText(locator);
        }
    }

}

