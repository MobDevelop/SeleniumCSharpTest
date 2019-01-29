using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Compatibility;
using NUnit.Framework;

namespace ToolsQA
{
    public class NUnitTest
    {
        IWebDriver driver;
        [SetUp]
        public void Initialize()
        {
            driver = new FirefoxDriver();
        }
        //[Test]
        public void OpenAppTest()
        {
            driver.Url = "http://www.demoqa.com";
        }
        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}
