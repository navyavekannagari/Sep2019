using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sep2019
{
    class ValidateDeleteTimenMaterialcs
    {
        private IWebDriver driver;
        public ValidateDeleteTimenMaterialcs(IWebDriver driver)
        {
            this.driver = driver;

        }
        internal void Validatedeleteddata()
        {
            Thread.Sleep(3000);
            try
            {
                while (true)
                {
                    for (var i = 1; i <= 10; i++)
                    {
                        IWebElement codedata = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[1]"));
                        Console.WriteLine(codedata.Text);
                        if (codedata.Text == "234")
                        {
                            Console.WriteLine("failed");
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