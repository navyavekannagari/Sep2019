using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep2019
{
    class Mainpage
    {
        static void Main(string[] args)
        {
            // instance of browser 

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2fTimeMaterial%2fCreate");
            //TC1-create and verify the time n material
            //loing
            LoginPage loginPage = new LoginPage();
            loginPage.LoginSuccess(driver);
            //Home page
            //HomePage home = new HomePage(driver);
            //home.ClickAdminstration();
            //home.ClickTimenMaterial();
            // Time n Material page
            //TimeMaterialPage timeMaterial = new TimeMaterialPage(driver);
            //timeMaterial.ClickCreateNewBtn();
            //timeMaterial.Validaterecord();
            //Create Time n Material Page
            //TimeMaterialCreatePage timeMaterialCreate = new TimeMaterialCreatePage(driver);
            //timeMaterialCreate.FillInValidDetails();
            //timeMaterialCreate.ClickSave();
            //validate record

            //TC2 - Edit and verify the time n material

            //TC3 - Delete and verify 

            Console.ReadKey();

            driver.Quit();
    }
    }

    }

