using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework
{
    public class Driver
    {
        private static IWebDriver driver;

        public static void setDriver()
        {
            driver = new ChromeDriver();
        }

        public static IWebDriver getDriver()
        {
            return driver;
        }

        public static void open(string url)
        {
            driver.Url = url;
        }

        public static void closeDriver()
        {
            driver.Quit();
        }
    }
}
