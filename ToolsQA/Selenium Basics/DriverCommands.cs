using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
namespace ToolsQA.SeleniumBasics
{
    public class DriverCommands
    {
        //[Test]
        public void Test()
        {
            try
            {
                IWebDriver driver = new FirefoxDriver();
                driver.Url = "http://the-internet.herokuapp.com/disappearing_elements";
                driver.FindElement(By.CssSelector(".example ul li:nth-of-type(2) a")).Click();
                printDriver(driver);
                driver.Navigate().Back();
                printDriver(driver);
                driver.Navigate().Forward();
                printDriver(driver);
                driver.Navigate().Refresh();
                printDriver(driver);
                driver.Quit();
            } catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void printDriver( IWebDriver driver)
        {
            Console.WriteLine("");
            Console.WriteLine(driver.Title);
            Console.WriteLine(driver.PageSource);
            Console.WriteLine("");
        }
    }
}