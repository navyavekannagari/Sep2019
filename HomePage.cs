using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep2019
{
    class HomePage
    {
        private IWebDriver drv;
        public HomePage(IWebDriver driver)

        {

            this.drv = driver;
        }
        internal void ClickAdminstration()
        {
        IWebElement AdminLink = drv.FindElement(By.XPath("//a[@href='#'][contains(.,'Administration')]"));
        AdminLink.Click();
        }
        internal void ClickTimenMaterial()
        {
       drv.FindElement(By.XPath("//a[@href='/TimeMaterial']")).Click();
        }
        }
        }
    

