using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sep2019
{
    internal class TimeMaterialCreatePage
    {
        private IWebDriver driver;
        public TimeMaterialCreatePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        internal void FillInValidDetails()
        {
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//input[@id='Code']")).SendKeys("Navya");
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//input[@id='Description']")).SendKeys("uploadfile");
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//input[contains(@class,'k-formatted-value k-input')]")).SendKeys("10");
            Thread.Sleep(5000);
        }
        
        internal void AttachFile()
        {
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[6]/div")).Click();
            SendKeys.SendWait(@"C:\Users\arun\source\repos\sep2019\sep2019\papaya.jpg");
            SendKeys.SendWait("{Enter}");
        }
        internal void ClickSave()
        {
            driver.FindElement(By.XPath("//input[@id='SaveButton']")).Click();
        }
    }
}