using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace ToolsQA.SeleniumBasics
{
    public class WebTable
    {
        //[Test]
        public void test()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Programming_languages_used_in_most_popular_websites");
            var elemTable = driver.FindElement(By.XPath("//div[@id='mw-content-text']//table[1]"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            List<IWebElement> lstTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("tr")));
            String strRowData = "";

            foreach (var elemTr in lstTrElem)
            {
                List<IWebElement> lstTdElem = new List<IWebElement>(elemTr.FindElements(By.TagName("td")));
                if(lstTdElem.Count > 0)
                {
                    foreach (var elemTd in lstTdElem)
                    {
                        strRowData = strRowData + elemTd.Text.ToString() + "\t\t";
                    }
                }
                else
                {
                    Console.WriteLine("This is Header Row");
                    Console.WriteLine(lstTrElem[0].Text.ToString().Replace(" ", "\t\t"));
                }
                Console.WriteLine(strRowData);
                strRowData = String.Empty;
            }
            Console.WriteLine("");
            driver.Quit();
        }
    }
}
