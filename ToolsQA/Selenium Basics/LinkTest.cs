using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
namespace ToolsQA.SeleniumBasics
{
    public class LinkTest
    {
        //[Test]
        public void Test()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = ("http://toolsqa.com/Automation-practice-form/");

            driver.FindElement(By.PartialLinkText("Partial")).Click();
            Console.WriteLine("Partial Link Test Passed");

            String sClass = driver.FindElement(By.TagName("button")).ToString();
            Console.WriteLine(sClass);

            driver.FindElement(By.LinkText("Link Test")).Click();
            Console.WriteLine("Link Test Passed");

            driver.Quit();
        }
    }
}
