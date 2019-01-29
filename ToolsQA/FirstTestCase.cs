using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ToolsQA
{
    class FirstTestCase
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://demoqa.com";
            Console.WriteLine("Hello World!");
        }
    }
}
