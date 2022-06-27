using Framework;
using NUnit.Framework;

namespace Tests
{
    public class DemoTest
    {
        [Test]
        public void openGoogle()
        {
            Driver.setDriver();
            Driver.open("https://www.google.com");
            Driver.closeDriver();
        }
    }
}
