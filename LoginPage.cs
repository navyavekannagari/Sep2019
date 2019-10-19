using OpenQA.Selenium;
using sep2019.Utilities;
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
            ExcelUtility.PopulateInCollection(@"C:\Users\arun\source\repos\sep2019\sep2019\TestData\TM_TestData.xls", "LoginPage");
            //Login to the application 
            //identify the user name 
            IWebElement username = driver.FindElement(By.Id("UserName"));
            //type the user name as hari
            username.SendKeys(ExcelUtility.ReadData(2,"Username"));
            // identify and type the password as 123123
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys(ExcelUtility.ReadData(2, "Password"));
            //click on login button 
            IWebElement loginBtn = driver.FindElement(By.XPath("//input[@value='Log in']"));
            loginBtn.Click();
        }

    }
}

