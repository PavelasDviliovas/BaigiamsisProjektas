using System.IO;
using Framework;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Tests.BaseClases
{
    public class BaseTest

    {

        [SetUp]
        public static void setup()
        {
            Driver.setDriver();
        }


        [TearDown]
        public static void close()
        {

            if (TestContext.CurrentContext.Result.Outcome != ResultState.Failure)
            {
                Driver.takeScreenshot();
            }

            Driver.closeDriver();
        }
    }
}
