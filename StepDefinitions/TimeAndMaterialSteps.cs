using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace sep2019.StepDefinitions
{
    [Binding]
    public class TimeAndMaterialSteps
    {
        IWebDriver driver;
        [Given(@"I have logged in to Turnup portal\.")]
        public void GivenIHaveLoggedInToTurnupPortal_()

        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2fTimeMaterial%2fCreate");
            //TC1-create and verify the time n material
            //login
            LoginPage loginPage = new LoginPage();
            loginPage.LoginSuccess(driver);
        }
        
        [Given(@"I have Navigated to Time and Material page\.")]
        public void GivenIHaveNavigatedToTimeAndMaterialPage_()
        {
            HomePage home = new HomePage(driver);
            home.ClickAdminstration();
            home.ClickTimenMaterial();
        }
        
        [Then(@"I should be able to create a time record succesfully\.")]
        public void ThenIShouldBeAbleToCreateATimeRecordSuccesfully_()
        {
            TimeMaterialCreatePage timeMaterialCreate = new TimeMaterialCreatePage(driver);
            timeMaterialCreate.FillInValidDetails();
            timeMaterialCreate.ClickSave();

        }
    }
}
