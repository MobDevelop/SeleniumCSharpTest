

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsQA.SeleniumBasics
{
    public class CheckBoxAndRadioButton
    {
        [Test]
        public void Test()
        {
            Console.WriteLine("CheckBoxAndRadioButton");
            try
            {
                IWebDriver driver = new FirefoxDriver();
                driver.Url = "http://toolsqa.com/automation-practice-form";
                IList<IWebElement> rdBtn_Gender = driver.FindElements(By.Name("sex"));

                Boolean bValue = false;

                bValue = rdBtn_Gender.ElementAt(0).Selected;

                if (bValue == true)
                {
                    rdBtn_Gender.ElementAt(1).Click();
                }
                else
                {
                    rdBtn_Gender.ElementAt(0).Click();
                }
            } catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
