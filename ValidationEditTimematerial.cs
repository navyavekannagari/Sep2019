using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sep2019
{
    class ValidationEditTimematerial
    {
        private IWebDriver driver;
        public ValidationEditTimematerial(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void ValidationofEdit()
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
                            Console.WriteLine("Test Success");
                            return;
                        }
                    }
                    driver.FindElement(By.XPath("//span[contains(.,'Go to the next page')]")).Click();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Test failed");
            }
        }
    }
}

