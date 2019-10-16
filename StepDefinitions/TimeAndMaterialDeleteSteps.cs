using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace sep2019.StepDefinitions
{
    [Binding]
    public class TimeAndMaterialDeleteSteps
    {
        IWebDriver driver;
        [Given(@"I have logged in to Turn up portal")]
        public void GivenIHaveLoggedInToTurnUpPortal()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2fTimeMaterial%2fCreate");
            //TC1-create and verify the time n material
            //login
            LoginPage loginPage = new LoginPage();
            loginPage.LoginSuccess(driver);
        }
        
        [Given(@"I have navigated to time and material page")]
        public void GivenIHaveNavigatedToTimeAndMaterialPage()
        {
            HomePage home = new HomePage(driver);
            home.ClickAdminstration();
            home.ClickTimenMaterial();
        }
        
        [When(@"I clicked on delete button")]
        public void WhenIClickedOnDeleteButton()
        {
            DeletenValidateTimenMaterial deletedatatimenmaterial = new DeletenValidateTimenMaterial(driver);
            deletedatatimenmaterial.Deletetimenmaterialdata();
        }
        
        [Then(@"I should be able to delete the data\.")]
        public void ThenIShouldBeAbleToDeleteTheData_()
        {
            ValidateDeleteTimenMaterialcs validatingdeleteddata = new ValidateDeleteTimenMaterialcs(driver);
            validatingdeleteddata.Validatedeleteddata();
        }
    }
}
