

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
        //[Test]
        public void Test()
        {
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

                IWebElement rdBtn_Exp = driver.FindElement(By.Id("exp-2"));
                rdBtn_Exp.Click();

                IList<IWebElement> chkBx_Profession = driver.FindElements(By.Name("profession"));
                for (int i = 0; i < chkBx_Profession.Count; i++)
                {
                    if(chkBx_Profession.ElementAt(i).GetAttribute("value").Equals("Automation Tester"))
                    {
                        chkBx_Profession.ElementAt(i).Click();
                    }
                }

                IWebElement chkBx_IDE = driver.FindElement(By.CssSelector("input[value='Selenium IDE']"));
                chkBx_IDE.Click();

                driver.Quit();
            } catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
