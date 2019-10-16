using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep2019
{
    class LoginPage
    {
        
       internal void LoginSuccess(IWebDriver driver)
        {
            //Login to the application 
            //identify the user name 
            IWebElement username = driver.FindElement(By.Id("UserName"));
            //type the user name as hari
            username.SendKeys("hari");
            // identify and type the password as 123123
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");
            //click on login button 
            IWebElement loginBtn = driver.FindElement(By.XPath("//input[@value='Log in']"));
            loginBtn.Click();
        }

    }
}

