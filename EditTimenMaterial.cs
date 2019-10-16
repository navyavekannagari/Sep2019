using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sep2019
{
    class EditTimenMaterial
    {
        IWebDriver driver;
        public EditTimenMaterial(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void EditData()
        {

            //Thread.Sleep(8000);
            IWebElement list1 = driver.FindElement(By.XPath("(//span[@unselectable='on'][contains(.,'select')])[4]"));
            list1.Click();
            
            
            Thread.Sleep(8000);
            // Console.WriteLine(list.Text);
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[5]/td[5]/a[1]")).Click();
            Thread.Sleep(8000);
            driver.FindElement(By.XPath("//*[@id=\"Code\"]")).Clear();
            Thread.Sleep(8000);
            driver.FindElement(By.XPath("//*[@id=\"Code\"]")).SendKeys("satinn2");
            Thread.Sleep(8000);
            driver.FindElement(By.XPath("//*[@id=\"Description\"]")).Clear();
            Thread.Sleep(8000);
            driver.FindElement(By.XPath("//*[@id=\"Description\"]")).SendKeys("Material2");
            Thread.Sleep(8000);
            {
                Console.WriteLine("success");
            }
             
            }
        }
    }

   
    

