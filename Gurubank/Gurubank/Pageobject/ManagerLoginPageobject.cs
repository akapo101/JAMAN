using Gurubank.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gurubank.Pageobject
{
    public class ManagerLoginPageobject
    {
        public ManagerLoginPageobject()
        {
            driver = Hooks.driver;
        }
        WebDriver driver;

        private readonly By userID = By.XPath("//input[@type='text']");
        private readonly By pASSWORD = By.XPath("//input[@type='password']");
        private readonly By clickLogin = By.XPath("//input[@type='submit']");


        public void navigateWebPage()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
        }
        public void loginDetails()
        {
            driver.FindElement(userID).SendKeys("mngr537538");
            driver.FindElement(pASSWORD).SendKeys("pabEzYg");
        }

        public void ClickLogin()
        {
            driver.FindElement(clickLogin).Click();
        }
    }
}
