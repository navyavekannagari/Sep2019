using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep2019
{
    class TimeMaterialTests
    {
        IWebDriver driver;
        [SetUp]
        public void BeforeEachtest()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2fTimeMaterial%2fCreate");
            //TC1-create and verify the time n material
            //login
            LoginPage loginPage = new LoginPage();
            loginPage.LoginSuccess(driver);
        }
        [TearDown]
        public void AftereachTest()
        {
            driver.Quit();
        }
        [Test]
        public void CreatenValidateTests()
        {
            HomePage home = new HomePage(driver);
            home.ClickAdminstration();
            home.ClickTimenMaterial();
            //EditTimenMaterial editing = new EditTimenMaterial(driver);
            //editing.EditData();
            TimeMaterialCreatePage timeMaterialCreate = new TimeMaterialCreatePage(driver);
            timeMaterialCreate.FillInValidDetails();
            timeMaterialCreate.ClickSave();

            //TimeMaterialPage timeMaterial = new TimeMaterialPage(driver);
            ////timeMaterial.ClickCreateNewBtn();
            //timeMaterial.ValidateRecord();
        }
        [Test]
        public void EditnValidate()
        {
            HomePage home = new HomePage(driver);
            home.ClickAdminstration();
            home.ClickTimenMaterial();
            EditTimenMaterial editing = new EditTimenMaterial(driver);
            editing.EditData();
            TimeMaterialCreatePage timeMaterialCreate = new TimeMaterialCreatePage(driver);
            //timeMaterialCreate.FillInValidDetails();
            timeMaterialCreate.ClickSave();
        }
        [Test]
        public void ValidationforEdittimematerialdata()
        {
            HomePage home = new HomePage(driver);
            home.ClickAdminstration();
            home.ClickTimenMaterial();
            ValidationEditTimematerial validation = new ValidationEditTimematerial(driver);
            validation.ValidationofEdit();
        }
        [Test]
        public void DeleteValidataforTimenMaterial()
        {
            HomePage home = new HomePage(driver);
            home.ClickAdminstration();
            home.ClickTimenMaterial();
            DeletenValidateTimenMaterial deletedatatimenmaterial = new DeletenValidateTimenMaterial(driver);
            deletedatatimenmaterial.Deletetimenmaterialdata();
        }
        [Test]
        public void ValidationforDeletedData()
        {
            HomePage home = new HomePage(driver);
            home.ClickAdminstration();
            home.ClickTimenMaterial();
            ValidateDeleteTimenMaterialcs validatingdeleteddata = new ValidateDeleteTimenMaterialcs(driver);
            validatingdeleteddata.Validatedeleteddata();
        }
        }
    }

