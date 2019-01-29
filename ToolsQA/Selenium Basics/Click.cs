using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
namespace ToolsQA.SeleniumBasics
{
    public class Click
    {
        //[Test]
        public void Test()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://the-internet.herokuapp.com/login";

            IWebElement UserName = driver.FindElement(By.Id("username"));
            UserName.SendKeys("tomsmith");

            IWebElement Password = driver.FindElement(By.Id("password"));
            Password.SendKeys("SuperSecretPassword!");

            IWebElement Button = driver.FindElement(By.CssSelector(".radius"));
            Button.Click();

            driver.Quit();
        }
    }
}
