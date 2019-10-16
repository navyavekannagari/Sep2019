using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sep2019
{
    internal class TimeMaterialPage
    {
        private IWebDriver driver;
        public TimeMaterialPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        internal void ClickCreateNewBtn()
        {
            driver.FindElement(By.XPath("//a[@href='/TimeMaterial/Create']")).Click();
        }
        internal void ValidateRecord()
        {
            Thread.Sleep(3000);
            try
            {
                while (true)
                {
                    for (var i = 1; i <= 10; i++)
                    {
                        IWebElement code = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[1]"));
                        Console.WriteLine(code.Text);
                        if (code.Text == "satinn2")
                        {
                            Console.WriteLine("success");
                            return;
                        }
                    }
                    driver.FindElement(By.XPath("//span[contains(.,'Go to the next page')]")).Click();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Failed");
            }
        }
    }
}


