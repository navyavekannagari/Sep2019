using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
driver.FindElement(By.XPath("//input[@id='Code']")).SendKeys("qwerty");
driver.FindElement(By.XPath("//input[@id='Description']")).SendKeys("asdfghgf");
driver.FindElement(By.XPath("//input[contains(@class,'k-formatted-value k-input')]")).SendKeys("10");
}
internal void ClickSave()
{
driver.FindElement(By.XPath("//input[@id='SaveButton']")).Click();
}
}

}