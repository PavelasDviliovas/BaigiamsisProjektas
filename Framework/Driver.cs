using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework
{
    public class Driver
    {
        private static IWebDriver driver;

        public static void setDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--window-size=3000,2000");
            options.AddArgument("--headless");
            driver = new ChromeDriver(options);   // (options idet i skliaustus, jei norim panaudoti);
        }

        public static IWebDriver getDriver()
        {
            return driver;
        }
        public static void takeScreenshot()
        {
            string screenshotPath = $"{AppDomain.CurrentDomain.BaseDirectory}screenshots";
            string screenshotName = $"{screenshotPath}\\{Guid.NewGuid()}.png";

            Directory.CreateDirectory(screenshotPath);
            Screenshot screenshot = ((ITakesScreenshot)Driver.getDriver()).GetScreenshot();
            screenshot.SaveAsFile(screenshotName, ScreenshotImageFormat.Png);
            
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
