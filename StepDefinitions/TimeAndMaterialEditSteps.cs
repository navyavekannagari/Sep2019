using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace sep2019.StepDefinitions
{
    [Binding]
    public class TimeAndMaterialEditSteps
    {
        IWebDriver driver;
        [Given(@"i have logged to TurnUp portal")]
        public void GivenIHaveLoggedToTurnUpPortal()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2fTimeMaterial%2fCreate");
            //TC1-create and verify the time n material
            //login
            LoginPage loginPage = new LoginPage();
            loginPage.LoginSuccess(driver);
        }
        
        [Given(@"and Navigated to Time and Material page")]
        public void GivenAndNavigatedToTimeAndMaterialPage()
        {
            HomePage home = new HomePage(driver);
            home.ClickAdminstration();
            home.ClickTimenMaterial();
        }
        
        [When(@"i clicked on edit the data and fill the valud data")]
        public void WhenIClickedOnEditTheDataAndFillTheValudData()
        {
            EditTimenMaterial editing = new EditTimenMaterial(driver);
            editing.EditData();
            
            //timeMaterialCreate.FillInValidDetails();
            
        }
        
        [Then(@"i should be able to save the edited data\.")]
        public void ThenIShouldBeAbleToSaveTheEditedData_()
        {
            TimeMaterialCreatePage timeMaterialCreate = new TimeMaterialCreatePage(driver);
            timeMaterialCreate.ClickSave();
        }
    }
}
