using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sep2019
{
    class DeletenValidateTimenMaterial
    {
        private IWebDriver driver;
        public DeletenValidateTimenMaterial(IWebDriver driver)
        {
            this.driver = driver;
        }
        internal void Deletetimenmaterialdata()
        {
            // IWebElement deletdata = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[6]/td[1]"));
            //Console.WriteLine("deletdata.Text");
            Thread.Sleep(8000);
            IWebElement deletedata = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[3]/td[5]/a[2]"));
            deletedata.Click();
            Thread.Sleep(8000);
            var alert = driver.SwitchTo().Alert();
            Thread.Sleep(8000);
            var expectedAlertText = "Are you sure you want to delete this record?";
            Assert.AreEqual(expectedAlertText, alert.Text);
            alert.Accept();
            
        }
        
           
        }
    }


